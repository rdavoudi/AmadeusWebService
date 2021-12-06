namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CoverageType
    {

        private CoverageDetailsType[] detailsField;

        private string coverageType1Field;

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Details", Order = 0)]
        public CoverageDetailsType[] Details
        {
            get
            {
                return this.detailsField;
            }
            set
            {
                this.detailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("CoverageType")]
        public string CoverageType1
        {
            get
            {
                return this.coverageType1Field;
            }
            set
            {
                this.coverageType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }
}