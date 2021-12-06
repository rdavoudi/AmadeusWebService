namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleAvailRQAdditionalInfoType
    {

        private CustomerPrimaryAdditionalType customerField;

        private VehicleSpecialReqPrefType[] specialReqPrefField;

        private VehicleAvailRQAdditionalInfoTypeCoveragePref[] coveragePrefsField;

        private OffLocationServiceType[] offLocServiceField;

        private VehicleArrivalDetailsType arrivalDetailsField;

        private VehicleTourInfoType tourInfoField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private string luggageQtyField;

        private string passengerQtyField;

        private bool smokingAllowedField;

        private bool gasPrePayField;

        private bool singleQuoteField;

        private bool singleQuoteFieldSpecified;

        public VehicleAvailRQAdditionalInfoType()
        {
            this.smokingAllowedField = false;
            this.gasPrePayField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute("SpecialReqPref", Order = 1)]
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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CoveragePref", IsNullable = false)]
        public VehicleAvailRQAdditionalInfoTypeCoveragePref[] CoveragePrefs
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
        [System.Xml.Serialization.XmlElementAttribute("OffLocService", Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SingleQuote
        {
            get
            {
                return this.singleQuoteField;
            }
            set
            {
                this.singleQuoteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SingleQuoteSpecified
        {
            get
            {
                return this.singleQuoteFieldSpecified;
            }
            set
            {
                this.singleQuoteFieldSpecified = value;
            }
        }
    }
}