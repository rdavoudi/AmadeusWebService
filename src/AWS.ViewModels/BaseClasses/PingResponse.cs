namespace AWS.ViewModels.BaseClasses
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", IsNullable = false)]
    public partial class PingResponse
    {

        //[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public PingResponseOTA_PingRS OTA_PingRS;


        public PingResponse()
        {
        }

        public PingResponse(PingResponseOTA_PingRS OTA_PingRS)
        {
            this.OTA_PingRS = OTA_PingRS;
        }
    }
}