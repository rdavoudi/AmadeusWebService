namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehRateRuleRQRentalInfo
    {

        private VehicleRentalCoreType vehRentalCoreField;

        private VehiclePrefType vehicleInfoField;

        private OTA_VehRateRuleRQRentalInfoSpecialEquipPref[] specialEquipPrefsField;

        private OTA_VehRateRuleRQRentalInfoCustLoyalty[] custLoyaltyField;

        private OTA_VehRateRuleRQRentalInfoRateQualifier rateQualifierField;

        private OffLocationServiceType offLocServiceField;

        private VehicleArrivalDetailsType arrivalDetailsField;

        private VehicleTourInfoType tourInfoField;

        private UniqueID_Type customerIDField;

        private TPA_ExtensionsType tPA_ExtensionsField;

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
        public VehiclePrefType VehicleInfo
        {
            get
            {
                return this.vehicleInfoField;
            }
            set
            {
                this.vehicleInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SpecialEquipPref", IsNullable = false)]
        public OTA_VehRateRuleRQRentalInfoSpecialEquipPref[] SpecialEquipPrefs
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
        [System.Xml.Serialization.XmlElementAttribute("CustLoyalty", Order = 3)]
        public OTA_VehRateRuleRQRentalInfoCustLoyalty[] CustLoyalty
        {
            get
            {
                return this.custLoyaltyField;
            }
            set
            {
                this.custLoyaltyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public OTA_VehRateRuleRQRentalInfoRateQualifier RateQualifier
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
        public OffLocationServiceType OffLocService
        {
            get
            {
                return this.offLocServiceField;
            }
            set
            {
                this.offLocServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public VehicleArrivalDetailsType ArrivalDetails
        {
            get
            {
                return this.arrivalDetailsField;
            }
            set
            {
                this.arrivalDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public VehicleTourInfoType TourInfo
        {
            get
            {
                return this.tourInfoField;
            }
            set
            {
                this.tourInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public UniqueID_Type CustomerID
        {
            get
            {
                return this.customerIDField;
            }
            set
            {
                this.customerIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
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
    }
}