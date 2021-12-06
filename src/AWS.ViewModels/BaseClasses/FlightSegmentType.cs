namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_AirScheduleRSOriginDestinationOptionsOriginDestinationOptionFlightSegment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_AirSeatMapRSSeatMapResponsesSeatMapResponseFlightSegmentInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BookFlightSegmentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FlightSegmentType : FlightSegmentBaseType
    {

        private FlightSegmentTypeMarketingAirline marketingAirlineField;

        private ArrayOfFreeBaggageSegmentItemBaggage[] baggagesField;

        private string flightNumberField;

        private string tourOperatorFlightIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public FlightSegmentTypeMarketingAirline MarketingAirline
        {
            get
            {
                return this.marketingAirlineField;
            }
            set
            {
                this.marketingAirlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Baggage", IsNullable = false)]
        public ArrayOfFreeBaggageSegmentItemBaggage[] Baggages
        {
            get
            {
                return this.baggagesField;
            }
            set
            {
                this.baggagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FlightNumber
        {
            get
            {
                return this.flightNumberField;
            }
            set
            {
                this.flightNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TourOperatorFlightID
        {
            get
            {
                return this.tourOperatorFlightIDField;
            }
            set
            {
                this.tourOperatorFlightIDField = value;
            }
        }
    }
}