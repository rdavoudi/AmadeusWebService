namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TripFeaturesTypeDestination))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AddressInfoType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleVendorAddressType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OffLocationServiceCoreTypeAddress))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AddressType
    {

        private string contactNameField;

        private string locationField;

        private string areaLocationCodeField;

        private string taxNumberField;

        private string taxOfficeField;

        private string companyField;

        private AddressTypeStreetNmbr streetNmbrField;

        private AddressTypeBldgRoom[] bldgRoomField;

        private string[] addressLineField;

        private string cityNameField;

        private string postalCodeField;

        private string countyField;

        private StateProvType stateProvField;

        private CountryNameType countryNameField;

        private bool formattedIndField;

        private AddressTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private AddressTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private string typeField;

        public AddressType()
        {
            this.formattedIndField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ContactName
        {
            get
            {
                return this.contactNameField;
            }
            set
            {
                this.contactNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string AreaLocationCode
        {
            get
            {
                return this.areaLocationCodeField;
            }
            set
            {
                this.areaLocationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string TaxNumber
        {
            get
            {
                return this.taxNumberField;
            }
            set
            {
                this.taxNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string TaxOffice
        {
            get
            {
                return this.taxOfficeField;
            }
            set
            {
                this.taxOfficeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string Company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public AddressTypeStreetNmbr StreetNmbr
        {
            get
            {
                return this.streetNmbrField;
            }
            set
            {
                this.streetNmbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BldgRoom", Order = 7)]
        public AddressTypeBldgRoom[] BldgRoom
        {
            get
            {
                return this.bldgRoomField;
            }
            set
            {
                this.bldgRoomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddressLine", Order = 8)]
        public string[] AddressLine
        {
            get
            {
                return this.addressLineField;
            }
            set
            {
                this.addressLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string CityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string County
        {
            get
            {
                return this.countyField;
            }
            set
            {
                this.countyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public StateProvType StateProv
        {
            get
            {
                return this.stateProvField;
            }
            set
            {
                this.stateProvField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public CountryNameType CountryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool FormattedInd
        {
            get
            {
                return this.formattedIndField;
            }
            set
            {
                this.formattedIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AddressTypeShareSynchInd ShareSynchInd
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
        public AddressTypeShareMarketInd ShareMarketInd
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
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }
}