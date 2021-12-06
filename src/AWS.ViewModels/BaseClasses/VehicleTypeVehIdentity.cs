namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleTypeVehIdentity
    {

        private string vehicleAssetNumberField;

        private string licensePlateNumberField;

        private string stateProvCodeField;

        private string countryCodeField;

        private string vehicleID_NumberField;

        private string vehicleColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VehicleAssetNumber
        {
            get
            {
                return this.vehicleAssetNumberField;
            }
            set
            {
                this.vehicleAssetNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LicensePlateNumber
        {
            get
            {
                return this.licensePlateNumberField;
            }
            set
            {
                this.licensePlateNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StateProvCode
        {
            get
            {
                return this.stateProvCodeField;
            }
            set
            {
                this.stateProvCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VehicleID_Number
        {
            get
            {
                return this.vehicleID_NumberField;
            }
            set
            {
                this.vehicleID_NumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VehicleColor
        {
            get
            {
                return this.vehicleColorField;
            }
            set
            {
                this.vehicleColorField = value;
            }
        }
    }
}