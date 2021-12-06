namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class TravelerInformationType
    {

        private PassengerTypeQuantityType[] passengerTypeQuantityField;

        private AirTravelerType airTravelerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PassengerTypeQuantity", Order = 0)]
        public PassengerTypeQuantityType[] PassengerTypeQuantity
        {
            get
            {
                return this.passengerTypeQuantityField;
            }
            set
            {
                this.passengerTypeQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AirTravelerType AirTraveler
        {
            get
            {
                return this.airTravelerField;
            }
            set
            {
                this.airTravelerField = value;
            }
        }
    }
}