namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OriginDestinationInformationType : TravelDateTimeType
    {

        private OriginDestinationInformationTypeOriginLocation originLocationField;

        private OriginDestinationInformationTypeDestinationLocation destinationLocationField;

        private ArrayOfOriginDestinationInformationTypeOriginLocationOriginLocation[] originLocationListField;

        private ArrayOfOriginDestinationInformationTypeDestinationLocationDestinationLocation[] destinationLocationListField;

        private ArrayOfConnectionTypeConnectionLocationConnectionLocation[] connectionLocationsField;

        private RadiusItem radiusInformationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OriginDestinationInformationTypeOriginLocation OriginLocation
        {
            get
            {
                return this.originLocationField;
            }
            set
            {
                this.originLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OriginDestinationInformationTypeDestinationLocation DestinationLocation
        {
            get
            {
                return this.destinationLocationField;
            }
            set
            {
                this.destinationLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("OriginLocation", IsNullable = false)]
        public ArrayOfOriginDestinationInformationTypeOriginLocationOriginLocation[] OriginLocationList
        {
            get
            {
                return this.originLocationListField;
            }
            set
            {
                this.originLocationListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("DestinationLocation", IsNullable = false)]
        public ArrayOfOriginDestinationInformationTypeDestinationLocationDestinationLocation[] DestinationLocationList
        {
            get
            {
                return this.destinationLocationListField;
            }
            set
            {
                this.destinationLocationListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ConnectionLocation", IsNullable = false)]
        public ArrayOfConnectionTypeConnectionLocationConnectionLocation[] ConnectionLocations
        {
            get
            {
                return this.connectionLocationsField;
            }
            set
            {
                this.connectionLocationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public RadiusItem RadiusInformation
        {
            get
            {
                return this.radiusInformationField;
            }
            set
            {
                this.radiusInformationField = value;
            }
        }
    }
}