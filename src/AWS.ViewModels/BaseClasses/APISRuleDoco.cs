namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class APISRuleDoco
    {

        private string visaNumberField;

        private string placeOfBirthField;

        private string dateOfIssuanceField;

        private string placeOfIssuanceField;

        private string countryRequiringVisaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string VisaNumber
        {
            get
            {
                return this.visaNumberField;
            }
            set
            {
                this.visaNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string PlaceOfBirth
        {
            get
            {
                return this.placeOfBirthField;
            }
            set
            {
                this.placeOfBirthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string DateOfIssuance
        {
            get
            {
                return this.dateOfIssuanceField;
            }
            set
            {
                this.dateOfIssuanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string PlaceOfIssuance
        {
            get
            {
                return this.placeOfIssuanceField;
            }
            set
            {
                this.placeOfIssuanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string CountryRequiringVisa
        {
            get
            {
                return this.countryRequiringVisaField;
            }
            set
            {
                this.countryRequiringVisaField = value;
            }
        }
    }
}