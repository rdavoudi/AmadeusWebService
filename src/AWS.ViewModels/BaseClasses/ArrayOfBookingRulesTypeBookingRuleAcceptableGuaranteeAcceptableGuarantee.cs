namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfBookingRulesTypeBookingRuleAcceptableGuaranteeAcceptableGuarantee : GuaranteeType
    {

        private ArrayOfBookingRulesTypeBookingRuleAcceptableGuaranteeAcceptableGuaranteeGuaranteePolicyType guaranteePolicyTypeField;

        private bool guaranteePolicyTypeFieldSpecified;

        private string paymentTypeField;

        private string currencyCodeField;

        private string decimalPlacesField;

        private string unacceptablePaymentTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ArrayOfBookingRulesTypeBookingRuleAcceptableGuaranteeAcceptableGuaranteeGuaranteePolicyType GuaranteePolicyType
        {
            get
            {
                return this.guaranteePolicyTypeField;
            }
            set
            {
                this.guaranteePolicyTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GuaranteePolicyTypeSpecified
        {
            get
            {
                return this.guaranteePolicyTypeFieldSpecified;
            }
            set
            {
                this.guaranteePolicyTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentType
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnacceptablePaymentType
        {
            get
            {
                return this.unacceptablePaymentTypeField;
            }
            set
            {
                this.unacceptablePaymentTypeField = value;
            }
        }
    }
}