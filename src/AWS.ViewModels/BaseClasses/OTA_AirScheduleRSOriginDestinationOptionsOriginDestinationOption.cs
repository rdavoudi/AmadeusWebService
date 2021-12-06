namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_AirScheduleRSOriginDestinationOptionsOriginDestinationOption
    {

        private AvailableDate timeTableAvailableDatesField;

        private OTA_AirScheduleRSOriginDestinationOptionsOriginDestinationOptionFlightSegment[] flightSegmentField;

        private FreeTextType[] commentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AvailableDate TimeTableAvailableDates
        {
            get
            {
                return this.timeTableAvailableDatesField;
            }
            set
            {
                this.timeTableAvailableDatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FlightSegment", Order = 1)]
        public OTA_AirScheduleRSOriginDestinationOptionsOriginDestinationOptionFlightSegment[] FlightSegment
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
        [System.Xml.Serialization.XmlElementAttribute("Comment", Order = 2)]
        public FreeTextType[] Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }
    }
}