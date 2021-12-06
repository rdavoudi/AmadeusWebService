namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RuleInfoTypeResTicketingRulesAdvResTicketing : AdvResTicketingType
    {

        private string firstTicketDateField;

        private string lastTicketDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FirstTicketDate
        {
            get
            {
                return this.firstTicketDateField;
            }
            set
            {
                this.firstTicketDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LastTicketDate
        {
            get
            {
                return this.lastTicketDateField;
            }
            set
            {
                this.lastTicketDateField = value;
            }
        }
    }
}