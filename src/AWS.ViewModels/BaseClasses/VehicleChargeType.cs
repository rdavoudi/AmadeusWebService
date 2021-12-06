namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleChargePurposeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleChargeType
    {

        private VehicleChargeTypeTaxAmount[] taxAmountsField;

        private VehicleChargeTypeMinMax minMaxField;

        private VehicleChargeTypeCalculation[] calculationField;

        private string currencyCodeField;

        private string fareTypeField;

        private string fareCategoryField;

        private decimal amountField;

        private bool amountFieldSpecified;

        private decimal markupAmountField;

        private bool markupAmountFieldSpecified;

        private bool taxInclusiveField;

        private bool taxInclusiveFieldSpecified;

        private string descriptionField;

        private bool guaranteedIndField;

        private bool guaranteedIndFieldSpecified;

        private bool includedInRateField;

        private bool includedInEstTotalIndField;

        private bool includedInEstTotalIndFieldSpecified;

        public VehicleChargeType()
        {
            this.includedInRateField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("TaxAmount", IsNullable = false)]
        public VehicleChargeTypeTaxAmount[] TaxAmounts
        {
            get
            {
                return this.taxAmountsField;
            }
            set
            {
                this.taxAmountsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public VehicleChargeTypeMinMax MinMax
        {
            get
            {
                return this.minMaxField;
            }
            set
            {
                this.minMaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Calculation", Order = 2)]
        public VehicleChargeTypeCalculation[] Calculation
        {
            get
            {
                return this.calculationField;
            }
            set
            {
                this.calculationField = value;
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
        public string FareType
        {
            get
            {
                return this.fareTypeField;
            }
            set
            {
                this.fareTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareCategory
        {
            get
            {
                return this.fareCategoryField;
            }
            set
            {
                this.fareCategoryField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TaxInclusive
        {
            get
            {
                return this.taxInclusiveField;
            }
            set
            {
                this.taxInclusiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxInclusiveSpecified
        {
            get
            {
                return this.taxInclusiveFieldSpecified;
            }
            set
            {
                this.taxInclusiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuaranteedInd
        {
            get
            {
                return this.guaranteedIndField;
            }
            set
            {
                this.guaranteedIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GuaranteedIndSpecified
        {
            get
            {
                return this.guaranteedIndFieldSpecified;
            }
            set
            {
                this.guaranteedIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IncludedInRate
        {
            get
            {
                return this.includedInRateField;
            }
            set
            {
                this.includedInRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IncludedInEstTotalInd
        {
            get
            {
                return this.includedInEstTotalIndField;
            }
            set
            {
                this.includedInEstTotalIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludedInEstTotalIndSpecified
        {
            get
            {
                return this.includedInEstTotalIndFieldSpecified;
            }
            set
            {
                this.includedInEstTotalIndFieldSpecified = value;
            }
        }
    }
}