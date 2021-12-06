namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookBookBasketRQCarReservation
    {

        private int vendorIDField;

        private int vehicleIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int VendorID
        {
            get
            {
                return this.vendorIDField;
            }
            set
            {
                this.vendorIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int VehicleID
        {
            get
            {
                return this.vehicleIDField;
            }
            set
            {
                this.vehicleIDField = value;
            }
        }
    }
}