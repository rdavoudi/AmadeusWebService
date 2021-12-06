namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightSegmentTypeStopLocation
    {

        private string locationCodeField;

        private string codeContextField;

        private System.DateTime departureDateTimeField;

        private bool departureDateTimeFieldSpecified;

        private System.DateTime arrivalDateTimeField;

        private bool arrivalDateTimeFieldSpecified;

        public BookFlightSegmentTypeStopLocation()
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DepartureDateTime
        {
            get
            {
                return this.departureDateTimeField;
            }
            set
            {
                this.departureDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepartureDateTimeSpecified
        {
            get
            {
                return this.departureDateTimeFieldSpecified;
            }
            set
            {
                this.departureDateTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ArrivalDateTime
        {
            get
            {
                return this.arrivalDateTimeField;
            }
            set
            {
                this.arrivalDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArrivalDateTimeSpecified
        {
            get
            {
                return this.arrivalDateTimeFieldSpecified;
            }
            set
            {
                this.arrivalDateTimeFieldSpecified = value;
            }
        }
    }
}