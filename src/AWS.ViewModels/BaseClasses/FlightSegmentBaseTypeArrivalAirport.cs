namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FlightSegmentBaseTypeArrivalAirport
    {

        private string locationCodeField;

        private string codeContextField;

        private string terminalField;

        private string gateField;

        public FlightSegmentBaseTypeArrivalAirport()
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
        public string Terminal
        {
            get
            {
                return this.terminalField;
            }
            set
            {
                this.terminalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Gate
        {
            get
            {
                return this.gateField;
            }
            set
            {
                this.gateField = value;
            }
        }
    }
}