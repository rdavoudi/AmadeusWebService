namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AmountTypeAdditionalGuestAmounts
    {

        private AdditionalGuestAmountType[] additionalGuestAmountField;

        private decimal amountBeforeTaxField;

        private bool amountBeforeTaxFieldSpecified;

        private decimal amountAfterTaxField;

        private bool amountAfterTaxFieldSpecified;

        private string currencyCodeField;

        private string decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalGuestAmount", Order = 0)]
        public AdditionalGuestAmountType[] AdditionalGuestAmount
        {
            get
            {
                return this.additionalGuestAmountField;
            }
            set
            {
                this.additionalGuestAmountField = value;
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
    }
}