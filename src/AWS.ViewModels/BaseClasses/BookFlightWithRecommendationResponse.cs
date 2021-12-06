namespace AWS.ViewModels.BaseClasses
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "BookFlightWithRecommendationResponse", WrapperNamespace = "http://epowerv5.amadeus.com.tr/WS", IsWrapped = true)]
    public partial class BookFlightWithRecommendationResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public BookFlightWithRecommendationResponseOTA_AirBookRS OTA_AirBookRS;

        public BookFlightWithRecommendationResponse()
        {
        }

        public BookFlightWithRecommendationResponse(BookFlightWithRecommendationResponseOTA_AirBookRS OTA_AirBookRS)
        {
            this.OTA_AirBookRS = OTA_AirBookRS;
        }
    }
}