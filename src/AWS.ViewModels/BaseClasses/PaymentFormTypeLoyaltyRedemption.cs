namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PaymentFormTypeLoyaltyRedemption
    {

        private PaymentFormTypeLoyaltyRedemptionLoyaltyCertificate[] loyaltyCertificateField;

        private string certificateNumberField;

        private string memberNumberField;

        private string programNameField;

        private string promotionCodeField;

        private string[] promotionVendorCodeField;

        private string redemptionQuantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyCertificate", Order = 0)]
        public PaymentFormTypeLoyaltyRedemptionLoyaltyCertificate[] LoyaltyCertificate
        {
            get
            {
                return this.loyaltyCertificateField;
            }
            set
            {
                this.loyaltyCertificateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CertificateNumber
        {
            get
            {
                return this.certificateNumberField;
            }
            set
            {
                this.certificateNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MemberNumber
        {
            get
            {
                return this.memberNumberField;
            }
            set
            {
                this.memberNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProgramName
        {
            get
            {
                return this.programNameField;
            }
            set
            {
                this.programNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PromotionCode
        {
            get
            {
                return this.promotionCodeField;
            }
            set
            {
                this.promotionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] PromotionVendorCode
        {
            get
            {
                return this.promotionVendorCodeField;
            }
            set
            {
                this.promotionVendorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string RedemptionQuantity
        {
            get
            {
                return this.redemptionQuantityField;
            }
            set
            {
                this.redemptionQuantityField = value;
            }
        }
    }
}