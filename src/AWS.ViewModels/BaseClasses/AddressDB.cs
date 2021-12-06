namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AddressDB : DBBaseEntity
    {

        private System.Nullable<System.Guid> entityIDField;

        private long noField;

        private string addressTypeCodeField;

        private string countryCodeField;

        private string cityCodeField;

        private string stateField;

        private string postalCodeField;

        private string addressLine1Field;

        private string addressLine2Field;

        private string contactNameField;

        private string companyNameField;

        private string bankNameField;

        private string bankAccountNoField;

        private string taxNumberField;

        private string taxOfficeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<System.Guid> EntityID
        {
            get
            {
                return this.entityIDField;
            }
            set
            {
                this.entityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public long No
        {
            get
            {
                return this.noField;
            }
            set
            {
                this.noField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string AddressTypeCode
        {
            get
            {
                return this.addressTypeCodeField;
            }
            set
            {
                this.addressTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string AddressLine1
        {
            get
            {
                return this.addressLine1Field;
            }
            set
            {
                this.addressLine1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string AddressLine2
        {
            get
            {
                return this.addressLine2Field;
            }
            set
            {
                this.addressLine2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string ContactName
        {
            get
            {
                return this.contactNameField;
            }
            set
            {
                this.contactNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string CompanyName
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string BankName
        {
            get
            {
                return this.bankNameField;
            }
            set
            {
                this.bankNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string BankAccountNo
        {
            get
            {
                return this.bankAccountNoField;
            }
            set
            {
                this.bankAccountNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string TaxNumber
        {
            get
            {
                return this.taxNumberField;
            }
            set
            {
                this.taxNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string TaxOffice
        {
            get
            {
                return this.taxOfficeField;
            }
            set
            {
                this.taxOfficeField = value;
            }
        }
    }
}