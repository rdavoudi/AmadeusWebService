namespace AWS.ViewModels.BaseClasses
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetNextFlightResultsResponse", WrapperNamespace = "http://epowerv5.amadeus.com.tr/WS", IsWrapped = true)]
    public partial class GetNextFlightResultsResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public GetNextFlightResultsResponseOTA_AirLowFareSearchRS OTA_AirLowFareSearchRS;

        public GetNextFlightResultsResponse()
        {
        }

        public GetNextFlightResultsResponse(GetNextFlightResultsResponseOTA_AirLowFareSearchRS OTA_AirLowFareSearchRS)
        {
            this.OTA_AirLowFareSearchRS = OTA_AirLowFareSearchRS;
        }
    }
}