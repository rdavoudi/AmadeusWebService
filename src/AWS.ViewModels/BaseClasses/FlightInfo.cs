namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FlightInfo
    {

        private string airlineField;

        private string routesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Airline
        {
            get
            {
                return this.airlineField;
            }
            set
            {
                this.airlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Routes
        {
            get
            {
                return this.routesField;
            }
            set
            {
                this.routesField = value;
            }
        }
    }
}