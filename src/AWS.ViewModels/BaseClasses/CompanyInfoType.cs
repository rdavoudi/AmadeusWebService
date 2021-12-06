namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CompanyInfoType
    {

        private CompanyNameType[] companyNameField;

        private AddressInfoType[] addressInfoField;

        private CompanyInfoTypeTelephoneInfo[] telephoneInfoField;

        private EmailType[] emailField;

        private URL_Type[] uRLField;

        private AddressType[] businessLocaleField;

        private PaymentFormType[] paymentFormField;

        private ContactPersonType[] contactPersonField;

        private TravelArrangerType[] travelArrangerField;

        private LoyaltyProgramType[] loyaltyProgramField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompanyName", Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute("AddressInfo", Order = 1)]
        public AddressInfoType[] AddressInfo
        {
            get
            {
                return this.addressInfoField;
            }
            set
            {
                this.addressInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TelephoneInfo", Order = 2)]
        public CompanyInfoTypeTelephoneInfo[] TelephoneInfo
        {
            get
            {
                return this.telephoneInfoField;
            }
            set
            {
                this.telephoneInfoField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("BusinessLocale", Order = 5)]
        public AddressType[] BusinessLocale
        {
            get
            {
                return this.businessLocaleField;
            }
            set
            {
                this.businessLocaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentForm", Order = 6)]
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
        [System.Xml.Serialization.XmlElementAttribute("ContactPerson", Order = 7)]
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
        [System.Xml.Serialization.XmlElementAttribute("TravelArranger", Order = 8)]
        public TravelArrangerType[] TravelArranger
        {
            get
            {
                return this.travelArrangerField;
            }
            set
            {
                this.travelArrangerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyProgram", Order = 9)]
        public LoyaltyProgramType[] LoyaltyProgram
        {
            get
            {
                return this.loyaltyProgramField;
            }
            set
            {
                this.loyaltyProgramField = value;
            }
        }
    }
}