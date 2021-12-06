namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CommissionTypeCommissionableAmount
    {

        private decimal amountField;

        private bool amountFieldSpecified;

        private bool taxInclusiveIndicatorField;

        private bool taxInclusiveIndicatorFieldSpecified;

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
        public bool TaxInclusiveIndicator
        {
            get
            {
                return this.taxInclusiveIndicatorField;
            }
            set
            {
                this.taxInclusiveIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxInclusiveIndicatorSpecified
        {
            get
            {
                return this.taxInclusiveIndicatorFieldSpecified;
            }
            set
            {
                this.taxInclusiveIndicatorFieldSpecified = value;
            }
        }
    }
}