namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirReservationTypePricingOverview
    {

        private AirReservationTypePricingOverviewPricingIndicator[] pricingIndicatorField;

        private AirReservationTypePricingOverviewAccount[] accountField;

        private FreeTextType[] commentField;

        private string statisticalCodeField;

        private string validatingAirlineCodeField;

        private string departureDateField;

        private string priceTypeField;

        private decimal nUC_RateField;

        private bool nUC_RateFieldSpecified;

        private decimal exchangeRateField;

        private bool exchangeRateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PricingIndicator", Order = 0)]
        public AirReservationTypePricingOverviewPricingIndicator[] PricingIndicator
        {
            get
            {
                return this.pricingIndicatorField;
            }
            set
            {
                this.pricingIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Account", Order = 1)]
        public AirReservationTypePricingOverviewAccount[] Account
        {
            get
            {
                return this.accountField;
            }
            set
            {
                this.accountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comment", Order = 2)]
        public FreeTextType[] Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StatisticalCode
        {
            get
            {
                return this.statisticalCodeField;
            }
            set
            {
                this.statisticalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ValidatingAirlineCode
        {
            get
            {
                return this.validatingAirlineCodeField;
            }
            set
            {
                this.validatingAirlineCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DepartureDate
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PriceType
        {
            get
            {
                return this.priceTypeField;
            }
            set
            {
                this.priceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal NUC_Rate
        {
            get
            {
                return this.nUC_RateField;
            }
            set
            {
                this.nUC_RateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NUC_RateSpecified
        {
            get
            {
                return this.nUC_RateFieldSpecified;
            }
            set
            {
                this.nUC_RateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }
}