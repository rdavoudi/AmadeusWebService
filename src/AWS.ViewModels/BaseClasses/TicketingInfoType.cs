namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TicketingInfoRS_Type))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class TicketingInfoType
    {

        private FreeTextType[] ticketAdvisoryField;

        private System.DateTime ticketTimeLimitField;

        private bool ticketTimeLimitFieldSpecified;

        private System.DateTime oldTicketTimeLimitField;

        private bool oldTicketTimeLimitFieldSpecified;

        private TicketType ticketTypeField;

        private bool ticketTypeFieldSpecified;

        private string ticketingStatusField;

        private string[] flightSegmentRefNumberField;

        private string[] travelerRefNumberField;

        private bool reverseTktgSegmentsIndField;

        private bool reverseTktgSegmentsIndFieldSpecified;

        private string pseudoCityCodeField;

        private string requestedTicketingDateField;

        private string timeLimitMinutesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TicketAdvisory", Order = 0)]
        public FreeTextType[] TicketAdvisory
        {
            get
            {
                return this.ticketAdvisoryField;
            }
            set
            {
                this.ticketAdvisoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime TicketTimeLimit
        {
            get
            {
                return this.ticketTimeLimitField;
            }
            set
            {
                this.ticketTimeLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TicketTimeLimitSpecified
        {
            get
            {
                return this.ticketTimeLimitFieldSpecified;
            }
            set
            {
                this.ticketTimeLimitFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime OldTicketTimeLimit
        {
            get
            {
                return this.oldTicketTimeLimitField;
            }
            set
            {
                this.oldTicketTimeLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OldTicketTimeLimitSpecified
        {
            get
            {
                return this.oldTicketTimeLimitFieldSpecified;
            }
            set
            {
                this.oldTicketTimeLimitFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TicketType TicketType
        {
            get
            {
                return this.ticketTypeField;
            }
            set
            {
                this.ticketTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TicketTypeSpecified
        {
            get
            {
                return this.ticketTypeFieldSpecified;
            }
            set
            {
                this.ticketTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketingStatus
        {
            get
            {
                return this.ticketingStatusField;
            }
            set
            {
                this.ticketingStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] FlightSegmentRefNumber
        {
            get
            {
                return this.flightSegmentRefNumberField;
            }
            set
            {
                this.flightSegmentRefNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] TravelerRefNumber
        {
            get
            {
                return this.travelerRefNumberField;
            }
            set
            {
                this.travelerRefNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReverseTktgSegmentsInd
        {
            get
            {
                return this.reverseTktgSegmentsIndField;
            }
            set
            {
                this.reverseTktgSegmentsIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReverseTktgSegmentsIndSpecified
        {
            get
            {
                return this.reverseTktgSegmentsIndFieldSpecified;
            }
            set
            {
                this.reverseTktgSegmentsIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PseudoCityCode
        {
            get
            {
                return this.pseudoCityCodeField;
            }
            set
            {
                this.pseudoCityCodeField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string TimeLimitMinutes
        {
            get
            {
                return this.timeLimitMinutesField;
            }
            set
            {
                this.timeLimitMinutesField = value;
            }
        }
    }
}