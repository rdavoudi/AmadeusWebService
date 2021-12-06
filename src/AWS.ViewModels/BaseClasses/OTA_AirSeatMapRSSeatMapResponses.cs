namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_AirSeatMapRSSeatMapResponses
    {

        private OTA_AirSeatMapRSSeatMapResponsesSeatMapResponse[] seatMapResponseField;

        private OTA_AirSeatMapRSSeatMapResponsesAirTraveler[] airTravelersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SeatMapResponse", Order = 0)]
        public OTA_AirSeatMapRSSeatMapResponsesSeatMapResponse[] SeatMapResponse
        {
            get
            {
                return this.seatMapResponseField;
            }
            set
            {
                this.seatMapResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AirTraveler", IsNullable = false)]
        public OTA_AirSeatMapRSSeatMapResponsesAirTraveler[] AirTravelers
        {
            get
            {
                return this.airTravelersField;
            }
            set
            {
                this.airTravelersField = value;
            }
        }
    }
}