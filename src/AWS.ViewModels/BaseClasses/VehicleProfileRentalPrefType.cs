namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleProfileRentalPrefType
    {

        private VehicleProfileRentalPrefTypeLoyaltyPref[] loyaltyPrefField;

        private CompanyNamePrefType[] vendorPrefField;

        private VehicleProfileRentalPrefTypePaymentFormPref[] paymentFormPrefField;

        private VehicleProfileRentalPrefTypeCoveragePref[] coveragePrefField;

        private VehicleSpecialReqPrefType[] specialReqPrefField;

        private VehiclePrefType[] vehTypePrefField;

        private VehicleProfileRentalPrefTypeSpecialEquipPref[] specialEquipPrefField;

        private PreferLevelType preferLevelField;

        private VehicleProfileRentalPrefTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private VehicleProfileRentalPrefTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private bool smokingAllowedField;

        private bool gasPrePayField;

        public VehicleProfileRentalPrefType()
        {
            this.preferLevelField = PreferLevelType.Preferred;
            this.smokingAllowedField = false;
            this.gasPrePayField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyPref", Order = 0)]
        public VehicleProfileRentalPrefTypeLoyaltyPref[] LoyaltyPref
        {
            get
            {
                return this.loyaltyPrefField;
            }
            set
            {
                this.loyaltyPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VendorPref", Order = 1)]
        public CompanyNamePrefType[] VendorPref
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
        [System.Xml.Serialization.XmlElementAttribute("PaymentFormPref", Order = 2)]
        public VehicleProfileRentalPrefTypePaymentFormPref[] PaymentFormPref
        {
            get
            {
                return this.paymentFormPrefField;
            }
            set
            {
                this.paymentFormPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CoveragePref", Order = 3)]
        public VehicleProfileRentalPrefTypeCoveragePref[] CoveragePref
        {
            get
            {
                return this.coveragePrefField;
            }
            set
            {
                this.coveragePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialReqPref", Order = 4)]
        public VehicleSpecialReqPrefType[] SpecialReqPref
        {
            get
            {
                return this.specialReqPrefField;
            }
            set
            {
                this.specialReqPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VehTypePref", Order = 5)]
        public VehiclePrefType[] VehTypePref
        {
            get
            {
                return this.vehTypePrefField;
            }
            set
            {
                this.vehTypePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialEquipPref", Order = 6)]
        public VehicleProfileRentalPrefTypeSpecialEquipPref[] SpecialEquipPref
        {
            get
            {
                return this.specialEquipPrefField;
            }
            set
            {
                this.specialEquipPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(PreferLevelType.Preferred)]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this.preferLevelField;
            }
            set
            {
                this.preferLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleProfileRentalPrefTypeShareSynchInd ShareSynchInd
        {
            get
            {
                return this.shareSynchIndField;
            }
            set
            {
                this.shareSynchIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShareSynchIndSpecified
        {
            get
            {
                return this.shareSynchIndFieldSpecified;
            }
            set
            {
                this.shareSynchIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleProfileRentalPrefTypeShareMarketInd ShareMarketInd
        {
            get
            {
                return this.shareMarketIndField;
            }
            set
            {
                this.shareMarketIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShareMarketIndSpecified
        {
            get
            {
                return this.shareMarketIndFieldSpecified;
            }
            set
            {
                this.shareMarketIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SmokingAllowed
        {
            get
            {
                return this.smokingAllowedField;
            }
            set
            {
                this.smokingAllowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool GasPrePay
        {
            get
            {
                return this.gasPrePayField;
            }
            set
            {
                this.gasPrePayField = value;
            }
        }
    }
}