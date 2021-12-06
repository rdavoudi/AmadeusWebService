namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AncillaryInfoRQ))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BaggageInfoRQ : ServiceFeeInfoRQ
    {

        private PassengerInfo[] passengerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Passenger", Order = 0)]
        public PassengerInfo[] Passenger
        {
            get
            {
                return this.passengerField;
            }
            set
            {
                this.passengerField = value;
            }
        }
    }
}