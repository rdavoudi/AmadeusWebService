namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class LCCOtherFee
    {

        private string costTypeField;

        private decimal amountField;

        private string currencyField;

        private bool perPassengerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CostType
        {
            get
            {
                return this.costTypeField;
            }
            set
            {
                this.costTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PerPassenger
        {
            get
            {
                return this.perPassengerField;
            }
            set
            {
                this.perPassengerField = value;
            }
        }
    }
}