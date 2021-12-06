namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ETicketInfo
    {

        private string agencyTitleField;

        private AddressType agencyAddressField;

        private string agencyTelNoField;

        private string agentIDField;

        private string iATAIDField;

        private System.Nullable<System.DateTime> ticketingDateField;

        private bool ticketingDateFieldSpecified;

        private string passengerName_SurnameField;

        private string frequentFlyerField;

        private string issuingAirlineField;

        private string bookingRefField;

        private string fareCalculationField;

        private string endorsementsField;

        private decimal exchangeRateField;

        private bool exchangeRateFieldSpecified;

        private string paymentTypeField;

        private decimal airFareField;

        private bool airFareFieldSpecified;

        private string airFareCurrencyField;

        private decimal equivalentFareField;

        private decimal serviceFeeField;

        private bool serviceFeeFieldSpecified;

        private string equivalentFareCurrencyField;

        private decimal totalFareField;

        private string totalFareCurrencyField;

        private string ticketCurrencyField;

        private TaxInfo[] taxesField;

        private string controlNumbersField;

        private ETicketItineraryInfo[] itinerariesField;

        private string ticketNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string AgencyTitle
        {
            get
            {
                return this.agencyTitleField;
            }
            set
            {
                this.agencyTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AddressType AgencyAddress
        {
            get
            {
                return this.agencyAddressField;
            }
            set
            {
                this.agencyAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string AgencyTelNo
        {
            get
            {
                return this.agencyTelNoField;
            }
            set
            {
                this.agencyTelNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string AgentID
        {
            get
            {
                return this.agentIDField;
            }
            set
            {
                this.agentIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string IATAID
        {
            get
            {
                return this.iATAIDField;
            }
            set
            {
                this.iATAIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<System.DateTime> TicketingDate
        {
            get
            {
                return this.ticketingDateField;
            }
            set
            {
                this.ticketingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TicketingDateSpecified
        {
            get
            {
                return this.ticketingDateFieldSpecified;
            }
            set
            {
                this.ticketingDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string PassengerName_Surname
        {
            get
            {
                return this.passengerName_SurnameField;
            }
            set
            {
                this.passengerName_SurnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string FrequentFlyer
        {
            get
            {
                return this.frequentFlyerField;
            }
            set
            {
                this.frequentFlyerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string IssuingAirline
        {
            get
            {
                return this.issuingAirlineField;
            }
            set
            {
                this.issuingAirlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string BookingRef
        {
            get
            {
                return this.bookingRefField;
            }
            set
            {
                this.bookingRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string FareCalculation
        {
            get
            {
                return this.fareCalculationField;
            }
            set
            {
                this.fareCalculationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string Endorsements
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public decimal ExchangeRate
        {
            get
            {
                return this.exchangeRateField;
            }
            set
            {
                this.exchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExchangeRateSpecified
        {
            get
            {
                return this.exchangeRateFieldSpecified;
            }
            set
            {
                this.exchangeRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string PaymentType
        {
            get
            {
                return this.paymentTypeField;
            }
            set
            {
                this.paymentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public decimal AirFare
        {
            get
            {
                return this.airFareField;
            }
            set
            {
                this.airFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AirFareSpecified
        {
            get
            {
                return this.airFareFieldSpecified;
            }
            set
            {
                this.airFareFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string AirFareCurrency
        {
            get
            {
                return this.airFareCurrencyField;
            }
            set
            {
                this.airFareCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public decimal EquivalentFare
        {
            get
            {
                return this.equivalentFareField;
            }
            set
            {
                this.equivalentFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public decimal ServiceFee
        {
            get
            {
                return this.serviceFeeField;
            }
            set
            {
                this.serviceFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServiceFeeSpecified
        {
            get
            {
                return this.serviceFeeFieldSpecified;
            }
            set
            {
                this.serviceFeeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public string EquivalentFareCurrency
        {
            get
            {
                return this.equivalentFareCurrencyField;
            }
            set
            {
                this.equivalentFareCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public decimal TotalFare
        {
            get
            {
                return this.totalFareField;
            }
            set
            {
                this.totalFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public string TotalFareCurrency
        {
            get
            {
                return this.totalFareCurrencyField;
            }
            set
            {
                this.totalFareCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public string TicketCurrency
        {
            get
            {
                return this.ticketCurrencyField;
            }
            set
            {
                this.ticketCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 22)]
        public TaxInfo[] Taxes
        {
            get
            {
                return this.taxesField;
            }
            set
            {
                this.taxesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public string ControlNumbers
        {
            get
            {
                return this.controlNumbersField;
            }
            set
            {
                this.controlNumbersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 24)]
        public ETicketItineraryInfo[] Itineraries
        {
            get
            {
                return this.itinerariesField;
            }
            set
            {
                this.itinerariesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketNumber
        {
            get
            {
                return this.ticketNumberField;
            }
            set
            {
                this.ticketNumberField = value;
            }
        }
    }
}