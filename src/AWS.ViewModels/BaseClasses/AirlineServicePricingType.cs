namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirlineServicePricingType
    {

        private AirlineServicePricingDetailType totalSeatPriceField;

        private AirlineServicePricingDetailType totalAncillaryPriceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AirlineServicePricingDetailType TotalSeatPrice
        {
            get
            {
                return this.totalSeatPriceField;
            }
            set
            {
                this.totalSeatPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AirlineServicePricingDetailType TotalAncillaryPrice
        {
            get
            {
                return this.totalAncillaryPriceField;
            }
            set
            {
                this.totalAncillaryPriceField = value;
            }
        }
    }
}