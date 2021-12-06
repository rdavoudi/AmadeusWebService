namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class HotelReservationTypeAreas
    {

        private ParagraphType areaDescriptionField;

        private string areaIDField;

        private string cityCodeField;

        private string stateProvCodeField;

        private string countryCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ParagraphType AreaDescription
        {
            get
            {
                return this.areaDescriptionField;
            }
            set
            {
                this.areaDescriptionField = value;
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
        public string StateProvCode
        {
            get
            {
                return this.stateProvCodeField;
            }
            set
            {
                this.stateProvCodeField = value;
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