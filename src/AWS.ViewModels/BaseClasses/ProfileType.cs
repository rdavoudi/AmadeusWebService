namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ProfileType
    {

        private AccessesType accessesField;

        private CustomerType customerField;

        private PreferencesType prefCollectionsField;

        private CompanyInfoType companyInfoField;

        private AffiliationsType affiliationsField;

        private AgreementsType agreementsField;

        private ArrayOfCommentTypeCommentComment[] commentsField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private YesNoType shareAllSynchIndField;

        private YesNoType shareAllMarketIndField;

        private string profileType1Field;

        private System.DateTime createDateTimeField;

        private bool createDateTimeFieldSpecified;

        private string creatorIDField;

        private System.DateTime lastModifyDateTimeField;

        private bool lastModifyDateTimeFieldSpecified;

        private string lastModifierIDField;

        private System.DateTime purgeDateField;

        private bool purgeDateFieldSpecified;

        private string rPHField;

        public ProfileType()
        {
            this.shareAllSynchIndField = YesNoType.No;
            this.shareAllMarketIndField = YesNoType.No;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AccessesType Accesses
        {
            get
            {
                return this.accessesField;
            }
            set
            {
                this.accessesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CustomerType Customer
        {
            get
            {
                return this.customerField;
            }
            set
            {
                this.customerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public PreferencesType PrefCollections
        {
            get
            {
                return this.prefCollectionsField;
            }
            set
            {
                this.prefCollectionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CompanyInfoType CompanyInfo
        {
            get
            {
                return this.companyInfoField;
            }
            set
            {
                this.companyInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public AffiliationsType Affiliations
        {
            get
            {
                return this.affiliationsField;
            }
            set
            {
                this.affiliationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public AgreementsType Agreements
        {
            get
            {
                return this.agreementsField;
            }
            set
            {
                this.agreementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 6)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Comment", IsNullable = false)]
        public ArrayOfCommentTypeCommentComment[] Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
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
        [System.ComponentModel.DefaultValueAttribute(YesNoType.No)]
        public YesNoType ShareAllSynchInd
        {
            get
            {
                return this.shareAllSynchIndField;
            }
            set
            {
                this.shareAllSynchIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(YesNoType.No)]
        public YesNoType ShareAllMarketInd
        {
            get
            {
                return this.shareAllMarketIndField;
            }
            set
            {
                this.shareAllMarketIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ProfileType")]
        public string ProfileType1
        {
            get
            {
                return this.profileType1Field;
            }
            set
            {
                this.profileType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime CreateDateTime
        {
            get
            {
                return this.createDateTimeField;
            }
            set
            {
                this.createDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreateDateTimeSpecified
        {
            get
            {
                return this.createDateTimeFieldSpecified;
            }
            set
            {
                this.createDateTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CreatorID
        {
            get
            {
                return this.creatorIDField;
            }
            set
            {
                this.creatorIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastModifyDateTime
        {
            get
            {
                return this.lastModifyDateTimeField;
            }
            set
            {
                this.lastModifyDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastModifyDateTimeSpecified
        {
            get
            {
                return this.lastModifyDateTimeFieldSpecified;
            }
            set
            {
                this.lastModifyDateTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LastModifierID
        {
            get
            {
                return this.lastModifierIDField;
            }
            set
            {
                this.lastModifierIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime PurgeDate
        {
            get
            {
                return this.purgeDateField;
            }
            set
            {
                this.purgeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PurgeDateSpecified
        {
            get
            {
                return this.purgeDateFieldSpecified;
            }
            set
            {
                this.purgeDateFieldSpecified = value;
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