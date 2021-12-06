namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FlightTermsAndCondition
    {

        private RuleInfos[] ruleInfoField;

        private string destinationField;

        private string originField;

        private string airlineCodeField;

        private string airlineNameField;

        private string fareBasisCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public RuleInfos[] RuleInfo
        {
            get
            {
                return this.ruleInfoField;
            }
            set
            {
                this.ruleInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Destination
        {
            get
            {
                return this.destinationField;
            }
            set
            {
                this.destinationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Origin
        {
            get
            {
                return this.originField;
            }
            set
            {
                this.originField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirlineCode
        {
            get
            {
                return this.airlineCodeField;
            }
            set
            {
                this.airlineCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirlineName
        {
            get
            {
                return this.airlineNameField;
            }
            set
            {
                this.airlineNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareBasisCode
        {
            get
            {
                return this.fareBasisCodeField;
            }
            set
            {
                this.fareBasisCodeField = value;
            }
        }
    }
}