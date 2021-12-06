namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FareInfo
    {

        private string extraFareField;

        private string serviceFeeField;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExtraFare
        {
            get
            {
                return this.extraFareField;
            }
            set
            {
                this.extraFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ServiceFee
        {
            get
            {
                return this.serviceFeeField;
            }
            set
            {
                this.serviceFeeField = value;
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
    }
}