namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_VehResRQVehResRQInfo))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleReservationRQAdditionalInfoType
    {

        private VehicleSpecialReqPrefType[] specialReqPrefField;

        private VehicleReservationRQAdditionalInfoTypeCoveragePref[] coveragePrefsField;

        private OffLocationServiceType[] offLocServiceField;

        private VehicleArrivalDetailsType arrivalDetailsField;

        private VehicleReservationRQAdditionalInfoTypeRentalPaymentPref[] rentalPaymentPrefField;

        private VehicleReservationRQAdditionalInfoTypeReference referenceField;

        private VehicleTourInfoType tourInfoField;

        private WrittenConfInstType writtenConfInstField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private string luggageQtyField;

        private string passengerQtyField;

        private bool smokingAllowedField;

        private bool gasPrePayField;

        public VehicleReservationRQAdditionalInfoType()
        {
            this.smokingAllowedField = false;
            this.gasPrePayField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialReqPref", Order = 0)]
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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CoveragePref", IsNullable = false)]
        public VehicleReservationRQAdditionalInfoTypeCoveragePref[] CoveragePrefs
        {
            get
            {
                return this.coveragePrefsField;
            }
            set
            {
                this.coveragePrefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OffLocService", Order = 2)]
        public OffLocationServiceType[] OffLocService
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute("RentalPaymentPref", Order = 4)]
        public VehicleReservationRQAdditionalInfoTypeRentalPaymentPref[] RentalPaymentPref
        {
            get
            {
                return this.rentalPaymentPrefField;
            }
            set
            {
                this.rentalPaymentPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public VehicleReservationRQAdditionalInfoTypeReference Reference
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public WrittenConfInstType WrittenConfInst
        {
            get
            {
                return this.writtenConfInstField;
            }
            set
            {
                this.writtenConfInstField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string LuggageQty
        {
            get
            {
                return this.luggageQtyField;
            }
            set
            {
                this.luggageQtyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string PassengerQty
        {
            get
            {
                return this.passengerQtyField;
            }
            set
            {
                this.passengerQtyField = value;
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