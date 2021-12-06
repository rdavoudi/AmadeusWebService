namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfBookingRulesTypeBookingRuleBookingRuleRestrictionStatus
    {

        private ArrayOfBookingRulesTypeBookingRuleBookingRuleRestrictionStatusRestriction restrictionField;

        private bool restrictionFieldSpecified;

        private AvailabilityStatusType statusField;

        private bool statusFieldSpecified;

        private bool sellThroughOpenIndicatorField;

        private bool sellThroughOpenIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ArrayOfBookingRulesTypeBookingRuleBookingRuleRestrictionStatusRestriction Restriction
        {
            get
            {
                return this.restrictionField;
            }
            set
            {
                this.restrictionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RestrictionSpecified
        {
            get
            {
                return this.restrictionFieldSpecified;
            }
            set
            {
                this.restrictionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AvailabilityStatusType Status
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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SellThroughOpenIndicator
        {
            get
            {
                return this.sellThroughOpenIndicatorField;
            }
            set
            {
                this.sellThroughOpenIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SellThroughOpenIndicatorSpecified
        {
            get
            {
                return this.sellThroughOpenIndicatorFieldSpecified;
            }
            set
            {
                this.sellThroughOpenIndicatorFieldSpecified = value;
            }
        }
    }
}