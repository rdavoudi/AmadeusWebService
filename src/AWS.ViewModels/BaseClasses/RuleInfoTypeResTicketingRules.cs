namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RuleInfoTypeResTicketingRules
    {

        private RuleInfoTypeResTicketingRulesAdvResTicketing advResTicketingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public RuleInfoTypeResTicketingRulesAdvResTicketing AdvResTicketing
        {
            get
            {
                return this.advResTicketingField;
            }
            set
            {
                this.advResTicketingField = value;
            }
        }
    }
}