namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AncillaryCatalogueItemType
    {

        private string sSRCodeField;

        private string airlineCodeField;

        private AncillaryFareType[] ancillaryFaresField;

        private RequiredParameter[] requiredParametersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string SSRCode
        {
            get
            {
                return this.sSRCodeField;
            }
            set
            {
                this.sSRCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AncillaryFare", IsNullable = false)]
        public AncillaryFareType[] AncillaryFares
        {
            get
            {
                return this.ancillaryFaresField;
            }
            set
            {
                this.ancillaryFaresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        public RequiredParameter[] RequiredParameters
        {
            get
            {
                return this.requiredParametersField;
            }
            set
            {
                this.requiredParametersField = value;
            }
        }
    }
}