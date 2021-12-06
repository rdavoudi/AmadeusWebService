namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_VehRateRuleRSRentalRate))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleRentalRateType
    {

        private VehicleChargeTypeTaxAmount[] carTaxesField;

        private VehicleVendorAddressType[] carCompanyAddressesField;

        private SpecialRemarkType[] remarksField;

        private string carModelField;

        private VehicleRentalRateTypeRateDistance[] rateDistanceField;

        private VehicleChargePurposeType[] vehicleChargesField;

        private RateQualifierType rateQualifierField;

        private VehicleRentalRateTypeRateRestrictions rateRestrictionsField;

        private VehicleRentalRateTypeRateGuarantee rateGuaranteeField;

        private VehicleRentalRateTypePickupReturnRule[] pickupReturnRuleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CarTax", IsNullable = false)]
        public VehicleChargeTypeTaxAmount[] CarTaxes
        {
            get
            {
                return this.carTaxesField;
            }
            set
            {
                this.carTaxesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CarCompanyAddress", IsNullable = false)]
        public VehicleVendorAddressType[] CarCompanyAddresses
        {
            get
            {
                return this.carCompanyAddressesField;
            }
            set
            {
                this.carCompanyAddressesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Remark", IsNullable = false)]
        public SpecialRemarkType[] Remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string CarModel
        {
            get
            {
                return this.carModelField;
            }
            set
            {
                this.carModelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RateDistance", Order = 4)]
        public VehicleRentalRateTypeRateDistance[] RateDistance
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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public VehicleRentalRateTypeRateRestrictions RateRestrictions
        {
            get
            {
                return this.rateRestrictionsField;
            }
            set
            {
                this.rateRestrictionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public VehicleRentalRateTypeRateGuarantee RateGuarantee
        {
            get
            {
                return this.rateGuaranteeField;
            }
            set
            {
                this.rateGuaranteeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PickupReturnRule", Order = 9)]
        public VehicleRentalRateTypePickupReturnRule[] PickupReturnRule
        {
            get
            {
                return this.pickupReturnRuleField;
            }
            set
            {
                this.pickupReturnRuleField = value;
            }
        }
    }
}