namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfLastTicketingDateDataLastTicketingDateData
    {

        private string pnrNoField;

        private System.DateTime oldLastTicketingDateField;

        private System.DateTime lastTicketingDateField;

        private bool lastTicketingDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PnrNo
        {
            get
            {
                return this.pnrNoField;
            }
            set
            {
                this.pnrNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime OldLastTicketingDate
        {
            get
            {
                return this.oldLastTicketingDateField;
            }
            set
            {
                this.oldLastTicketingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastTicketingDate
        {
            get
            {
                return this.lastTicketingDateField;
            }
            set
            {
                this.lastTicketingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastTicketingDateSpecified
        {
            get
            {
                return this.lastTicketingDateFieldSpecified;
            }
            set
            {
                this.lastTicketingDateFieldSpecified = value;
            }
        }
    }
}