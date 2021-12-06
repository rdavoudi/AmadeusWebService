namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleVendorAvailabilityTypeVehAvailsVehAvail
    {

        private VehicleAvailCoreType vehAvailCoreField;

        private VehicleAvailAdditionalInfoType vehAvailInfoField;

        private VehicleVendorAvailabilityTypeVehAvailsVehAvailAdvanceBooking advanceBookingField;

        private string vehicleIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public VehicleAvailCoreType VehAvailCore
        {
            get
            {
                return this.vehAvailCoreField;
            }
            set
            {
                this.vehAvailCoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public VehicleAvailAdditionalInfoType VehAvailInfo
        {
            get
            {
                return this.vehAvailInfoField;
            }
            set
            {
                this.vehAvailInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public VehicleVendorAvailabilityTypeVehAvailsVehAvailAdvanceBooking AdvanceBooking
        {
            get
            {
                return this.advanceBookingField;
            }
            set
            {
                this.advanceBookingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string VehicleId
        {
            get
            {
                return this.vehicleIdField;
            }
            set
            {
                this.vehicleIdField = value;
            }
        }
    }
}