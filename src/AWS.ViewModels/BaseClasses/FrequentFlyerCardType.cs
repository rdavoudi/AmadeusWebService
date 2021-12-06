namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FrequentFlyerCardType
    {

        private string airlineCodeField;

        private string cardNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirlineCode
        {
            get
            {
                return this.airlineCodeField;
            }
            set
            {
                this.airlineCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CardNumber
        {
            get
            {
                return this.cardNumberField;
            }
            set
            {
                this.cardNumberField = value;
            }
        }
    }
}