namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RuleInfosDetails
    {

        private string ruleTitleField;

        private string ruleTextField;

        private string ruleDataListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RuleTitle
        {
            get
            {
                return this.ruleTitleField;
            }
            set
            {
                this.ruleTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RuleText
        {
            get
            {
                return this.ruleTextField;
            }
            set
            {
                this.ruleTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RuleDataList
        {
            get
            {
                return this.ruleDataListField;
            }
            set
            {
                this.ruleDataListField = value;
            }
        }
    }
}