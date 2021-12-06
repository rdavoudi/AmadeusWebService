namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AmountPercentType
    {

        private TaxesType taxesField;

        private bool taxInclusiveField;

        private bool taxInclusiveFieldSpecified;

        private bool feesInclusiveField;

        private bool feesInclusiveFieldSpecified;

        private string nmbrOfNightsField;

        private AmountPercentTypeBasisType basisTypeField;

        private bool basisTypeFieldSpecified;

        private decimal percentField;

        private bool percentFieldSpecified;

        private decimal amountField;

        private bool amountFieldSpecified;

        private AmountPercentTypeApplyAs applyAsField;

        private bool applyAsFieldSpecified;

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
        public bool FeesInclusive
        {
            get
            {
                return this.feesInclusiveField;
            }
            set
            {
                this.feesInclusiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeesInclusiveSpecified
        {
            get
            {
                return this.feesInclusiveFieldSpecified;
            }
            set
            {
                this.feesInclusiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string NmbrOfNights
        {
            get
            {
                return this.nmbrOfNightsField;
            }
            set
            {
                this.nmbrOfNightsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AmountPercentTypeBasisType BasisType
        {
            get
            {
                return this.basisTypeField;
            }
            set
            {
                this.basisTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BasisTypeSpecified
        {
            get
            {
                return this.basisTypeFieldSpecified;
            }
            set
            {
                this.basisTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentSpecified
        {
            get
            {
                return this.percentFieldSpecified;
            }
            set
            {
                this.percentFieldSpecified = value;
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
        public AmountPercentTypeApplyAs ApplyAs
        {
            get
            {
                return this.applyAsField;
            }
            set
            {
                this.applyAsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplyAsSpecified
        {
            get
            {
                return this.applyAsFieldSpecified;
            }
            set
            {
                this.applyAsFieldSpecified = value;
            }
        }
    }
}