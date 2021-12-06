namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PNRListItemType
    {

        private string pNRNoField;

        private string surNameField;

        private string flightNumberField;

        private string carrierField;

        private string fromField;

        private string toField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string PNRNo
        {
            get
            {
                return this.pNRNoField;
            }
            set
            {
                this.pNRNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string SurName
        {
            get
            {
                return this.surNameField;
            }
            set
            {
                this.surNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string FlightNumber
        {
            get
            {
                return this.flightNumberField;
            }
            set
            {
                this.flightNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Carrier
        {
            get
            {
                return this.carrierField;
            }
            set
            {
                this.carrierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string From
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string To
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }
    }
}