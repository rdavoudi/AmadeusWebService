namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_InsurancePlanSearchRQSearchTravInfo
    {

        private SearchTravelerType[] searchTravelersField;

        private CountryNameType citizenCountryNameField;

        private CountryNameType residenceCountryNameField;

        private BoundedAffiliationsType affiliationsField;

        private string minTravelersField;

        private string maxTravelersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SearchTraveler", IsNullable = false)]
        public SearchTravelerType[] SearchTravelers
        {
            get
            {
                return this.searchTravelersField;
            }
            set
            {
                this.searchTravelersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CountryNameType CitizenCountryName
        {
            get
            {
                return this.citizenCountryNameField;
            }
            set
            {
                this.citizenCountryNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CountryNameType ResidenceCountryName
        {
            get
            {
                return this.residenceCountryNameField;
            }
            set
            {
                this.residenceCountryNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public BoundedAffiliationsType Affiliations
        {
            get
            {
                return this.affiliationsField;
            }
            set
            {
                this.affiliationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string MinTravelers
        {
            get
            {
                return this.minTravelersField;
            }
            set
            {
                this.minTravelersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string MaxTravelers
        {
            get
            {
                return this.maxTravelersField;
            }
            set
            {
                this.maxTravelersField = value;
            }
        }
    }
}