namespace AWS.ViewModels.BaseClasses
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SearchInsurancePlansResponse", WrapperNamespace = "http://epowerv5.amadeus.com.tr/WS", IsWrapped = true)]
    public partial class SearchInsurancePlansResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public OTA_InsurancePlanSearchRS OTA_InsurancePlanSearchRS;

        public SearchInsurancePlansResponse()
        {
        }

        public SearchInsurancePlansResponse(OTA_InsurancePlanSearchRS OTA_InsurancePlanSearchRS)
        {
            this.OTA_InsurancePlanSearchRS = OTA_InsurancePlanSearchRS;
        }
    }
}