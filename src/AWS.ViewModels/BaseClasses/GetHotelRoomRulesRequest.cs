namespace AWS.ViewModels.BaseClasses
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetHotelRoomRules", WrapperNamespace = "http://epowerv5.amadeus.com.tr/WS", IsWrapped = true)]
    public partial class GetHotelRoomRulesRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
        public AuthenticationSoapHeader AuthenticationSoapHeader;

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
        public GenericSoapHeader GenericSoapHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public OTA_HotelRoomRuleRQ OTA_HotelRoomRuleRQ;

        public GetHotelRoomRulesRequest()
        {
        }

        public GetHotelRoomRulesRequest(AuthenticationSoapHeader AuthenticationSoapHeader, GenericSoapHeader GenericSoapHeader, OTA_HotelRoomRuleRQ OTA_HotelRoomRuleRQ)
        {
            this.AuthenticationSoapHeader = AuthenticationSoapHeader;
            this.GenericSoapHeader = GenericSoapHeader;
            this.OTA_HotelRoomRuleRQ = OTA_HotelRoomRuleRQ;
        }
    }
}