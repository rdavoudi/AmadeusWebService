namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_AirSeatMapRSSeatMapResponsesSeatMapResponse
    {

        private OTA_AirSeatMapRSSeatMapResponsesSeatMapResponseFlightSegmentInfo flightSegmentInfoField;

        private SeatMapDetailsType[] seatMapDetailsField;

        private UniqueID_Type[] bookingReferenceIDField;

        private string seatMapJSONResponseField;

        private bool seatUpgradeAppliedField;

        public OTA_AirSeatMapRSSeatMapResponsesSeatMapResponse()
        {
            this.seatUpgradeAppliedField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_AirSeatMapRSSeatMapResponsesSeatMapResponseFlightSegmentInfo FlightSegmentInfo
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
        [System.Xml.Serialization.XmlElementAttribute("SeatMapDetails", Order = 1)]
        public SeatMapDetailsType[] SeatMapDetails
        {
            get
            {
                return this.seatMapDetailsField;
            }
            set
            {
                this.seatMapDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BookingReferenceID", Order = 2)]
        public UniqueID_Type[] BookingReferenceID
        {
            get
            {
                return this.bookingReferenceIDField;
            }
            set
            {
                this.bookingReferenceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatMapJSONResponse
        {
            get
            {
                return this.seatMapJSONResponseField;
            }
            set
            {
                this.seatMapJSONResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SeatUpgradeApplied
        {
            get
            {
                return this.seatUpgradeAppliedField;
            }
            set
            {
                this.seatUpgradeAppliedField = value;
            }
        }
    }
}