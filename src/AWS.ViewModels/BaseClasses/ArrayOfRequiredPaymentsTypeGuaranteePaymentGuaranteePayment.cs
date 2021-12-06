namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePayment
    {

        private PaymentFormType[] acceptedPaymentsField;

        private AmountPercentType amountPercentField;

        private ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePaymentDeadline[] deadlineField;

        private ParagraphType[] descriptionField;

        private ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePaymentAddress[] addressField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePaymentRetributionType retributionTypeField;

        private bool retributionTypeFieldSpecified;

        private string paymentCodeField;

        private ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePaymentType typeField;

        private bool typeFieldSpecified;

        private string guaranteeCodeField;

        private ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePaymentGuaranteeType guaranteeTypeField;

        private bool guaranteeTypeFieldSpecified;

        private System.DateTime holdTimeField;

        private bool holdTimeFieldSpecified;

        private bool monField;

        private bool monFieldSpecified;

        private bool tueField;

        private bool tueFieldSpecified;

        private bool wedsField;

        private bool wedsFieldSpecified;

        private bool thurField;

        private bool thurFieldSpecified;

        private bool friField;

        private bool friFieldSpecified;

        private bool satField;

        private bool satFieldSpecified;

        private bool sunField;

        private bool sunFieldSpecified;

        private string startField;

        private string durationField;

        private string endField;

        private bool noCardHolderInfoReqIndField;

        private bool noCardHolderInfoReqIndFieldSpecified;

        private bool nameIndField;

        private bool nameIndFieldSpecified;

        private bool addressIndField;

        private bool addressIndFieldSpecified;

        private bool phoneIndField;

        private bool phoneIndFieldSpecified;

        private bool interbankNbrIndField;

        private bool interbankNbrIndFieldSpecified;

        private string roomTypeCodeField;

        private string infoSourceField;

        private bool nonRefundableIndicatorField;

        private bool nonRefundableIndicatorFieldSpecified;

        private string policyCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AcceptedPayment", IsNullable = false)]
        public PaymentFormType[] AcceptedPayments
        {
            get
            {
                return this.acceptedPaymentsField;
            }
            set
            {
                this.acceptedPaymentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AmountPercentType AmountPercent
        {
            get
            {
                return this.amountPercentField;
            }
            set
            {
                this.amountPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Deadline", Order = 2)]
        public ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePaymentDeadline[] Deadline
        {
            get
            {
                return this.deadlineField;
            }
            set
            {
                this.deadlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Order = 3)]
        public ParagraphType[] Description
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
        [System.Xml.Serialization.XmlElementAttribute("Address", Order = 4)]
        public ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePaymentAddress[] Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePaymentRetributionType RetributionType
        {
            get
            {
                return this.retributionTypeField;
            }
            set
            {
                this.retributionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RetributionTypeSpecified
        {
            get
            {
                return this.retributionTypeFieldSpecified;
            }
            set
            {
                this.retributionTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentCode
        {
            get
            {
                return this.paymentCodeField;
            }
            set
            {
                this.paymentCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePaymentType Type
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
        public string GuaranteeCode
        {
            get
            {
                return this.guaranteeCodeField;
            }
            set
            {
                this.guaranteeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePaymentGuaranteeType GuaranteeType
        {
            get
            {
                return this.guaranteeTypeField;
            }
            set
            {
                this.guaranteeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GuaranteeTypeSpecified
        {
            get
            {
                return this.guaranteeTypeFieldSpecified;
            }
            set
            {
                this.guaranteeTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime HoldTime
        {
            get
            {
                return this.holdTimeField;
            }
            set
            {
                this.holdTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HoldTimeSpecified
        {
            get
            {
                return this.holdTimeFieldSpecified;
            }
            set
            {
                this.holdTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Mon
        {
            get
            {
                return this.monField;
            }
            set
            {
                this.monField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MonSpecified
        {
            get
            {
                return this.monFieldSpecified;
            }
            set
            {
                this.monFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Tue
        {
            get
            {
                return this.tueField;
            }
            set
            {
                this.tueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TueSpecified
        {
            get
            {
                return this.tueFieldSpecified;
            }
            set
            {
                this.tueFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Weds
        {
            get
            {
                return this.wedsField;
            }
            set
            {
                this.wedsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WedsSpecified
        {
            get
            {
                return this.wedsFieldSpecified;
            }
            set
            {
                this.wedsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Thur
        {
            get
            {
                return this.thurField;
            }
            set
            {
                this.thurField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThurSpecified
        {
            get
            {
                return this.thurFieldSpecified;
            }
            set
            {
                this.thurFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Fri
        {
            get
            {
                return this.friField;
            }
            set
            {
                this.friField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FriSpecified
        {
            get
            {
                return this.friFieldSpecified;
            }
            set
            {
                this.friFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Sat
        {
            get
            {
                return this.satField;
            }
            set
            {
                this.satField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SatSpecified
        {
            get
            {
                return this.satFieldSpecified;
            }
            set
            {
                this.satFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Sun
        {
            get
            {
                return this.sunField;
            }
            set
            {
                this.sunField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SunSpecified
        {
            get
            {
                return this.sunFieldSpecified;
            }
            set
            {
                this.sunFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
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
        public bool NameInd
        {
            get
            {
                return this.nameIndField;
            }
            set
            {
                this.nameIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NameIndSpecified
        {
            get
            {
                return this.nameIndFieldSpecified;
            }
            set
            {
                this.nameIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AddressInd
        {
            get
            {
                return this.addressIndField;
            }
            set
            {
                this.addressIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddressIndSpecified
        {
            get
            {
                return this.addressIndFieldSpecified;
            }
            set
            {
                this.addressIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PhoneInd
        {
            get
            {
                return this.phoneIndField;
            }
            set
            {
                this.phoneIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PhoneIndSpecified
        {
            get
            {
                return this.phoneIndFieldSpecified;
            }
            set
            {
                this.phoneIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool InterbankNbrInd
        {
            get
            {
                return this.interbankNbrIndField;
            }
            set
            {
                this.interbankNbrIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterbankNbrIndSpecified
        {
            get
            {
                return this.interbankNbrIndFieldSpecified;
            }
            set
            {
                this.interbankNbrIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomTypeCode
        {
            get
            {
                return this.roomTypeCodeField;
            }
            set
            {
                this.roomTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InfoSource
        {
            get
            {
                return this.infoSourceField;
            }
            set
            {
                this.infoSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonRefundableIndicator
        {
            get
            {
                return this.nonRefundableIndicatorField;
            }
            set
            {
                this.nonRefundableIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NonRefundableIndicatorSpecified
        {
            get
            {
                return this.nonRefundableIndicatorFieldSpecified;
            }
            set
            {
                this.nonRefundableIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PolicyCode
        {
            get
            {
                return this.policyCodeField;
            }
            set
            {
                this.policyCodeField = value;
            }
        }
    }
}