namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_VehResRQVehResRQCore))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleReservationRQCoreType
    {

        private UniqueID_Type[] uniqueIDField;

        private VehicleRentalCoreType vehRentalCoreField;

        private CustomerPrimaryAdditionalType customerField;

        private CompanyNamePrefType vendorPrefField;

        private VehiclePrefType vehPrefField;

        private VehicleReservationRQCoreTypeDriverType[] driverTypeField;

        private RateQualifierType rateQualifierField;

        private VehicleChargePurposeType[] feesField;

        private VehicleChargePurposeType[] vehicleChargesField;

        private VehicleReservationRQCoreTypeSpecialEquipPrefs specialEquipPrefsField;

        private VehicleReservationRQCoreTypeRateDistance[] rateDistanceField;

        private VehicleReservationRQCoreTypeTotalCharge totalChargeField;

        private VehicleReservationRQCoreTypeQueue queueField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private string statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UniqueID", Order = 0)]
        public UniqueID_Type[] UniqueID
        {
            get
            {
                return this.uniqueIDField;
            }
            set
            {
                this.uniqueIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CustomerPrimaryAdditionalType Customer
        {
            get
            {
                return this.customerField;
            }
            set
            {
                this.customerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CompanyNamePrefType VendorPref
        {
            get
            {
                return this.vendorPrefField;
            }
            set
            {
                this.vendorPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public VehiclePrefType VehPref
        {
            get
            {
                return this.vehPrefField;
            }
            set
            {
                this.vehPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DriverType", Order = 5)]
        public VehicleReservationRQCoreTypeDriverType[] DriverType
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public RateQualifierType RateQualifier
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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable = false)]
        public VehicleChargePurposeType[] Fees
        {
            get
            {
                return this.feesField;
            }
            set
            {
                this.feesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 8)]
        [System.Xml.Serialization.XmlArrayItemAttribute("VehicleCharge", IsNullable = false)]
        public VehicleChargePurposeType[] VehicleCharges
        {
            get
            {
                return this.vehicleChargesField;
            }
            set
            {
                this.vehicleChargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public VehicleReservationRQCoreTypeSpecialEquipPrefs SpecialEquipPrefs
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
        [System.Xml.Serialization.XmlElementAttribute("RateDistance", Order = 10)]
        public VehicleReservationRQCoreTypeRateDistance[] RateDistance
        {
            get
            {
                return this.rateDistanceField;
            }
            set
            {
                this.rateDistanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public VehicleReservationRQCoreTypeTotalCharge TotalCharge
        {
            get
            {
                return this.totalChargeField;
            }
            set
            {
                this.totalChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public VehicleReservationRQCoreTypeQueue Queue
        {
            get
            {
                return this.queueField;
            }
            set
            {
                this.queueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
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
        public string Status
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
    }
}