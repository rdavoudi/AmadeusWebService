namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RuleInfoType
    {

        private RuleInfoTypeResTicketingRules resTicketingRulesField;

        private StayRestrictionsType lengthOfStayRulesField;

        private RuleInfoTypeChargesRules chargesRulesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public RuleInfoTypeResTicketingRules ResTicketingRules
        {
            get
            {
                return this.resTicketingRulesField;
            }
            set
            {
                this.resTicketingRulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public StayRestrictionsType LengthOfStayRules
        {
            get
            {
                return this.lengthOfStayRulesField;
            }
            set
            {
                this.lengthOfStayRulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public RuleInfoTypeChargesRules ChargesRules
        {
            get
            {
                return this.chargesRulesField;
            }
            set
            {
                this.chargesRulesField = value;
            }
        }
    }
}