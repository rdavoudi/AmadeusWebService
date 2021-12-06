namespace AWS.ViewModels.BaseClasses
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetAncillaryInfoResponse", WrapperNamespace = "http://epowerv5.amadeus.com.tr/WS", IsWrapped = true)]
    public partial class GetAncillaryInfoResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public AncillaryInfoRS AncillaryInfoRS;

        public GetAncillaryInfoResponse()
        {
        }

        public GetAncillaryInfoResponse(AncillaryInfoRS AncillaryInfoRS)
        {
            this.AncillaryInfoRS = AncillaryInfoRS;
        }
    }
}