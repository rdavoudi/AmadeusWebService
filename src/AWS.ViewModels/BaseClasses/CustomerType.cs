namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsuranceCustomerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomerPrimaryAdditionalTypePrimary))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomerPrimaryAdditionalTypeAdditional))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CustomerType
    {

        private PersonNameType personNameField;

        private CustomerTypeTelephone[] telephoneField;

        private EmailType[] emailField;

        private CustomerTypeAddress[] addressField;

        private URL_Type[] uRLField;

        private CustomerTypeCitizenCountryName[] citizenCountryNameField;

        private string[] physChallNameField;

        private string[] petInfoField;

        private PaymentFormType[] paymentFormField;

        private RelatedTravelerType[] relatedTravelerField;

        private ContactPersonType[] contactPersonField;

        private DocumentType[] documentField;

        private CustomerTypeCustLoyalty[] custLoyaltyField;

        private EmployeeInfoType[] employeeInfoField;

        private CompanyNameType employerInfoField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private CustomerTypeGender genderField;

        private bool genderFieldSpecified;

        private bool deceasedField;

        private bool deceasedFieldSpecified;

        private string lockoutTypeField;

        private System.DateTime birthDateField;

        private bool birthDateFieldSpecified;

        private string currencyCodeField;

        private string decimalPlacesField;

        private bool vIP_IndicatorField;

        private bool vIP_IndicatorFieldSpecified;

        private string textField;

        private string languageField;

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
        public CustomerTypeTelephone[] Telephone
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
        [System.Xml.Serialization.XmlElementAttribute("Email", Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute("Address", Order = 3)]
        public CustomerTypeAddress[] Address
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
        [System.Xml.Serialization.XmlElementAttribute("CitizenCountryName", Order = 5)]
        public CustomerTypeCitizenCountryName[] CitizenCountryName
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
        [System.Xml.Serialization.XmlElementAttribute("PhysChallName", Order = 6)]
        public string[] PhysChallName
        {
            get
            {
                return this.physChallNameField;
            }
            set
            {
                this.physChallNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PetInfo", Order = 7)]
        public string[] PetInfo
        {
            get
            {
                return this.petInfoField;
            }
            set
            {
                this.petInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentForm", Order = 8)]
        public PaymentFormType[] PaymentForm
        {
            get
            {
                return this.paymentFormField;
            }
            set
            {
                this.paymentFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RelatedTraveler", Order = 9)]
        public RelatedTravelerType[] RelatedTraveler
        {
            get
            {
                return this.relatedTravelerField;
            }
            set
            {
                this.relatedTravelerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactPerson", Order = 10)]
        public ContactPersonType[] ContactPerson
        {
            get
            {
                return this.contactPersonField;
            }
            set
            {
                this.contactPersonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Document", Order = 11)]
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
        [System.Xml.Serialization.XmlElementAttribute("CustLoyalty", Order = 12)]
        public CustomerTypeCustLoyalty[] CustLoyalty
        {
            get
            {
                return this.custLoyaltyField;
            }
            set
            {
                this.custLoyaltyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EmployeeInfo", Order = 13)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public CompanyNameType EmployerInfo
        {
            get
            {
                return this.employerInfoField;
            }
            set
            {
                this.employerInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CustomerTypeGender Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GenderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Deceased
        {
            get
            {
                return this.deceasedField;
            }
            set
            {
                this.deceasedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeceasedSpecified
        {
            get
            {
                return this.deceasedFieldSpecified;
            }
            set
            {
                this.deceasedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LockoutType
        {
            get
            {
                return this.lockoutTypeField;
            }
            set
            {
                this.lockoutTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime BirthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BirthDateSpecified
        {
            get
            {
                return this.birthDateFieldSpecified;
            }
            set
            {
                this.birthDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool VIP_Indicator
        {
            get
            {
                return this.vIP_IndicatorField;
            }
            set
            {
                this.vIP_IndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VIP_IndicatorSpecified
        {
            get
            {
                return this.vIP_IndicatorFieldSpecified;
            }
            set
            {
                this.vIP_IndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "language")]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }
}