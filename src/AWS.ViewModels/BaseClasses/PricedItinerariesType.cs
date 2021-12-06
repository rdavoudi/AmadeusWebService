namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PricedItinerariesType
    {

        private PricedItinerariesTypePricedItinerary[] pricedItineraryField;

        private PricedItinerariesTypePricedItineraryForOWC[] pricedItineraryForOWCField;

        private string myPropertyField;

        private ArrayOfFreeBaggageLegendItemBaggage[] freeBaggagesField;

        private ArrayOfConnectedOperatingAirlineConnectedOperatingAirline[] connectedOperatingAirlinesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PricedItinerary", Order = 0)]
        public PricedItinerariesTypePricedItinerary[] PricedItinerary
        {
            get
            {
                return this.pricedItineraryField;
            }
            set
            {
                this.pricedItineraryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PricedItineraryForOWC", Order = 1)]
        public PricedItinerariesTypePricedItineraryForOWC[] PricedItineraryForOWC
        {
            get
            {
                return this.pricedItineraryForOWCField;
            }
            set
            {
                this.pricedItineraryForOWCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string MyProperty
        {
            get
            {
                return this.myPropertyField;
            }
            set
            {
                this.myPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Baggage", IsNullable = false)]
        public ArrayOfFreeBaggageLegendItemBaggage[] FreeBaggages
        {
            get
            {
                return this.freeBaggagesField;
            }
            set
            {
                this.freeBaggagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ConnectedOperatingAirline")]
        public ArrayOfConnectedOperatingAirlineConnectedOperatingAirline[] ConnectedOperatingAirlines
        {
            get
            {
                return this.connectedOperatingAirlinesField;
            }
            set
            {
                this.connectedOperatingAirlinesField = value;
            }
        }
    }
}