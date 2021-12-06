namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class MiniRulesPriceText
    {

        private string priceMessageValueField;

        private string priceDataListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PriceMessageValue
        {
            get
            {
                return this.priceMessageValueField;
            }
            set
            {
                this.priceMessageValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PriceDataList
        {
            get
            {
                return this.priceDataListField;
            }
            set
            {
                this.priceDataListField = value;
            }
        }
    }
}