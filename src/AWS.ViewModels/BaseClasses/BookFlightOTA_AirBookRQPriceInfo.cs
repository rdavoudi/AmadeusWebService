namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightOTA_AirBookRQPriceInfo : BookingPriceInfoType
    {

        private BookFlightOTA_AirBookRQPriceInfoPricingPref[] pricingPrefField;

        private string participationLevelField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PricingPref", Order = 0)]
        public BookFlightOTA_AirBookRQPriceInfoPricingPref[] PricingPref
        {
            get
            {
                return this.pricingPrefField;
            }
            set
            {
                this.pricingPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParticipationLevel
        {
            get
            {
                return this.participationLevelField;
            }
            set
            {
                this.participationLevelField = value;
            }
        }
    }
}