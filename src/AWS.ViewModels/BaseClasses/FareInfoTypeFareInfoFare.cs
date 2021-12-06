namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FareInfoTypeFareInfoFare
    {

        private decimal baseAmountField;

        private bool baseAmountFieldSpecified;

        private decimal baseNUC_AmountField;

        private bool baseNUC_AmountFieldSpecified;

        private decimal taxAmountField;

        private bool taxAmountFieldSpecified;

        private decimal totalFareField;

        private bool totalFareFieldSpecified;

        private string fareDescriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal BaseAmount
        {
            get
            {
                return this.baseAmountField;
            }
            set
            {
                this.baseAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BaseAmountSpecified
        {
            get
            {
                return this.baseAmountFieldSpecified;
            }
            set
            {
                this.baseAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal BaseNUC_Amount
        {
            get
            {
                return this.baseNUC_AmountField;
            }
            set
            {
                this.baseNUC_AmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BaseNUC_AmountSpecified
        {
            get
            {
                return this.baseNUC_AmountFieldSpecified;
            }
            set
            {
                this.baseNUC_AmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TaxAmount
        {
            get
            {
                return this.taxAmountField;
            }
            set
            {
                this.taxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxAmountSpecified
        {
            get
            {
                return this.taxAmountFieldSpecified;
            }
            set
            {
                this.taxAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalFareSpecified
        {
            get
            {
                return this.totalFareFieldSpecified;
            }
            set
            {
                this.totalFareFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareDescription
        {
            get
            {
                return this.fareDescriptionField;
            }
            set
            {
                this.fareDescriptionField = value;
            }
        }
    }
}