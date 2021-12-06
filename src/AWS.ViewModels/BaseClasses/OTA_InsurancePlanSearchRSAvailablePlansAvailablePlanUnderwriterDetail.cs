namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_InsurancePlanSearchRSAvailablePlansAvailablePlanUnderwriterDetail
    {

        private CompanyNameType underwriterCompanyField;

        private FormattedTextType underwriterDescriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CompanyNameType UnderwriterCompany
        {
            get
            {
                return this.underwriterCompanyField;
            }
            set
            {
                this.underwriterCompanyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public FormattedTextType UnderwriterDescription
        {
            get
            {
                return this.underwriterDescriptionField;
            }
            set
            {
                this.underwriterDescriptionField = value;
            }
        }
    }
}