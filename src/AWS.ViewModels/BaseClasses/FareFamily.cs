namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FareFamily
    {

        private object[] itemsField;

        private string packageIdField;

        private string fareFamilyNameField;

        private string resBookDesigCabinCodeField;

        private string fareBasisField;

        private string classField;

        private bool currentFlightField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Errors", typeof(ErrorsType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("FareFamilyDescriptions", typeof(FareFamilyDescription[]), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("FareInfo", typeof(FareInfo), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("FlightInfo", typeof(FlightInfo), Order = 0)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PackageId
        {
            get
            {
                return this.packageIdField;
            }
            set
            {
                this.packageIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareFamilyName
        {
            get
            {
                return this.fareFamilyNameField;
            }
            set
            {
                this.fareFamilyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCabinCode
        {
            get
            {
                return this.resBookDesigCabinCodeField;
            }
            set
            {
                this.resBookDesigCabinCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareBasis
        {
            get
            {
                return this.fareBasisField;
            }
            set
            {
                this.fareBasisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CurrentFlight
        {
            get
            {
                return this.currentFlightField;
            }
            set
            {
                this.currentFlightField = value;
            }
        }
    }
}