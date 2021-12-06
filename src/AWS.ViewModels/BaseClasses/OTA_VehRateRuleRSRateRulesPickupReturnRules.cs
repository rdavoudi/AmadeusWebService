namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehRateRuleRSRateRulesPickupReturnRules
    {

        private OTA_VehRateRuleRSRateRulesPickupReturnRulesEarliestPickup earliestPickupField;

        private OTA_VehRateRuleRSRateRulesPickupReturnRulesLatestPickup latestPickupField;

        private OTA_VehRateRuleRSRateRulesPickupReturnRulesLatestReturn latestReturnField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_VehRateRuleRSRateRulesPickupReturnRulesEarliestPickup EarliestPickup
        {
            get
            {
                return this.earliestPickupField;
            }
            set
            {
                this.earliestPickupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_VehRateRuleRSRateRulesPickupReturnRulesLatestPickup LatestPickup
        {
            get
            {
                return this.latestPickupField;
            }
            set
            {
                this.latestPickupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public OTA_VehRateRuleRSRateRulesPickupReturnRulesLatestReturn LatestReturn
        {
            get
            {
                return this.latestReturnField;
            }
            set
            {
                this.latestReturnField = value;
            }
        }
    }
}