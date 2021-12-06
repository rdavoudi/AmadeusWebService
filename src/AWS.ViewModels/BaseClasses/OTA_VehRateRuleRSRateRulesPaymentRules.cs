namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehRateRuleRSRateRulesPaymentRules : PaymentRulesType
    {

        private OTA_VehRateRuleRSRateRulesPaymentRulesAcceptablePayments[] acceptablePaymentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AcceptablePayments", Order = 0)]
        public OTA_VehRateRuleRSRateRulesPaymentRulesAcceptablePayments[] AcceptablePayments
        {
            get
            {
                return this.acceptablePaymentsField;
            }
            set
            {
                this.acceptablePaymentsField = value;
            }
        }
    }
}