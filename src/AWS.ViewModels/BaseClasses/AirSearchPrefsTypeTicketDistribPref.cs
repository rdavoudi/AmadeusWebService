namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirSearchPrefsTypeTicketDistribPref : TicketDistribPrefType
    {

        private System.DateTime lastTicketDateField;

        private bool lastTicketDateFieldSpecified;

        private System.DateTime firstTicketDateField;

        private bool firstTicketDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastTicketDate
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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastTicketDateSpecified
        {
            get
            {
                return this.lastTicketDateFieldSpecified;
            }
            set
            {
                this.lastTicketDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime FirstTicketDate
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FirstTicketDateSpecified
        {
            get
            {
                return this.firstTicketDateFieldSpecified;
            }
            set
            {
                this.firstTicketDateFieldSpecified = value;
            }
        }
    }
}