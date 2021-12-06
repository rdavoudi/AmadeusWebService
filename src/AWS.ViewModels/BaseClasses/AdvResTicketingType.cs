namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AdvResTicketingType
    {

        private AdvResTicketingTypeAdvReservation advReservationField;

        private AdvResTicketingTypeAdvTicketing advTicketingField;

        private bool advResIndField;

        private bool advResIndFieldSpecified;

        private bool advTicketingIndField;

        private bool advTicketingIndFieldSpecified;

        private string requestedTicketingDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AdvResTicketingTypeAdvReservation AdvReservation
        {
            get
            {
                return this.advReservationField;
            }
            set
            {
                this.advReservationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AdvResTicketingTypeAdvTicketing AdvTicketing
        {
            get
            {
                return this.advTicketingField;
            }
            set
            {
                this.advTicketingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AdvResInd
        {
            get
            {
                return this.advResIndField;
            }
            set
            {
                this.advResIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdvResIndSpecified
        {
            get
            {
                return this.advResIndFieldSpecified;
            }
            set
            {
                this.advResIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AdvTicketingInd
        {
            get
            {
                return this.advTicketingIndField;
            }
            set
            {
                this.advTicketingIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdvTicketingIndSpecified
        {
            get
            {
                return this.advTicketingIndFieldSpecified;
            }
            set
            {
                this.advTicketingIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequestedTicketingDate
        {
            get
            {
                return this.requestedTicketingDateField;
            }
            set
            {
                this.requestedTicketingDateField = value;
            }
        }
    }
}