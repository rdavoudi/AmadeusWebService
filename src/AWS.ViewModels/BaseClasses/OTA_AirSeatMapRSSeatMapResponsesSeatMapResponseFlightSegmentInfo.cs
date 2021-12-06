namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_AirSeatMapRSSeatMapResponsesSeatMapResponseFlightSegmentInfo : FlightSegmentType
    {

        private WarningType[] warningsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Warning", IsNullable = false)]
        public WarningType[] Warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
            }
        }
    }
}