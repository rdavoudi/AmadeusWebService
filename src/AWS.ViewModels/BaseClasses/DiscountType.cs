namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class DiscountType : TotalType
    {

        private ParagraphType discountReasonField;

        private bool taxInclusiveField;

        private bool taxInclusiveFieldSpecified;

        private decimal percentField;

        private bool percentFieldSpecified;

        private string discountCodeField;

        private bool restrictedDisplayIndicatorField;

        private bool restrictedDisplayIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ParagraphType DiscountReason
        {
            get
            {
                return this.discountReasonField;
            }
            set
            {
                this.discountReasonField = value;
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
        public string DiscountCode
        {
            get
            {
                return this.discountCodeField;
            }
            set
            {
                this.discountCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RestrictedDisplayIndicator
        {
            get
            {
                return this.restrictedDisplayIndicatorField;
            }
            set
            {
                this.restrictedDisplayIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RestrictedDisplayIndicatorSpecified
        {
            get
            {
                return this.restrictedDisplayIndicatorFieldSpecified;
            }
            set
            {
                this.restrictedDisplayIndicatorFieldSpecified = value;
            }
        }
    }
}