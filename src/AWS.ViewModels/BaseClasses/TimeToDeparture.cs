namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class TimeToDeparture
    {

        private int timeAmountField;

        private string timeUnitField;

        private string timePeriodConditionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int TimeAmount
        {
            get
            {
                return this.timeAmountField;
            }
            set
            {
                this.timeAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public string TimeUnit
        {
            get
            {
                return this.timeUnitField;
            }
            set
            {
                this.timeUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public string TimePeriodCondition
        {
            get
            {
                return this.timePeriodConditionField;
            }
            set
            {
                this.timePeriodConditionField = value;
            }
        }
    }
}