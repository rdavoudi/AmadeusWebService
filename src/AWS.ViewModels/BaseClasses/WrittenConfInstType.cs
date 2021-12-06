namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class WrittenConfInstType
    {

        private ParagraphType supplementalDataField;

        private EmailType emailField;

        private string languageIDField;

        private string addresseeNameField;

        private string addressField;

        private string telephoneField;

        private bool confirmIndField;

        private bool confirmIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ParagraphType SupplementalData
        {
            get
            {
                return this.supplementalDataField;
            }
            set
            {
                this.supplementalDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public EmailType Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LanguageID
        {
            get
            {
                return this.languageIDField;
            }
            set
            {
                this.languageIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AddresseeName
        {
            get
            {
                return this.addresseeNameField;
            }
            set
            {
                this.addresseeNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Telephone
        {
            get
            {
                return this.telephoneField;
            }
            set
            {
                this.telephoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ConfirmInd
        {
            get
            {
                return this.confirmIndField;
            }
            set
            {
                this.confirmIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConfirmIndSpecified
        {
            get
            {
                return this.confirmIndFieldSpecified;
            }
            set
            {
                this.confirmIndFieldSpecified = value;
            }
        }
    }
}