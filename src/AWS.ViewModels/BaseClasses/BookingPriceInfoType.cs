namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookingPriceInfoType : AirItineraryPricingInfoType
    {

        private PriceRequestInformationType priceRequestInformationField;

        private bool repriceRequiredField;

        public BookingPriceInfoType()
        {
            this.repriceRequiredField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PriceRequestInformationType PriceRequestInformation
        {
            get
            {
                return this.priceRequestInformationField;
            }
            set
            {
                this.priceRequestInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool RepriceRequired
        {
            get
            {
                return this.repriceRequiredField;
            }
            set
            {
                this.repriceRequiredField = value;
            }
        }
    }
}