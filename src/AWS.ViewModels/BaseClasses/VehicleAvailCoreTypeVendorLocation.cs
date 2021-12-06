namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleAvailCoreTypeVendorLocation : LocationType
    {

        private string extendedLocationCodeField;

        private string counterLocationField;

        private string nameField;

        private VehicleAvailCoreTypeVendorLocationCounterLocInfo counterLocInfoField;

        private bool counterLocInfoFieldSpecified;

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
        public string CounterLocation
        {
            get
            {
                return this.counterLocationField;
            }
            set
            {
                this.counterLocationField = value;
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
        public VehicleAvailCoreTypeVendorLocationCounterLocInfo CounterLocInfo
        {
            get
            {
                return this.counterLocInfoField;
            }
            set
            {
                this.counterLocInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CounterLocInfoSpecified
        {
            get
            {
                return this.counterLocInfoFieldSpecified;
            }
            set
            {
                this.counterLocInfoFieldSpecified = value;
            }
        }
    }
}