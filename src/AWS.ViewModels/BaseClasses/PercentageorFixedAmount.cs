namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PercentageorFixedAmount
    {

        private Percentage percentageField;

        private Price fixedAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public Percentage Percentage
        {
            get
            {
                return this.percentageField;
            }
            set
            {
                this.percentageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public Price FixedAmount
        {
            get
            {
                return this.fixedAmountField;
            }
            set
            {
                this.fixedAmountField = value;
            }
        }
    }
}