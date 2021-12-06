namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_CurrencyConversionRS
    {

        private object[] itemsField;

        private decimal amountField;

        private bool amountFieldSpecified;

        private decimal truncatedAmountField;

        private bool truncatedAmountFieldSpecified;

        private decimal otherChargesAmountField;

        private bool otherChargesAmountFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Errors", typeof(ErrorsType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Success", typeof(SuccessType), Order = 0)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified
        {
            get
            {
                return this.amountFieldSpecified;
            }
            set
            {
                this.amountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TruncatedAmount
        {
            get
            {
                return this.truncatedAmountField;
            }
            set
            {
                this.truncatedAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TruncatedAmountSpecified
        {
            get
            {
                return this.truncatedAmountFieldSpecified;
            }
            set
            {
                this.truncatedAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal OtherChargesAmount
        {
            get
            {
                return this.otherChargesAmountField;
            }
            set
            {
                this.otherChargesAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OtherChargesAmountSpecified
        {
            get
            {
                return this.otherChargesAmountFieldSpecified;
            }
            set
            {
                this.otherChargesAmountFieldSpecified = value;
            }
        }
    }
}