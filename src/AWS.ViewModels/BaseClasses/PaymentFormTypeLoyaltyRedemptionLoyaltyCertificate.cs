namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PaymentFormTypeLoyaltyRedemptionLoyaltyCertificate
    {

        private string iD_ContextField;

        private string nmbrOfNightsField;

        private PaymentFormTypeLoyaltyRedemptionLoyaltyCertificateFormat formatField;

        private bool formatFieldSpecified;

        private string statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID_Context
        {
            get
            {
                return this.iD_ContextField;
            }
            set
            {
                this.iD_ContextField = value;
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
        public PaymentFormTypeLoyaltyRedemptionLoyaltyCertificateFormat Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FormatSpecified
        {
            get
            {
                return this.formatFieldSpecified;
            }
            set
            {
                this.formatFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }
}