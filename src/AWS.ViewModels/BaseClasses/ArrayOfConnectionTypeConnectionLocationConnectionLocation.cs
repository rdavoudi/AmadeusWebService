namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfConnectionTypeConnectionLocationConnectionLocation : LocationType
    {

        private bool inclusiveField;

        private PreferLevelType preferLevelField;

        private string minChangeTimeField;

        private ArrayOfConnectionTypeConnectionLocationConnectionLocationConnectionInfo connectionInfoField;

        private bool connectionInfoFieldSpecified;

        private bool multiAirportCityIndField;

        private bool multiAirportCityIndFieldSpecified;

        public ArrayOfConnectionTypeConnectionLocationConnectionLocation()
        {
            this.inclusiveField = true;
            this.preferLevelField = PreferLevelType.Preferred;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Inclusive
        {
            get
            {
                return this.inclusiveField;
            }
            set
            {
                this.inclusiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(PreferLevelType.Preferred)]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this.preferLevelField;
            }
            set
            {
                this.preferLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string MinChangeTime
        {
            get
            {
                return this.minChangeTimeField;
            }
            set
            {
                this.minChangeTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ArrayOfConnectionTypeConnectionLocationConnectionLocationConnectionInfo ConnectionInfo
        {
            get
            {
                return this.connectionInfoField;
            }
            set
            {
                this.connectionInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConnectionInfoSpecified
        {
            get
            {
                return this.connectionInfoFieldSpecified;
            }
            set
            {
                this.connectionInfoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MultiAirportCityInd
        {
            get
            {
                return this.multiAirportCityIndField;
            }
            set
            {
                this.multiAirportCityIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MultiAirportCityIndSpecified
        {
            get
            {
                return this.multiAirportCityIndFieldSpecified;
            }
            set
            {
                this.multiAirportCityIndFieldSpecified = value;
            }
        }
    }
}