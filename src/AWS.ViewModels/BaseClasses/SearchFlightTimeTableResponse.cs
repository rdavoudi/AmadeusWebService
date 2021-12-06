namespace AWS.ViewModels.BaseClasses
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SearchFlightTimeTableResponse", WrapperNamespace = "http://epowerv5.amadeus.com.tr/WS", IsWrapped = true)]
    public partial class SearchFlightTimeTableResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public SearchFlightTimeTableResponseOTA_AirScheduleRS OTA_AirScheduleRS;

        public SearchFlightTimeTableResponse()
        {
        }

        public SearchFlightTimeTableResponse(SearchFlightTimeTableResponseOTA_AirScheduleRS OTA_AirScheduleRS)
        {
            this.OTA_AirScheduleRS = OTA_AirScheduleRS;
        }
    }
}