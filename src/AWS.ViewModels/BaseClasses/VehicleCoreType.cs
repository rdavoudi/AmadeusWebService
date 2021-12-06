namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_VehRateRuleRSVehicle))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehiclePrefType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleAvailRQCoreTypeVehPref))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleCoreType
    {

        private VehicleCoreTypeVehType vehTypeField;

        private string vehClassField;

        private bool airConditionIndField;

        private bool airConditionIndFieldSpecified;

        private VehicleTransmissionType transmissionTypeField;

        private bool transmissionTypeFieldSpecified;

        private VehicleCoreTypeFuelType fuelTypeField;

        private bool fuelTypeFieldSpecified;

        private VehicleCoreTypeDriveType driveTypeField;

        private bool driveTypeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public VehicleCoreTypeVehType VehType
        {
            get
            {
                return this.vehTypeField;
            }
            set
            {
                this.vehTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VehClass
        {
            get
            {
                return this.vehClassField;
            }
            set
            {
                this.vehClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AirConditionInd
        {
            get
            {
                return this.airConditionIndField;
            }
            set
            {
                this.airConditionIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AirConditionIndSpecified
        {
            get
            {
                return this.airConditionIndFieldSpecified;
            }
            set
            {
                this.airConditionIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleTransmissionType TransmissionType
        {
            get
            {
                return this.transmissionTypeField;
            }
            set
            {
                this.transmissionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransmissionTypeSpecified
        {
            get
            {
                return this.transmissionTypeFieldSpecified;
            }
            set
            {
                this.transmissionTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleCoreTypeFuelType FuelType
        {
            get
            {
                return this.fuelTypeField;
            }
            set
            {
                this.fuelTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FuelTypeSpecified
        {
            get
            {
                return this.fuelTypeFieldSpecified;
            }
            set
            {
                this.fuelTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleCoreTypeDriveType DriveType
        {
            get
            {
                return this.driveTypeField;
            }
            set
            {
                this.driveTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DriveTypeSpecified
        {
            get
            {
                return this.driveTypeFieldSpecified;
            }
            set
            {
                this.driveTypeFieldSpecified = value;
            }
        }
    }
}