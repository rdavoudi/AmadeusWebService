namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehRateRuleRSRateRulesPaymentRulesAcceptablePayments
    {

        private OTA_VehRateRuleRSRateRulesPaymentRulesAcceptablePaymentsAcceptablePayment[] acceptablePaymentField;

        private string paymentTypeCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AcceptablePayment", Order = 0)]
        public OTA_VehRateRuleRSRateRulesPaymentRulesAcceptablePaymentsAcceptablePayment[] AcceptablePayment
        {
            get
            {
                return this.acceptablePaymentField;
            }
            set
            {
                this.acceptablePaymentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentTypeCode
        {
            get
            {
                return this.paymentTypeCodeField;
            }
            set
            {
                this.paymentTypeCodeField = value;
            }
        }
    }
}