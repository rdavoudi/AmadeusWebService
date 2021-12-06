namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_InsurancePlanSearchRSAvailablePlansAvailablePlanProviderDetail
    {

        private CompanyNameType providerCompanyField;

        private FormattedTextType providerDescriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CompanyNameType ProviderCompany
        {
            get
            {
                return this.providerCompanyField;
            }
            set
            {
                this.providerCompanyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public FormattedTextType ProviderDescription
        {
            get
            {
                return this.providerDescriptionField;
            }
            set
            {
                this.providerDescriptionField = value;
            }
        }
    }
}