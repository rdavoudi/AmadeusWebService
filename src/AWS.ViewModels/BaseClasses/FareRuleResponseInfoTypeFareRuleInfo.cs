namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FareRuleResponseInfoTypeFareRuleInfo : FareInfoType
    {

        private FormattedTextType fareRulesField;

        private string languageRequestedField;

        private string languageReturnedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public FormattedTextType FareRules
        {
            get
            {
                return this.fareRulesField;
            }
            set
            {
                this.fareRulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LanguageRequested
        {
            get
            {
                return this.languageRequestedField;
            }
            set
            {
                this.languageRequestedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LanguageReturned
        {
            get
            {
                return this.languageReturnedField;
            }
            set
            {
                this.languageReturnedField = value;
            }
        }
    }
}