namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_CurrencyConversionRQ
    {

        private string fromCurrencyField;

        private string toCurrencyField;

        private decimal amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FromCurrency
        {
            get
            {
                return this.fromCurrencyField;
            }
            set
            {
                this.fromCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ToCurrency
        {
            get
            {
                return this.toCurrencyField;
            }
            set
            {
                this.toCurrencyField = value;
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
    }
}