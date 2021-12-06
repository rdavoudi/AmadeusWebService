namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FareRuleResponseInfoType
    {

        private FareRuleResponseInfoTypeFareRuleInfo[] fareRuleInfoField;

        private FormattedTextType[] fareRulesField;

        private FareRuleResponseInfoTypeRouting[] routingField;

        private FareRuleResponseInfoTypeAdvisoryInfo[] advisoryInfoField;

        private int itineraryIndexField;

        private bool itineraryIndexFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FareRuleInfo", Order = 0)]
        public FareRuleResponseInfoTypeFareRuleInfo[] FareRuleInfo
        {
            get
            {
                return this.fareRuleInfoField;
            }
            set
            {
                this.fareRuleInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FareRules", Order = 1)]
        public FormattedTextType[] FareRules
        {
            get
            {
                return this.fareRulesField;
            }
            set
            {
                this.fareRulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Routing", Order = 2)]
        public FareRuleResponseInfoTypeRouting[] Routing
        {
            get
            {
                return this.routingField;
            }
            set
            {
                this.routingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdvisoryInfo", Order = 3)]
        public FareRuleResponseInfoTypeAdvisoryInfo[] AdvisoryInfo
        {
            get
            {
                return this.advisoryInfoField;
            }
            set
            {
                this.advisoryInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ItineraryIndex
        {
            get
            {
                return this.itineraryIndexField;
            }
            set
            {
                this.itineraryIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItineraryIndexSpecified
        {
            get
            {
                return this.itineraryIndexFieldSpecified;
            }
            set
            {
                this.itineraryIndexFieldSpecified = value;
            }
        }
    }
}