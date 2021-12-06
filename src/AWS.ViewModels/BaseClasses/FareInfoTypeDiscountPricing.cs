namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FareInfoTypeDiscountPricing
    {

        private FareInfoTypeDiscountPricingPurpose purposeField;

        private bool purposeFieldSpecified;

        private string ticketDesignatorCodeField;

        private string discountField;

        private FareInfoTypeDiscountPricingType typeField;

        private bool typeFieldSpecified;

        private FareInfoTypeDiscountPricingUsage usageField;

        private bool usageFieldSpecified;

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FareInfoTypeDiscountPricingPurpose Purpose
        {
            get
            {
                return this.purposeField;
            }
            set
            {
                this.purposeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PurposeSpecified
        {
            get
            {
                return this.purposeFieldSpecified;
            }
            set
            {
                this.purposeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDesignatorCode
        {
            get
            {
                return this.ticketDesignatorCodeField;
            }
            set
            {
                this.ticketDesignatorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Discount
        {
            get
            {
                return this.discountField;
            }
            set
            {
                this.discountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FareInfoTypeDiscountPricingType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FareInfoTypeDiscountPricingUsage Usage
        {
            get
            {
                return this.usageField;
            }
            set
            {
                this.usageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UsageSpecified
        {
            get
            {
                return this.usageFieldSpecified;
            }
            set
            {
                this.usageFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
}