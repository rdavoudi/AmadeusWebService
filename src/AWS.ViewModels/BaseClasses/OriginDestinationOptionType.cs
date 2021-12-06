namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OriginDestinationOptionType
    {

        private OriginDestinationOptionTypeFlightSegment[] flightSegmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FlightSegment", Order = 0)]
        public OriginDestinationOptionTypeFlightSegment[] FlightSegment
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
    }
}