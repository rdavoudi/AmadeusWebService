namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PTCFareBreakdownType
    {

        private PassengerTypeQuantityType passengerTypeQuantityField;

        private string[] fareBasisCodesField;

        private FareType passengerFareField;

        private PTCFareBreakdownTypeTravelerRefNumber[] travelerRefNumberField;

        private ArrayOfPTCFareBreakdownTypeTicketDesignatorTicketDesignator[] ticketDesignatorsField;

        private PTCFareBreakdownTypeEndorsements endorsementsField;

        private PTCFareBreakdownTypeFareInfo[] fareInfoField;

        private PTCFareBreakdownTypePricingUnit[] pricingUnitField;

        private PricingSourceType pricingSourceField;

        private bool pricingSourceFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PassengerTypeQuantityType PassengerTypeQuantity
        {
            get
            {
                return this.passengerTypeQuantityField;
            }
            set
            {
                this.passengerTypeQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("FareBasisCode", IsNullable = false)]
        public string[] FareBasisCodes
        {
            get
            {
                return this.fareBasisCodesField;
            }
            set
            {
                this.fareBasisCodesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public FareType PassengerFare
        {
            get
            {
                return this.passengerFareField;
            }
            set
            {
                this.passengerFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TravelerRefNumber", Order = 3)]
        public PTCFareBreakdownTypeTravelerRefNumber[] TravelerRefNumber
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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TicketDesignator", IsNullable = false)]
        public ArrayOfPTCFareBreakdownTypeTicketDesignatorTicketDesignator[] TicketDesignators
        {
            get
            {
                return this.ticketDesignatorsField;
            }
            set
            {
                this.ticketDesignatorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public PTCFareBreakdownTypeEndorsements Endorsements
        {
            get
            {
                return this.endorsementsField;
            }
            set
            {
                this.endorsementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FareInfo", Order = 6)]
        public PTCFareBreakdownTypeFareInfo[] FareInfo
        {
            get
            {
                return this.fareInfoField;
            }
            set
            {
                this.fareInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PricingUnit", Order = 7)]
        public PTCFareBreakdownTypePricingUnit[] PricingUnit
        {
            get
            {
                return this.pricingUnitField;
            }
            set
            {
                this.pricingUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PricingSourceType PricingSource
        {
            get
            {
                return this.pricingSourceField;
            }
            set
            {
                this.pricingSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PricingSourceSpecified
        {
            get
            {
                return this.pricingSourceFieldSpecified;
            }
            set
            {
                this.pricingSourceFieldSpecified = value;
            }
        }
    }
}