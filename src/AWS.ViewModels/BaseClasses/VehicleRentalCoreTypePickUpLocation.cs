namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleRentalCoreTypePickUpLocation : LocationType
    {

        private string locationAgencyField;

        private string vicinityCodeField;

        private bool isCityField;

        private bool isAirportField;

        private string extendedLocationCodeField;

        private string counterLocationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationAgency
        {
            get
            {
                return this.locationAgencyField;
            }
            set
            {
                this.locationAgencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VicinityCode
        {
            get
            {
                return this.vicinityCodeField;
            }
            set
            {
                this.vicinityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsCity
        {
            get
            {
                return this.isCityField;
            }
            set
            {
                this.isCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsAirport
        {
            get
            {
                return this.isAirportField;
            }
            set
            {
                this.isAirportField = value;
            }
        }

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
    }
}