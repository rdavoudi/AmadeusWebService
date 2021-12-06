namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfOriginDestinationInformationTypeDestinationLocationDestinationLocation : LocationType
    {

        private bool multiAirportCityIndField;

        private bool multiAirportCityIndFieldSpecified;

        private bool alternateLocationIndField;

        private bool alternateLocationIndFieldSpecified;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AlternateLocationInd
        {
            get
            {
                return this.alternateLocationIndField;
            }
            set
            {
                this.alternateLocationIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AlternateLocationIndSpecified
        {
            get
            {
                return this.alternateLocationIndFieldSpecified;
            }
            set
            {
                this.alternateLocationIndFieldSpecified = value;
            }
        }
    }
}