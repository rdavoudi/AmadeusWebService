namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ChangePenalty
    {

        private System.Nullable<bool> isChangeableField;

        private TimeToDeparture timeToDepartureField;

        private PercentageorFixedAmount percentageorFixedAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<bool> isChangeable
        {
            get
            {
                return this.isChangeableField;
            }
            set
            {
                this.isChangeableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public TimeToDeparture TimeToDeparture
        {
            get
            {
                return this.timeToDepartureField;
            }
            set
            {
                this.timeToDepartureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public PercentageorFixedAmount PercentageorFixedAmount
        {
            get
            {
                return this.percentageorFixedAmountField;
            }
            set
            {
                this.percentageorFixedAmountField = value;
            }
        }
    }
}