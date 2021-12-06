namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FailbackRS
    {

        private AirItineraryPricingInfoType newPriceField;

        private FreeBaggageAllowancesTypes freeBaggageAllowanceField;

        private FailbackRSFlightSegment[] flightSegmentField;

        private FailbackIndicator[] failbackIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AirItineraryPricingInfoType NewPrice
        {
            get
            {
                return this.newPriceField;
            }
            set
            {
                this.newPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public FreeBaggageAllowancesTypes FreeBaggageAllowance
        {
            get
            {
                return this.freeBaggageAllowanceField;
            }
            set
            {
                this.freeBaggageAllowanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FlightSegment", Order = 2)]
        public FailbackRSFlightSegment[] FlightSegment
        {
            get
            {
                return this.flightSegmentField;
            }
            set
            {
                this.flightSegmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FailbackIndicator", Order = 3)]
        public FailbackIndicator[] FailbackIndicator
        {
            get
            {
                return this.failbackIndicatorField;
            }
            set
            {
                this.failbackIndicatorField = value;
            }
        }
    }
}