namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_AirRulesRQRuleReqInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FareRuleResponseInfoTypeFareRuleInfo))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FareInfoType
    {

        private System.DateTime departureDateField;

        private bool departureDateFieldSpecified;

        private FareInfoTypeFareReference[] fareReferenceField;

        private FareInfoTypeRuleInfo ruleInfoField;

        private CompanyNameType filingAirlineField;

        private CompanyNameType[] marketingAirlineField;

        private LocationType departureAirportField;

        private LocationType arrivalAirportField;

        private FareInfoTypeDate[] dateField;

        private FareInfoTypeFareInfo[] fareInfoField;

        private FareInfoTypeDiscountPricing discountPricingField;

        private FareInfoTypeCity[] cityField;

        private FareInfoTypeAirport[] airportField;

        private bool negotiatedFareField;

        private string negotiatedFareCodeField;

        private string currencyCodeField;

        private string tariffNumberField;

        private string ruleNumberField;

        private string routingNumberField;

        public FareInfoType()
        {
            this.negotiatedFareField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public System.DateTime DepartureDate
        {
            get
            {
                return this.departureDateField;
            }
            set
            {
                this.departureDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepartureDateSpecified
        {
            get
            {
                return this.departureDateFieldSpecified;
            }
            set
            {
                this.departureDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FareReference", Order = 1)]
        public FareInfoTypeFareReference[] FareReference
        {
            get
            {
                return this.fareReferenceField;
            }
            set
            {
                this.fareReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public FareInfoTypeRuleInfo RuleInfo
        {
            get
            {
                return this.ruleInfoField;
            }
            set
            {
                this.ruleInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CompanyNameType FilingAirline
        {
            get
            {
                return this.filingAirlineField;
            }
            set
            {
                this.filingAirlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MarketingAirline", Order = 4)]
        public CompanyNameType[] MarketingAirline
        {
            get
            {
                return this.marketingAirlineField;
            }
            set
            {
                this.marketingAirlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public LocationType DepartureAirport
        {
            get
            {
                return this.departureAirportField;
            }
            set
            {
                this.departureAirportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public LocationType ArrivalAirport
        {
            get
            {
                return this.arrivalAirportField;
            }
            set
            {
                this.arrivalAirportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Date", Order = 7)]
        public FareInfoTypeDate[] Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FareInfo", Order = 8)]
        public FareInfoTypeFareInfo[] FareInfo
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public FareInfoTypeDiscountPricing DiscountPricing
        {
            get
            {
                return this.discountPricingField;
            }
            set
            {
                this.discountPricingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("City", Order = 10)]
        public FareInfoTypeCity[] City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Airport", Order = 11)]
        public FareInfoTypeAirport[] Airport
        {
            get
            {
                return this.airportField;
            }
            set
            {
                this.airportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool NegotiatedFare
        {
            get
            {
                return this.negotiatedFareField;
            }
            set
            {
                this.negotiatedFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NegotiatedFareCode
        {
            get
            {
                return this.negotiatedFareCodeField;
            }
            set
            {
                this.negotiatedFareCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TariffNumber
        {
            get
            {
                return this.tariffNumberField;
            }
            set
            {
                this.tariffNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RuleNumber
        {
            get
            {
                return this.ruleNumberField;
            }
            set
            {
                this.ruleNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string RoutingNumber
        {
            get
            {
                return this.routingNumberField;
            }
            set
            {
                this.routingNumberField = value;
            }
        }
    }
}