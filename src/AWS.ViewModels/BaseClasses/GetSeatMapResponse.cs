namespace AWS.ViewModels.BaseClasses
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetSeatMapResponse", WrapperNamespace = "http://epowerv5.amadeus.com.tr/WS", IsWrapped = true)]
    public partial class GetSeatMapResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public OTA_AirSeatMapRS OTA_AirSeatMapRS;

        public GetSeatMapResponse()
        {
        }

        public GetSeatMapResponse(OTA_AirSeatMapRS OTA_AirSeatMapRS)
        {
            this.OTA_AirSeatMapRS = OTA_AirSeatMapRS;
        }
    }
}