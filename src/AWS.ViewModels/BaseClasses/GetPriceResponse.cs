namespace AWS.ViewModels.BaseClasses
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetPriceResponse", WrapperNamespace = "http://epowerv5.amadeus.com.tr/WS", IsWrapped = true)]
    public partial class GetPriceResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public GetPriceResponseOTA_AirLowFareSearchRS OTA_AirLowFareSearchRS;

        public GetPriceResponse()
        {
        }

        public GetPriceResponse(GetPriceResponseOTA_AirLowFareSearchRS OTA_AirLowFareSearchRS)
        {
            this.OTA_AirLowFareSearchRS = OTA_AirLowFareSearchRS;
        }
    }
}