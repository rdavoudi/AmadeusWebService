namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ContactPersonType
    {

        private PersonNameType personNameField;

        private ContactPersonTypeTelephone[] telephoneField;

        private AddressInfoType[] addressField;

        private EmailType[] emailField;

        private URL_Type[] uRLField;

        private CompanyNameType[] companyNameField;

        private EmployeeInfoType[] employeeInfoField;

        private ContactPersonTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private ContactPersonTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private bool defaultIndField;

        private string contactTypeField;

        private string relationField;

        private bool emergencyFlagField;

        private string rPHField;

        private string communicationMethodCodeField;

        private string documentDistribMethodCodeField;

        public ContactPersonType()
        {
            this.defaultIndField = false;
            this.emergencyFlagField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PersonNameType PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Telephone", Order = 1)]
        public ContactPersonTypeTelephone[] Telephone
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
        [System.Xml.Serialization.XmlElementAttribute("Address", Order = 2)]
        public AddressInfoType[] Address
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
        [System.Xml.Serialization.XmlElementAttribute("Email", Order = 3)]
        public EmailType[] Email
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
        [System.Xml.Serialization.XmlElementAttribute("URL", Order = 4)]
        public URL_Type[] URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompanyName", Order = 5)]
        public CompanyNameType[] CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EmployeeInfo", Order = 6)]
        public EmployeeInfoType[] EmployeeInfo
        {
            get
            {
                return this.employeeInfoField;
            }
            set
            {
                this.employeeInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ContactPersonTypeShareSynchInd ShareSynchInd
        {
            get
            {
                return this.shareSynchIndField;
            }
            set
            {
                this.shareSynchIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShareSynchIndSpecified
        {
            get
            {
                return this.shareSynchIndFieldSpecified;
            }
            set
            {
                this.shareSynchIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ContactPersonTypeShareMarketInd ShareMarketInd
        {
            get
            {
                return this.shareMarketIndField;
            }
            set
            {
                this.shareMarketIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShareMarketIndSpecified
        {
            get
            {
                return this.shareMarketIndFieldSpecified;
            }
            set
            {
                this.shareMarketIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DefaultInd
        {
            get
            {
                return this.defaultIndField;
            }
            set
            {
                this.defaultIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContactType
        {
            get
            {
                return this.contactTypeField;
            }
            set
            {
                this.contactTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Relation
        {
            get
            {
                return this.relationField;
            }
            set
            {
                this.relationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool EmergencyFlag
        {
            get
            {
                return this.emergencyFlagField;
            }
            set
            {
                this.emergencyFlagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CommunicationMethodCode
        {
            get
            {
                return this.communicationMethodCodeField;
            }
            set
            {
                this.communicationMethodCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocumentDistribMethodCode
        {
            get
            {
                return this.documentDistribMethodCodeField;
            }
            set
            {
                this.documentDistribMethodCodeField = value;
            }
        }
    }
}