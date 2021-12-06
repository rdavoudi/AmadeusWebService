namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SpecificFlightInfoType
    {

        private string flightNumberField;

        private CompanyNameType[] airlineField;

        private CompanyNameType[] excludedAirlineField;

        private AllianceCode[] allianceField;

        private AllianceCode[] excludedAllianceField;

        private SpecificFlightInfoTypeBookingClassPref[] bookingClassPrefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute("Airline", Order = 1)]
        public CompanyNameType[] Airline
        {
            get
            {
                return this.airlineField;
            }
            set
            {
                this.airlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExcludedAirline", Order = 2)]
        public CompanyNameType[] ExcludedAirline
        {
            get
            {
                return this.excludedAirlineField;
            }
            set
            {
                this.excludedAirlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Alliance", Order = 3)]
        public AllianceCode[] Alliance
        {
            get
            {
                return this.allianceField;
            }
            set
            {
                this.allianceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExcludedAlliance", Order = 4)]
        public AllianceCode[] ExcludedAlliance
        {
            get
            {
                return this.excludedAllianceField;
            }
            set
            {
                this.excludedAllianceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BookingClassPref", Order = 5)]
        public SpecificFlightInfoTypeBookingClassPref[] BookingClassPref
        {
            get
            {
                return this.bookingClassPrefField;
            }
            set
            {
                this.bookingClassPrefField = value;
            }
        }
    }
}