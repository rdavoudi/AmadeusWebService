namespace AWS.ViewModels.BaseClasses
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SearchFlightTimeTable", WrapperNamespace = "http://epowerv5.amadeus.com.tr/WS", IsWrapped = true)]
    public partial class SearchFlightTimeTableRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
        public AuthenticationSoapHeader AuthenticationSoapHeader;

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
        public GenericSoapHeader GenericSoapHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public SearchFlightTimeTableOTA_AirScheduleRQ OTA_AirScheduleRQ;

        public SearchFlightTimeTableRequest()
        {
        }

        public SearchFlightTimeTableRequest(AuthenticationSoapHeader AuthenticationSoapHeader, GenericSoapHeader GenericSoapHeader, SearchFlightTimeTableOTA_AirScheduleRQ OTA_AirScheduleRQ)
        {
            this.AuthenticationSoapHeader = AuthenticationSoapHeader;
            this.GenericSoapHeader = GenericSoapHeader;
            this.OTA_AirScheduleRQ = OTA_AirScheduleRQ;
        }
    }
}