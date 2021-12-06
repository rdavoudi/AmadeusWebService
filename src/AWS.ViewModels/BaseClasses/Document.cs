namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class Document : DBBaseEntity
    {

        private string documentTypeMandatoryField;

        private System.Nullable<System.Guid> entityIDField;

        private string numberField;

        private string documentTypesField;

        private string nationalityField;

        private string typeCodeField;

        private string issuerField;

        private string issuerTypeCodeField;

        private string countryCodeField;

        private string cityCodeField;

        private System.Nullable<System.DateTime> issueDateField;

        private System.Nullable<System.DateTime> expireDateField;

        private string issueLocationField;

        private string placeOfBirthField;

        private string passengerTypeField;

        private string addressTypeField;

        private string addressDetailsField;

        private string stateField;

        private string zipPostalCodeField;

        private int lineNumberField;

        private int passengerOrderIdField;

        private string companyCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string DocumentTypes
        {
            get
            {
                return this.documentTypesField;
            }
            set
            {
                this.documentTypesField = value;
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
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string IssuerTypeCode
        {
            get
            {
                return this.issuerTypeCodeField;
            }
            set
            {
                this.issuerTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<System.DateTime> IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<System.DateTime> ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string IssueLocation
        {
            get
            {
                return this.issueLocationField;
            }
            set
            {
                this.issueLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string PassengerType
        {
            get
            {
                return this.passengerTypeField;
            }
            set
            {
                this.passengerTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string AddressType
        {
            get
            {
                return this.addressTypeField;
            }
            set
            {
                this.addressTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string AddressDetails
        {
            get
            {
                return this.addressDetailsField;
            }
            set
            {
                this.addressDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public string ZipPostalCode
        {
            get
            {
                return this.zipPostalCodeField;
            }
            set
            {
                this.zipPostalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public int LineNumber
        {
            get
            {
                return this.lineNumberField;
            }
            set
            {
                this.lineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public int PassengerOrderId
        {
            get
            {
                return this.passengerOrderIdField;
            }
            set
            {
                this.passengerOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public string CompanyCode
        {
            get
            {
                return this.companyCodeField;
            }
            set
            {
                this.companyCodeField = value;
            }
        }
    }
}