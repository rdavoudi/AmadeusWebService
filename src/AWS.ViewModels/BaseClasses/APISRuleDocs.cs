namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class APISRuleDocs
    {

        private string middleNameField;

        private string documentTypeField;

        private string documentNumberField;

        private string countryOfIssuanceField;

        private string nationalityField;

        private string expiryDateField;

        private string documentTypeMandatoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string MiddleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string DocumentType
        {
            get
            {
                return this.documentTypeField;
            }
            set
            {
                this.documentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string DocumentNumber
        {
            get
            {
                return this.documentNumberField;
            }
            set
            {
                this.documentNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string CountryOfIssuance
        {
            get
            {
                return this.countryOfIssuanceField;
            }
            set
            {
                this.countryOfIssuanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Nationality
        {
            get
            {
                return this.nationalityField;
            }
            set
            {
                this.nationalityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string ExpiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string DocumentTypeMandatory
        {
            get
            {
                return this.documentTypeMandatoryField;
            }
            set
            {
                this.documentTypeMandatoryField = value;
            }
        }
    }
}