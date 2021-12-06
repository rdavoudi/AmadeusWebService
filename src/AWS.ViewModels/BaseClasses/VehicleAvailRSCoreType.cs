namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleAvailRSCoreType
    {

        private VehicleRentalCoreType vehRentalCoreField;

        private VehicleVendorAvailabilityType[] vehVendorAvailsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public VehicleRentalCoreType VehRentalCore
        {
            get
            {
                return this.vehRentalCoreField;
            }
            set
            {
                this.vehRentalCoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("VehVendorAvail", IsNullable = false)]
        public VehicleVendorAvailabilityType[] VehVendorAvails
        {
            get
            {
                return this.vehVendorAvailsField;
            }
            set
            {
                this.vehVendorAvailsField = value;
            }
        }
    }
}