namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleAvailRQCoreTypeVehPref))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehiclePrefType : VehicleCoreType
    {

        private PreferLevelType typePrefField;

        private bool typePrefFieldSpecified;

        private PreferLevelType classPrefField;

        private bool classPrefFieldSpecified;

        private PreferLevelType airConditionPrefField;

        private bool airConditionPrefFieldSpecified;

        private PreferLevelType transmissionPrefField;

        private bool transmissionPrefFieldSpecified;

        private string vendorCarTypeField;

        private string vehicleQtyField;

        private string codeField;

        private string codeContextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType TypePref
        {
            get
            {
                return this.typePrefField;
            }
            set
            {
                this.typePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypePrefSpecified
        {
            get
            {
                return this.typePrefFieldSpecified;
            }
            set
            {
                this.typePrefFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType ClassPref
        {
            get
            {
                return this.classPrefField;
            }
            set
            {
                this.classPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClassPrefSpecified
        {
            get
            {
                return this.classPrefFieldSpecified;
            }
            set
            {
                this.classPrefFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType AirConditionPref
        {
            get
            {
                return this.airConditionPrefField;
            }
            set
            {
                this.airConditionPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AirConditionPrefSpecified
        {
            get
            {
                return this.airConditionPrefFieldSpecified;
            }
            set
            {
                this.airConditionPrefFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType TransmissionPref
        {
            get
            {
                return this.transmissionPrefField;
            }
            set
            {
                this.transmissionPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransmissionPrefSpecified
        {
            get
            {
                return this.transmissionPrefFieldSpecified;
            }
            set
            {
                this.transmissionPrefFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VendorCarType
        {
            get
            {
                return this.vendorCarTypeField;
            }
            set
            {
                this.vendorCarTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string VehicleQty
        {
            get
            {
                return this.vehicleQtyField;
            }
            set
            {
                this.vehicleQtyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeContext
        {
            get
            {
                return this.codeContextField;
            }
            set
            {
                this.codeContextField = value;
            }
        }
    }
}