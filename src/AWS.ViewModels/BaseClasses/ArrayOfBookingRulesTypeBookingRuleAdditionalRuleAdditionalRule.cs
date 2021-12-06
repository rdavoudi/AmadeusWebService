namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfBookingRulesTypeBookingRuleAdditionalRuleAdditionalRule
    {

        private ArrayOfBookingRulesTypeBookingRuleAdditionalRuleAdditionalRuleAdditionalRule additionalRuleField;

        private bool additionalRuleFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ArrayOfBookingRulesTypeBookingRuleAdditionalRuleAdditionalRuleAdditionalRule AdditionalRule
        {
            get
            {
                return this.additionalRuleField;
            }
            set
            {
                this.additionalRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdditionalRuleSpecified
        {
            get
            {
                return this.additionalRuleFieldSpecified;
            }
            set
            {
                this.additionalRuleFieldSpecified = value;
            }
        }
    }
}