namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleAvailCoreTypeVendor))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperatingAirlineType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompanyNamePrefType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleAvailRQCoreTypeVendorPrefsVendorPref))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TravelArrangerType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CompanyNameType
    {

        private string logoUrlField;

        private string termsAndConditionsField;

        private string companyShortNameField;

        private string travelSectorField;

        private string codeField;

        private string codeContextField;

        private string divisionField;

        private string departmentField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LogoUrl
        {
            get
            {
                return this.logoUrlField;
            }
            set
            {
                this.logoUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TermsAndConditions
        {
            get
            {
                return this.termsAndConditionsField;
            }
            set
            {
                this.termsAndConditionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CompanyShortName
        {
            get
            {
                return this.companyShortNameField;
            }
            set
            {
                this.companyShortNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelSector
        {
            get
            {
                return this.travelSectorField;
            }
            set
            {
                this.travelSectorField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Division
        {
            get
            {
                return this.divisionField;
            }
            set
            {
                this.divisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Department
        {
            get
            {
                return this.departmentField;
            }
            set
            {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}