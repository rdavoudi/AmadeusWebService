namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleAvailCoreTypeDropOffLocation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleAvailCoreTypeVendorLocation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AirportPrefType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleRentalCoreTypePickUpLocation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleRentalCoreTypeReturnLocation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleLocationAdditionalDetailsTypeOneWayDropLocation))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class LocationType
    {

        private string locationCodeField;

        private string codeContextField;

        private string valueField;

        public LocationType()
        {
            this.codeContextField = "IATA";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("IATA")]
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