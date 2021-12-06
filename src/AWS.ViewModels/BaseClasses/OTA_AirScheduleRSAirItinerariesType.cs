namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_AirScheduleRSAirItinerariesType
    {

        private OTA_AirScheduleRSAirItineraryType[] airItineraryField;

        private string myPropertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AirItinerary", Order = 0)]
        public OTA_AirScheduleRSAirItineraryType[] AirItinerary
        {
            get
            {
                return this.airItineraryField;
            }
            set
            {
                this.airItineraryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
    }
}