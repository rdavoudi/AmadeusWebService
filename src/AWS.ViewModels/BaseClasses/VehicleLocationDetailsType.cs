namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_VehRateRuleRSLocationDetails))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleLocationDetailsType
    {

        private LocationOpeningHour[] locationOpeningHoursField;

        private AddressInfoType[] addressField;

        private VehicleLocationDetailsTypeTelephone[] telephoneField;

        private VehicleLocationAdditionalDetailsType additionalInfoField;

        private bool atAirportField;

        private bool atAirportFieldSpecified;

        private string codeField;

        private string locationAgencyField;

        private string nameField;

        private string codeContextField;

        private string extendedLocationCodeField;

        private string[] assocAirportLocListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LocationOpeningHours", Order = 0)]
        public LocationOpeningHour[] LocationOpeningHours
        {
            get
            {
                return this.locationOpeningHoursField;
            }
            set
            {
                this.locationOpeningHoursField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Address", Order = 1)]
        public AddressInfoType[] Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Telephone", Order = 2)]
        public VehicleLocationDetailsTypeTelephone[] Telephone
        {
            get
            {
                return this.telephoneField;
            }
            set
            {
                this.telephoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public VehicleLocationAdditionalDetailsType AdditionalInfo
        {
            get
            {
                return this.additionalInfoField;
            }
            set
            {
                this.additionalInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AtAirport
        {
            get
            {
                return this.atAirportField;
            }
            set
            {
                this.atAirportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AtAirportSpecified
        {
            get
            {
                return this.atAirportFieldSpecified;
            }
            set
            {
                this.atAirportFieldSpecified = value;
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
        public string LocationAgency
        {
            get
            {
                return this.locationAgencyField;
            }
            set
            {
                this.locationAgencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExtendedLocationCode
        {
            get
            {
                return this.extendedLocationCodeField;
            }
            set
            {
                this.extendedLocationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] AssocAirportLocList
        {
            get
            {
                return this.assocAirportLocListField;
            }
            set
            {
                this.assocAirportLocListField = value;
            }
        }
    }
}