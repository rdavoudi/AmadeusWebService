namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CoverageDetailsType : FormattedTextTextType
    {

        private CoverageTextType coverageTextTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CoverageTextType CoverageTextType
        {
            get
            {
                return this.coverageTextTypeField;
            }
            set
            {
                this.coverageTextTypeField = value;
            }
        }
    }
}