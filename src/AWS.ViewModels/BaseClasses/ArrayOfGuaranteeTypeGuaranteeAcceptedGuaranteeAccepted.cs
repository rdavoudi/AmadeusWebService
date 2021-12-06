namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfGuaranteeTypeGuaranteeAcceptedGuaranteeAccepted : PaymentFormType
    {

        private bool defaultField;

        private bool defaultFieldSpecified;

        private bool noCardHolderInfoReqIndField;

        private bool noCardHolderInfoReqIndFieldSpecified;

        private bool nameReqIndField;

        private bool nameReqIndFieldSpecified;

        private bool addressReqIndField;

        private bool addressReqIndFieldSpecified;

        private bool phoneReqIndField;

        private bool phoneReqIndFieldSpecified;

        private bool interbankNbrReqIndField;

        private bool interbankNbrReqIndFieldSpecified;

        private bool bookingSourceAllowedIndField;

        private bool bookingSourceAllowedIndFieldSpecified;

        private bool corpDiscountNbrAllowedIndField;

        private bool corpDiscountNbrAllowedIndFieldSpecified;

        private string guaranteeTypeCodeField;

        private string guaranteeIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Default
        {
            get
            {
                return this.defaultField;
            }
            set
            {
                this.defaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DefaultSpecified
        {
            get
            {
                return this.defaultFieldSpecified;
            }
            set
            {
                this.defaultFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NoCardHolderInfoReqInd
        {
            get
            {
                return this.noCardHolderInfoReqIndField;
            }
            set
            {
                this.noCardHolderInfoReqIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NoCardHolderInfoReqIndSpecified
        {
            get
            {
                return this.noCardHolderInfoReqIndFieldSpecified;
            }
            set
            {
                this.noCardHolderInfoReqIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NameReqInd
        {
            get
            {
                return this.nameReqIndField;
            }
            set
            {
                this.nameReqIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NameReqIndSpecified
        {
            get
            {
                return this.nameReqIndFieldSpecified;
            }
            set
            {
                this.nameReqIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AddressReqInd
        {
            get
            {
                return this.addressReqIndField;
            }
            set
            {
                this.addressReqIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddressReqIndSpecified
        {
            get
            {
                return this.addressReqIndFieldSpecified;
            }
            set
            {
                this.addressReqIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PhoneReqInd
        {
            get
            {
                return this.phoneReqIndField;
            }
            set
            {
                this.phoneReqIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PhoneReqIndSpecified
        {
            get
            {
                return this.phoneReqIndFieldSpecified;
            }
            set
            {
                this.phoneReqIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool InterbankNbrReqInd
        {
            get
            {
                return this.interbankNbrReqIndField;
            }
            set
            {
                this.interbankNbrReqIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterbankNbrReqIndSpecified
        {
            get
            {
                return this.interbankNbrReqIndFieldSpecified;
            }
            set
            {
                this.interbankNbrReqIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BookingSourceAllowedInd
        {
            get
            {
                return this.bookingSourceAllowedIndField;
            }
            set
            {
                this.bookingSourceAllowedIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BookingSourceAllowedIndSpecified
        {
            get
            {
                return this.bookingSourceAllowedIndFieldSpecified;
            }
            set
            {
                this.bookingSourceAllowedIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CorpDiscountNbrAllowedInd
        {
            get
            {
                return this.corpDiscountNbrAllowedIndField;
            }
            set
            {
                this.corpDiscountNbrAllowedIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CorpDiscountNbrAllowedIndSpecified
        {
            get
            {
                return this.corpDiscountNbrAllowedIndFieldSpecified;
            }
            set
            {
                this.corpDiscountNbrAllowedIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GuaranteeTypeCode
        {
            get
            {
                return this.guaranteeTypeCodeField;
            }
            set
            {
                this.guaranteeTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GuaranteeID
        {
            get
            {
                return this.guaranteeIDField;
            }
            set
            {
                this.guaranteeIDField = value;
            }
        }
    }
}