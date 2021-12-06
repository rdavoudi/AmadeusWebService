namespace AWS.ViewModels.BaseClasses
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetLastTicketingDateResponse", WrapperNamespace = "http://epowerv5.amadeus.com.tr/WS", IsWrapped = true)]
    public partial class GetLastTicketingDateResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public GetLastTicketingDateResponseLastTicketingDateRS LastTicketingDateRS;

        public GetLastTicketingDateResponse()
        {
        }

        public GetLastTicketingDateResponse(GetLastTicketingDateResponseLastTicketingDateRS LastTicketingDateRS)
        {
            this.LastTicketingDateRS = LastTicketingDateRS;
        }
    }
}