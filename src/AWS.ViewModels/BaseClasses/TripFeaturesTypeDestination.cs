namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class TripFeaturesTypeDestination : AddressType
    {

        private System.DateTime arrivalDateField;

        private bool arrivalDateFieldSpecified;

        private System.DateTime departureDateField;

        private bool departureDateFieldSpecified;

        private string areaIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ArrivalDate
        {
            get
            {
                return this.arrivalDateField;
            }
            set
            {
                this.arrivalDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArrivalDateSpecified
        {
            get
            {
                return this.arrivalDateFieldSpecified;
            }
            set
            {
                this.arrivalDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime DepartureDate
        {
            get
            {
                return this.departureDateField;
            }
            set
            {
                this.departureDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepartureDateSpecified
        {
            get
            {
                return this.departureDateFieldSpecified;
            }
            set
            {
                this.departureDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AreaID
        {
            get
            {
                return this.areaIDField;
            }
            set
            {
                this.areaIDField = value;
            }
        }
    }
}