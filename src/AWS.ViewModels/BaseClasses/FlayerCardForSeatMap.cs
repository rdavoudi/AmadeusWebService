namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FlayerCardForSeatMap
    {

        private string airlineCodeField;

        private string marketingAirlineCodeField;

        private string numberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string MarketingAirlineCode
        {
            get
            {
                return this.marketingAirlineCodeField;
            }
            set
            {
                this.marketingAirlineCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
    }
}