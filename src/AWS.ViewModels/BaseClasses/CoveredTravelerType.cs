namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CoveredTravelerType
    {

        private CoveredTravelerTypeCoveredPerson coveredPersonField;

        private EmailType[] emailField;

        private AddressInfoType[] addressField;

        private CoveredTravelerTypeTelephone[] telephoneField;

        private CoveredTravelerTypeCitizenCountryName citizenCountryNameField;

        private DocumentType[] documentField;

        private ContactPersonType[] emergencyContactField;

        private CoveredTravelerTypeBeneficiary[] beneficiaryField;

        private IndCoverageReqsType indCoverageReqsField;

        private string rPHField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CoveredTravelerTypeCoveredPerson CoveredPerson
        {
            get
            {
                return this.coveredPersonField;
            }
            set
            {
                this.coveredPersonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Email", Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute("Telephone", Order = 3)]
        public CoveredTravelerTypeTelephone[] Telephone
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public CoveredTravelerTypeCitizenCountryName CitizenCountryName
        {
            get
            {
                return this.citizenCountryNameField;
            }
            set
            {
                this.citizenCountryNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Document", Order = 5)]
        public DocumentType[] Document
        {
            get
            {
                return this.documentField;
            }
            set
            {
                this.documentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EmergencyContact", Order = 6)]
        public ContactPersonType[] EmergencyContact
        {
            get
            {
                return this.emergencyContactField;
            }
            set
            {
                this.emergencyContactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Beneficiary", Order = 7)]
        public CoveredTravelerTypeBeneficiary[] Beneficiary
        {
            get
            {
                return this.beneficiaryField;
            }
            set
            {
                this.beneficiaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public IndCoverageReqsType IndCoverageReqs
        {
            get
            {
                return this.indCoverageReqsField;
            }
            set
            {
                this.indCoverageReqsField = value;
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
    }
}