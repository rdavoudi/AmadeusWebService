namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfViewershipsTypeViewershipViewershipLocationCodesLocationCode
    {

        private string cityCodeField;

        private string stateProvinceCodeField;

        private string countryCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CityCode
        {
            get
            {
                return this.cityCodeField;
            }
            set
            {
                this.cityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StateProvinceCode
        {
            get
            {
                return this.stateProvinceCodeField;
            }
            set
            {
                this.stateProvinceCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
    }
}