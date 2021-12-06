namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class DocumentType
    {

        private object itemField;

        private string[] docLimitationsField;

        private string[] additionalPersonNamesField;

        private DocumentTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private DocumentTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private string docIssueAuthorityField;

        private string docIssueLocationField;

        private string docIDField;

        private string docTypeField;

        private string innerDocTypeField;

        private DocumentTypeGender genderField;

        private bool genderFieldSpecified;

        private System.DateTime birthDateField;

        private bool birthDateFieldSpecified;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private System.DateTime expireDateField;

        private bool expireDateFieldSpecified;

        private string docIssueStateProvField;

        private string docIssueCountryField;

        private string addressTypeField;

        private string addressDetailsField;

        private string cityCodeField;

        private string stateField;

        private string zipPostalCodeField;

        private string birthCountryField;

        private string docHolderNationalityField;

        private string contactNameField;

        private DocumentTypeHolderType holderTypeField;

        private bool holderTypeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocHolderFormattedName", typeof(PersonNameType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("DocHolderName", typeof(string), Order = 0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocLimitations", Order = 1)]
        public string[] DocLimitations
        {
            get
            {
                return this.docLimitationsField;
            }
            set
            {
                this.docLimitationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AdditionalPersonName", IsNullable = false)]
        public string[] AdditionalPersonNames
        {
            get
            {
                return this.additionalPersonNamesField;
            }
            set
            {
                this.additionalPersonNamesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DocumentTypeShareSynchInd ShareSynchInd
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
        public DocumentTypeShareMarketInd ShareMarketInd
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
        public string DocIssueAuthority
        {
            get
            {
                return this.docIssueAuthorityField;
            }
            set
            {
                this.docIssueAuthorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocIssueLocation
        {
            get
            {
                return this.docIssueLocationField;
            }
            set
            {
                this.docIssueLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocID
        {
            get
            {
                return this.docIDField;
            }
            set
            {
                this.docIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocType
        {
            get
            {
                return this.docTypeField;
            }
            set
            {
                this.docTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InnerDocType
        {
            get
            {
                return this.innerDocTypeField;
            }
            set
            {
                this.innerDocTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DocumentTypeGender Gender
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EffectiveDateSpecified
        {
            get
            {
                return this.effectiveDateFieldSpecified;
            }
            set
            {
                this.effectiveDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ExpireDate
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpireDateSpecified
        {
            get
            {
                return this.expireDateFieldSpecified;
            }
            set
            {
                this.expireDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocIssueStateProv
        {
            get
            {
                return this.docIssueStateProvField;
            }
            set
            {
                this.docIssueStateProvField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocIssueCountry
        {
            get
            {
                return this.docIssueCountryField;
            }
            set
            {
                this.docIssueCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BirthCountry
        {
            get
            {
                return this.birthCountryField;
            }
            set
            {
                this.birthCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocHolderNationality
        {
            get
            {
                return this.docHolderNationalityField;
            }
            set
            {
                this.docHolderNationalityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DocumentTypeHolderType HolderType
        {
            get
            {
                return this.holderTypeField;
            }
            set
            {
                this.holderTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HolderTypeSpecified
        {
            get
            {
                return this.holderTypeFieldSpecified;
            }
            set
            {
                this.holderTypeFieldSpecified = value;
            }
        }
    }
}