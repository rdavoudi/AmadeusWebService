namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_VehRateRuleRSRateRulesPaymentRules))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PaymentRulesType
    {

        private MonetaryRuleType[] paymentRuleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentRule", Order = 0)]
        public MonetaryRuleType[] PaymentRule
        {
            get
            {
                return this.paymentRuleField;
            }
            set
            {
                this.paymentRuleField = value;
            }
        }
    }
}