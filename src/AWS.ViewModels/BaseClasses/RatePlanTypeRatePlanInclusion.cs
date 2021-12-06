namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RatePlanTypeRatePlanInclusion
    {

        private ParagraphType ratePlanInclusionDesciptionField;

        private decimal amountField;

        private bool amountFieldSpecified;

        private string categoryTypeField;

        private string codeField;

        private string currencyField;

        private bool isDailyField;

        private bool isPackageField;

        private bool isPerPeriodField;

        private bool isPerPersonField;

        private bool isPerRoomField;

        private bool isTaxIncludedField;

        private decimal percentageField;

        private bool percentageFieldSpecified;

        private bool taxInclusiveField;

        private bool taxInclusiveFieldSpecified;

        private bool serviceFeeInclusiveField;

        private bool serviceFeeInclusiveFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ParagraphType RatePlanInclusionDesciption
        {
            get
            {
                return this.ratePlanInclusionDesciptionField;
            }
            set
            {
                this.ratePlanInclusionDesciptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string CategoryType
        {
            get
            {
                return this.categoryTypeField;
            }
            set
            {
                this.categoryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public bool IsDaily
        {
            get
            {
                return this.isDailyField;
            }
            set
            {
                this.isDailyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public bool IsPackage
        {
            get
            {
                return this.isPackageField;
            }
            set
            {
                this.isPackageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public bool IsPerPeriod
        {
            get
            {
                return this.isPerPeriodField;
            }
            set
            {
                this.isPerPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public bool IsPerPerson
        {
            get
            {
                return this.isPerPersonField;
            }
            set
            {
                this.isPerPersonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public bool IsPerRoom
        {
            get
            {
                return this.isPerRoomField;
            }
            set
            {
                this.isPerRoomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public bool IsTaxIncluded
        {
            get
            {
                return this.isTaxIncludedField;
            }
            set
            {
                this.isTaxIncludedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public decimal Percentage
        {
            get
            {
                return this.percentageField;
            }
            set
            {
                this.percentageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentageSpecified
        {
            get
            {
                return this.percentageFieldSpecified;
            }
            set
            {
                this.percentageFieldSpecified = value;
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
        public bool ServiceFeeInclusive
        {
            get
            {
                return this.serviceFeeInclusiveField;
            }
            set
            {
                this.serviceFeeInclusiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServiceFeeInclusiveSpecified
        {
            get
            {
                return this.serviceFeeInclusiveFieldSpecified;
            }
            set
            {
                this.serviceFeeInclusiveFieldSpecified = value;
            }
        }
    }
}