namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_VehAvailRateRQVehAvailRQCore))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleAvailRQCoreType
    {

        private VehicleRentalCoreType vehRentalCoreField;

        private VehicleAvailRQCoreTypeVendorPrefs vendorPrefsField;

        private VehicleAvailRQCoreTypeVehPref[] vehPrefsField;

        private VehicleAvailRQCoreTypeDriverType[] driverTypeField;

        private VehicleAvailRQCoreTypeRateQualifier[] rateQualifierField;

        private VehicleAvailRQCoreTypeRateRange rateRangeField;

        private VehicleAvailRQCoreTypeSpecialEquipPref[] specialEquipPrefsField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private bool unlimitedField;

        private InventoryStatusType statusField;

        private bool statusFieldSpecified;

        private string targetSourceField;

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
        public VehicleAvailRQCoreTypeVendorPrefs VendorPrefs
        {
            get
            {
                return this.vendorPrefsField;
            }
            set
            {
                this.vendorPrefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("VehPref", IsNullable = false)]
        public VehicleAvailRQCoreTypeVehPref[] VehPrefs
        {
            get
            {
                return this.vehPrefsField;
            }
            set
            {
                this.vehPrefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DriverType", Order = 3)]
        public VehicleAvailRQCoreTypeDriverType[] DriverType
        {
            get
            {
                return this.driverTypeField;
            }
            set
            {
                this.driverTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RateQualifier", Order = 4)]
        public VehicleAvailRQCoreTypeRateQualifier[] RateQualifier
        {
            get
            {
                return this.rateQualifierField;
            }
            set
            {
                this.rateQualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public VehicleAvailRQCoreTypeRateRange RateRange
        {
            get
            {
                return this.rateRangeField;
            }
            set
            {
                this.rateRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 6)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SpecialEquipPref", IsNullable = false)]
        public VehicleAvailRQCoreTypeSpecialEquipPref[] SpecialEquipPrefs
        {
            get
            {
                return this.specialEquipPrefsField;
            }
            set
            {
                this.specialEquipPrefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Unlimited
        {
            get
            {
                return this.unlimitedField;
            }
            set
            {
                this.unlimitedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InventoryStatusType Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetSource
        {
            get
            {
                return this.targetSourceField;
            }
            set
            {
                this.targetSourceField = value;
            }
        }
    }
}