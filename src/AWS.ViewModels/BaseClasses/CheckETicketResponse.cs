namespace AWS.ViewModels.BaseClasses
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CheckETicketResponse", WrapperNamespace = "http://epowerv5.amadeus.com.tr/WS", IsWrapped = true)]
    public partial class CheckETicketResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public OTA_AirCheckETicketRS OTA_AirCheckETicketRS;

        public CheckETicketResponse()
        {
        }

        public CheckETicketResponse(OTA_AirCheckETicketRS OTA_AirCheckETicketRS)
        {
            this.OTA_AirCheckETicketRS = OTA_AirCheckETicketRS;
        }
    }
}