namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightCalendarOTA_AirLowFareSearchRQOriginDestinationInformationAlternateLocationInfo
    {

        private string[] originLocationField;

        private string[] destinationLocationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] OriginLocation
        {
            get
            {
                return this.originLocationField;
            }
            set
            {
                this.originLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] DestinationLocation
        {
            get
            {
                return this.destinationLocationField;
            }
            set
            {
                this.destinationLocationField = value;
            }
        }
    }
}