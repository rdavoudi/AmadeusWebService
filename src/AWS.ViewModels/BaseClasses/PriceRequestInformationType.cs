namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PriceRequestInformationType
    {

        private PriceRequestInformationTypeNegotiatedFareCode[] negotiatedFareCodeField;

        private PriceRequestInformationTypeRebookOption[] rebookOptionField;

        private string fareQualifierField;

        private bool negotiatedFaresOnlyField;

        private bool negotiatedFaresOnlyFieldSpecified;

        private string currencyCodeField;

        private PricingSourceType pricingSourceField;

        private bool pricingSourceFieldSpecified;

        private bool repriceField;

        private bool repriceFieldSpecified;

        private CabinType cabinTypeField;

        private bool cabinTypeFieldSpecified;

        private string ticketingCountryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NegotiatedFareCode", Order = 0)]
        public PriceRequestInformationTypeNegotiatedFareCode[] NegotiatedFareCode
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
        [System.Xml.Serialization.XmlElementAttribute("RebookOption", Order = 1)]
        public PriceRequestInformationTypeRebookOption[] RebookOption
        {
            get
            {
                return this.rebookOptionField;
            }
            set
            {
                this.rebookOptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareQualifier
        {
            get
            {
                return this.fareQualifierField;
            }
            set
            {
                this.fareQualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NegotiatedFaresOnly
        {
            get
            {
                return this.negotiatedFaresOnlyField;
            }
            set
            {
                this.negotiatedFaresOnlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NegotiatedFaresOnlySpecified
        {
            get
            {
                return this.negotiatedFaresOnlyFieldSpecified;
            }
            set
            {
                this.negotiatedFaresOnlyFieldSpecified = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Reprice
        {
            get
            {
                return this.repriceField;
            }
            set
            {
                this.repriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RepriceSpecified
        {
            get
            {
                return this.repriceFieldSpecified;
            }
            set
            {
                this.repriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CabinType CabinType
        {
            get
            {
                return this.cabinTypeField;
            }
            set
            {
                this.cabinTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CabinTypeSpecified
        {
            get
            {
                return this.cabinTypeFieldSpecified;
            }
            set
            {
                this.cabinTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketingCountry
        {
            get
            {
                return this.ticketingCountryField;
            }
            set
            {
                this.ticketingCountryField = value;
            }
        }
    }
}