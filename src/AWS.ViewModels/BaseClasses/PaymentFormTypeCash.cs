namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PaymentFormTypeCash
    {

        private bool cashIndicatorField;

        public PaymentFormTypeCash()
        {
            this.cashIndicatorField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool CashIndicator
        {
            get
            {
                return this.cashIndicatorField;
            }
            set
            {
                this.cashIndicatorField = value;
            }
        }
    }
}