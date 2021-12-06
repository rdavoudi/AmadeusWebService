namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentDetailType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleReservationRQAdditionalInfoTypeRentalPaymentPref))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PaymentFormType
    {

        private AddressType billingAddressField;

        private object itemField;

        private string tFThreeDSecureResultURLField;

        private string threeDSecureReturnURLField;

        private PaymentTypes paymentTypeField;

        private PaymentFPTypes paymentFPTypeField;

        private string couponCodeField;

        private PaymentFormTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private PaymentFormTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private string costCenterIDField;

        private string rPHField;

        private PaymentFormTypePaymentTransactionTypeCode paymentTransactionTypeCodeField;

        private bool paymentTransactionTypeCodeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AddressType BillingAddress
        {
            get
            {
                return this.billingAddressField;
            }
            set
            {
                this.billingAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BankAcct", typeof(BankAcctType), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("Cash", typeof(PaymentFormTypeCash), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("DirectBill", typeof(DirectBillType), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyRedemption", typeof(PaymentFormTypeLoyaltyRedemption), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("MiscChargeOrder", typeof(PaymentFormTypeMiscChargeOrder), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("PaymentCard", typeof(PaymentCardType), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("Voucher", typeof(PaymentFormTypeVoucher), Order = 1)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string TFThreeDSecureResultURL
        {
            get
            {
                return this.tFThreeDSecureResultURLField;
            }
            set
            {
                this.tFThreeDSecureResultURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string ThreeDSecureReturnURL
        {
            get
            {
                return this.threeDSecureReturnURLField;
            }
            set
            {
                this.threeDSecureReturnURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentTypes PaymentType
        {
            get
            {
                return this.paymentTypeField;
            }
            set
            {
                this.paymentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentFPTypes PaymentFPType
        {
            get
            {
                return this.paymentFPTypeField;
            }
            set
            {
                this.paymentFPTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CouponCode
        {
            get
            {
                return this.couponCodeField;
            }
            set
            {
                this.couponCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentFormTypeShareSynchInd ShareSynchInd
        {
            get
            {
                return this.shareSynchIndField;
            }
            set
            {
                this.shareSynchIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShareSynchIndSpecified
        {
            get
            {
                return this.shareSynchIndFieldSpecified;
            }
            set
            {
                this.shareSynchIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentFormTypeShareMarketInd ShareMarketInd
        {
            get
            {
                return this.shareMarketIndField;
            }
            set
            {
                this.shareMarketIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShareMarketIndSpecified
        {
            get
            {
                return this.shareMarketIndFieldSpecified;
            }
            set
            {
                this.shareMarketIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CostCenterID
        {
            get
            {
                return this.costCenterIDField;
            }
            set
            {
                this.costCenterIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentFormTypePaymentTransactionTypeCode PaymentTransactionTypeCode
        {
            get
            {
                return this.paymentTransactionTypeCodeField;
            }
            set
            {
                this.paymentTransactionTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentTransactionTypeCodeSpecified
        {
            get
            {
                return this.paymentTransactionTypeCodeFieldSpecified;
            }
            set
            {
                this.paymentTransactionTypeCodeFieldSpecified = value;
            }
        }
    }
}