namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RuleInfos
    {

        private string categoryTypeField;

        private RuleInfosDetails[] ruleTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string CategoryType
        {
            get
            {
                return this.categoryTypeField;
            }
            set
            {
                this.categoryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RuleText", Order = 1)]
        public RuleInfosDetails[] RuleText
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
    }
}