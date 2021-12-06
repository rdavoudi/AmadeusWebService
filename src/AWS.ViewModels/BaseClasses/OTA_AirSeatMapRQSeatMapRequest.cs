namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_AirSeatMapRQSeatMapRequest
    {

        private FlightSegmentType flightSegmentInfoField;

        private OTA_AirSeatMapRQSeatMapRequestSeatDetails seatDetailsField;

        private string[] travelerRefNumberRPHsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public FlightSegmentType FlightSegmentInfo
        {
            get
            {
                return this.flightSegmentInfoField;
            }
            set
            {
                this.flightSegmentInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_AirSeatMapRQSeatMapRequestSeatDetails SeatDetails
        {
            get
            {
                return this.seatDetailsField;
            }
            set
            {
                this.seatDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] TravelerRefNumberRPHs
        {
            get
            {
                return this.travelerRefNumberRPHsField;
            }
            set
            {
                this.travelerRefNumberRPHsField = value;
            }
        }
    }
}