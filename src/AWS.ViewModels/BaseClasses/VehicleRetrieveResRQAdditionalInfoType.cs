namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleRetrieveResRQAdditionalInfoType
    {

        private LocationType pickUpLocationField;

        private VehicleRetrieveResRQAdditionalInfoTypeTelephone telephoneField;

        private CompanyNameType vendorField;

        private EmailType emailField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private System.DateTime pickUpDateTimeField;

        private bool pickUpDateTimeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public LocationType PickUpLocation
        {
            get
            {
                return this.pickUpLocationField;
            }
            set
            {
                this.pickUpLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public VehicleRetrieveResRQAdditionalInfoTypeTelephone Telephone
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public EmailType Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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
        public System.DateTime PickUpDateTime
        {
            get
            {
                return this.pickUpDateTimeField;
            }
            set
            {
                this.pickUpDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PickUpDateTimeSpecified
        {
            get
            {
                return this.pickUpDateTimeFieldSpecified;
            }
            set
            {
                this.pickUpDateTimeFieldSpecified = value;
            }
        }
    }
}