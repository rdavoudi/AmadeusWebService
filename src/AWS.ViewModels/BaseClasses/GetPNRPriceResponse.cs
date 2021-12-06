namespace AWS.ViewModels.BaseClasses
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetPNRPriceResponse", WrapperNamespace = "http://epowerv5.amadeus.com.tr/WS", IsWrapped = true)]
    public partial class GetPNRPriceResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public GetPNRPriceResponseOTA_AirBookRS OTA_AirBookRS;

        public GetPNRPriceResponse()
        {
        }

        public GetPNRPriceResponse(GetPNRPriceResponseOTA_AirBookRS OTA_AirBookRS)
        {
            this.OTA_AirBookRS = OTA_AirBookRS;
        }
    }
}