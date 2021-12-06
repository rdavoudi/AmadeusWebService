using AWS.ViewModels;
using AWS.ViewModels.BaseClasses;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AWS.Services
{
    public class AmadeusService
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public AmadeusService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor ?? throw new ArgumentNullException(nameof(contextAccessor));
        }

        private T DeserializeJson<T>(string json)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            };
            return JsonConvert.DeserializeObject<T>(json, settings);
        }

        private string SerializedJson<T>(T model)
        {
            return JsonConvert.SerializeObject(model,
                new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Include
                });
        }

        public Tuple<T, Errors> DeserializeXMLString<T>(string xmlResult)
        {
            using (StringReader reader = new StringReader(xmlResult))
            {
                try
                {
                    if (xmlResult.Contains("<Errors>"))
                    {
                        XmlSerializer errSerializer = new XmlSerializer(typeof(Errors));
                        Errors errResult = (Errors)errSerializer.Deserialize(reader);
                        return new Tuple<T, Errors>((T)Activator.CreateInstance(typeof(T)), errResult);
                    }

                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    T result = (T)serializer.Deserialize(reader);
                    return new Tuple<T, Errors>(result, null);
                }
                catch (Exception e)
                {
                    throw new Exception(xmlResult, e);
                }
            }
        }

        private void SetCookie(string id)
        {
            var sessionViewModel = new SessionViewModel { Id = id, Date = DateTime.Now };

            var option = new Microsoft.AspNetCore.Http.CookieOptions
            {
                Expires = DateTime.Now.AddMonths(1)
            };

            if (_contextAccessor.HttpContext == null) return;

            _contextAccessor.HttpContext?.Response.Cookies.Append("your key", SerializedJson<SessionViewModel>(sessionViewModel), option);

            try
            {
                if (_contextAccessor.HttpContext.Response.Headers.All(q => q.Key != "AmadeusSession"))
                    _contextAccessor.HttpContext?.Response.Headers.Append("AmadeusSession", sessionViewModel.Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public SessionViewModel GetCookie()
        {
            var session = _contextAccessor.HttpContext.Request.Cookies["your-cookie-name"];
            if (session != null)
            {
                var sessionModel = DeserializeJson<SessionViewModel>(session);
                return sessionModel;
            }
            return null;
        }

        public async Task<Tuple<T, string, string, Errors>> SendAmadeusRequest<T>(string RequestXml, string SoapAction = "", string sessionId = "")
        {
            var signout = SoapAction.IndexOf("SignOut", StringComparison.Ordinal) != -1;

            WebRequest req = WebRequest.Create("");

            req.Timeout = 600000;
            //req.Headers.Add("SOAPAction", SoapAction);
            req.ContentType = "text/xml; charset=utf-8";
            req.Method = "POST";

            req.Headers.Add("SOAPAction", "http://epowerv5.amadeus.com.tr/WS/" + SoapAction);

            if (string.IsNullOrEmpty(sessionId))
            {
                var session = GetCookie();
                if (session != null)
                {
                    // Implementing a mechanism for checking session time
                    // If session is expired then session.Id=null;
                    // Updating cookie
                    req.Headers.Add("Cookie", session.Id);
                }
            }
            else // for sign out task
            {
                req.Headers.Add("Cookie", sessionId);
            }
            
            //we add the SessionId to headers if we received before.

            Stream reqStr = await req.GetRequestStreamAsync();
            StreamWriter sw = new StreamWriter(reqStr);
            await sw.WriteAsync(RequestXml);
            sw.Close();
            string strResult = "";

            try
            {
                WebResponse res = await req.GetResponseAsync();
                Stream resStr = res.GetResponseStream();
                StreamReader sr = new StreamReader(resStr);
                strResult = await sr.ReadToEndAsync();

                sr.Close();

                //Receive the SessionId from Headers.
                if (!String.IsNullOrEmpty(res.Headers["Set-Cookie"]))
                {
                    SetCookie(res.Headers["Set-Cookie"]);
                }

                res.Close();
            }
            catch (WebException ex)
            {
                string errMessage = ex.Message;
                strResult = errMessage;
                if (ex.Response != null)
                {
                    Stream resStr = ex.Response.GetResponseStream();
                    StreamReader sr = new StreamReader(resStr);
                    string soapResponse = sr.ReadToEnd();
                    sr.Close();
                    resStr.Close();

                    errMessage += Environment.NewLine + soapResponse;
                    strResult = errMessage;

                    ex.Response.Close();

                    if (signout)
                        sessionId = "";
                    var deserializedXML = DeserializeXMLString<T>(strResult);
                    return new Tuple<T, string, string, Errors>(deserializedXML.Item1, sessionId, errMessage, deserializedXML.Item2);
                }
            }

            if (signout)
                sessionId = "";

            var result = DeserializeXMLString<T>(strResult);
            return new Tuple<T, string, string, Errors>(result.Item1, sessionId, "", result.Item2);
        }
    }
}
