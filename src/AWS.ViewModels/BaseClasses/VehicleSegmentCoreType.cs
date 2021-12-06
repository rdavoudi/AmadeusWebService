namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleReservationTypeVehSegmentCore))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleSegmentCoreType
    {

        private UniqueID_Type[] confIDField;

        private CompanyNameType vendorField;

        private VehicleRentalCoreType vehRentalCoreField;

        private VehicleType vehicleField;

        private VehicleRentalRateType rentalRateField;

        private VehicleEquipmentPricedType[] pricedEquipsField;

        private VehicleChargePurposeType[] feesField;

        private VehicleSegmentCoreTypeTotalCharge totalChargeField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private string indexNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConfID", Order = 0)]
        public UniqueID_Type[] ConfID
        {
            get
            {
                return this.confIDField;
            }
            set
            {
                this.confIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public VehicleType Vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public VehicleRentalRateType RentalRate
        {
            get
            {
                return this.rentalRateField;
            }
            set
            {
                this.rentalRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PricedEquip", IsNullable = false)]
        public VehicleEquipmentPricedType[] PricedEquips
        {
            get
            {
                return this.pricedEquipsField;
            }
            set
            {
                this.pricedEquipsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public VehicleSegmentCoreTypeTotalCharge TotalCharge
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string IndexNumber
        {
            get
            {
                return this.indexNumberField;
            }
            set
            {
                this.indexNumberField = value;
            }
        }
    }
}