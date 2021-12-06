namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscountType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class TotalType
    {

        private TaxesType taxesField;

        private bool isDailyPriceField;

        private bool isRateChangeField;

        private decimal amountBeforeTaxField;

        private bool amountBeforeTaxFieldSpecified;

        private decimal amountAfterTaxField;

        private bool amountAfterTaxFieldSpecified;

        private decimal markupAmountField;

        private bool markupAmountFieldSpecified;

        private string currencyCodeField;

        private string decimalPlacesField;

        private bool additionalFeesExcludedIndicatorField;

        private bool additionalFeesExcludedIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TaxesType Taxes
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public bool IsDailyPrice
        {
            get
            {
                return this.isDailyPriceField;
            }
            set
            {
                this.isDailyPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public bool IsRateChange
        {
            get
            {
                return this.isRateChangeField;
            }
            set
            {
                this.isRateChangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal AmountBeforeTax
        {
            get
            {
                return this.amountBeforeTaxField;
            }
            set
            {
                this.amountBeforeTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountBeforeTaxSpecified
        {
            get
            {
                return this.amountBeforeTaxFieldSpecified;
            }
            set
            {
                this.amountBeforeTaxFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal AmountAfterTax
        {
            get
            {
                return this.amountAfterTaxField;
            }
            set
            {
                this.amountAfterTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountAfterTaxSpecified
        {
            get
            {
                return this.amountAfterTaxFieldSpecified;
            }
            set
            {
                this.amountAfterTaxFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MarkupAmount
        {
            get
            {
                return this.markupAmountField;
            }
            set
            {
                this.markupAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MarkupAmountSpecified
        {
            get
            {
                return this.markupAmountFieldSpecified;
            }
            set
            {
                this.markupAmountFieldSpecified = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AdditionalFeesExcludedIndicator
        {
            get
            {
                return this.additionalFeesExcludedIndicatorField;
            }
            set
            {
                this.additionalFeesExcludedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdditionalFeesExcludedIndicatorSpecified
        {
            get
            {
                return this.additionalFeesExcludedIndicatorFieldSpecified;
            }
            set
            {
                this.additionalFeesExcludedIndicatorFieldSpecified = value;
            }
        }
    }
}