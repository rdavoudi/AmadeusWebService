namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SeatRequestType
    {

        private LocationType departureAirportField;

        private LocationType arrivalAirportField;

        private string seatNumberField;

        private string seatPriceField;

        private string seatPriceCurrencyField;

        private string seatPreferenceField;

        private string departureDateField;

        private string flightNumberField;

        private string statusField;

        private string itineraryIDField;

        private string segmentIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public LocationType DepartureAirport
        {
            get
            {
                return this.departureAirportField;
            }
            set
            {
                this.departureAirportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public LocationType ArrivalAirport
        {
            get
            {
                return this.arrivalAirportField;
            }
            set
            {
                this.arrivalAirportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatNumber
        {
            get
            {
                return this.seatNumberField;
            }
            set
            {
                this.seatNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatPrice
        {
            get
            {
                return this.seatPriceField;
            }
            set
            {
                this.seatPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatPriceCurrency
        {
            get
            {
                return this.seatPriceCurrencyField;
            }
            set
            {
                this.seatPriceCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatPreference
        {
            get
            {
                return this.seatPreferenceField;
            }
            set
            {
                this.seatPreferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DepartureDate
        {
            get
            {
                return this.departureDateField;
            }
            set
            {
                this.departureDateField = value;
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
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ItineraryID
        {
            get
            {
                return this.itineraryIDField;
            }
            set
            {
                this.itineraryIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SegmentID
        {
            get
            {
                return this.segmentIDField;
            }
            set
            {
                this.segmentIDField = value;
            }
        }
    }
}