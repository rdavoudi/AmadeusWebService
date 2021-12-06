namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleVendorAvailabilityType
    {

        private VehicleRentalCoreType vehRentalCoreField;

        private CompanyNameType vendorField;

        private VehicleVendorAvailabilityTypeVehAvails vehAvailsField;

        private VehicleAvailVendorInfoType infoField;

        private string vendorIdField;

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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CompanyNameType Vendor
        {
            get
            {
                return this.vendorField;
            }
            set
            {
                this.vendorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public VehicleVendorAvailabilityTypeVehAvails VehAvails
        {
            get
            {
                return this.vehAvailsField;
            }
            set
            {
                this.vehAvailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public VehicleAvailVendorInfoType Info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string VendorId
        {
            get
            {
                return this.vendorIdField;
            }
            set
            {
                this.vendorIdField = value;
            }
        }
    }
}