namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleAvailCoreType
    {

        private VehicleType vehicleField;

        private VehicleRentalRateType[] rentalRateField;

        private VehicleAvailCoreTypeTotalCharge[] totalChargeField;

        private VehicleEquipmentPricedType[] pricedEquipsField;

        private VehicleChargePurposeType[] feesField;

        private VehicleAvailCoreTypeReference referenceField;

        private VehicleAvailCoreTypeVendor vendorField;

        private VehicleAvailCoreTypeVendorLocation vendorLocationField;

        private VehicleAvailCoreTypeDropOffLocation dropOffLocationField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private InventoryStatusType statusField;

        private bool isAlternateIndField;

        private bool isAlternateIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute("RentalRate", Order = 1)]
        public VehicleRentalRateType[] RentalRate
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
        [System.Xml.Serialization.XmlElementAttribute("TotalCharge", Order = 2)]
        public VehicleAvailCoreTypeTotalCharge[] TotalCharge
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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public VehicleAvailCoreTypeReference Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public VehicleAvailCoreTypeVendor Vendor
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public VehicleAvailCoreTypeVendorLocation VendorLocation
        {
            get
            {
                return this.vendorLocationField;
            }
            set
            {
                this.vendorLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public VehicleAvailCoreTypeDropOffLocation DropOffLocation
        {
            get
            {
                return this.dropOffLocationField;
            }
            set
            {
                this.dropOffLocationField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsAlternateInd
        {
            get
            {
                return this.isAlternateIndField;
            }
            set
            {
                this.isAlternateIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsAlternateIndSpecified
        {
            get
            {
                return this.isAlternateIndFieldSpecified;
            }
            set
            {
                this.isAlternateIndFieldSpecified = value;
            }
        }
    }
}