namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleAvailAdditionalInfoType
    {

        private CoveragePricedType[] pricedCoveragesField;

        private MonetaryRuleType[] paymentRulesField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private string chargeablePeriodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PricedCoverage", IsNullable = false)]
        public CoveragePricedType[] PricedCoverages
        {
            get
            {
                return this.pricedCoveragesField;
            }
            set
            {
                this.pricedCoveragesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PaymentRule", IsNullable = false)]
        public MonetaryRuleType[] PaymentRules
        {
            get
            {
                return this.paymentRulesField;
            }
            set
            {
                this.paymentRulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public string ChargeablePeriod
        {
            get
            {
                return this.chargeablePeriodField;
            }
            set
            {
                this.chargeablePeriodField = value;
            }
        }
    }
}