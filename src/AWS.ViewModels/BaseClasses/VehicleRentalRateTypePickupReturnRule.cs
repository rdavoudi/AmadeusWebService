namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleRentalRateTypePickupReturnRule
    {

        private DayOfWeekType dayOfWeekField;

        private bool dayOfWeekFieldSpecified;

        private string timeField;

        private VehicleRentalRateTypePickupReturnRuleRuleType ruleTypeField;

        private bool ruleTypeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DayOfWeekType DayOfWeek
        {
            get
            {
                return this.dayOfWeekField;
            }
            set
            {
                this.dayOfWeekField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DayOfWeekSpecified
        {
            get
            {
                return this.dayOfWeekFieldSpecified;
            }
            set
            {
                this.dayOfWeekFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleRentalRateTypePickupReturnRuleRuleType RuleType
        {
            get
            {
                return this.ruleTypeField;
            }
            set
            {
                this.ruleTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RuleTypeSpecified
        {
            get
            {
                return this.ruleTypeFieldSpecified;
            }
            set
            {
                this.ruleTypeFieldSpecified = value;
            }
        }
    }
}