namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_AirScheduleRSAirItineraryType
    {

        private int airITIndexField;

        private OTA_AirScheduleRSOriginDestinationOptions originDestinationOptionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int AirITIndex
        {
            get
            {
                return this.airITIndexField;
            }
            set
            {
                this.airITIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_AirScheduleRSOriginDestinationOptions OriginDestinationOptions
        {
            get
            {
                return this.originDestinationOptionsField;
            }
            set
            {
                this.originDestinationOptionsField = value;
            }
        }
    }
}