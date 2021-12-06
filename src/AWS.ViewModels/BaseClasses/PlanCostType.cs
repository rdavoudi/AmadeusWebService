namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PlanCostType
    {

        private PlanCostTypeBasePremium basePremiumField;

        private FeeType[] chargesField;

        private string currencyCodeField;

        private decimal amountField;

        private bool amountFieldSpecified;

        private decimal markupAmountField;

        private bool markupAmountFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PlanCostTypeBasePremium BasePremium
        {
            get
            {
                return this.basePremiumField;
            }
            set
            {
                this.basePremiumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Charge", IsNullable = false)]
        public FeeType[] Charges
        {
            get
            {
                return this.chargesField;
            }
            set
            {
                this.chargesField = value;
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
    }
}