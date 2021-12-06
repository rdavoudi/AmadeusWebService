namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoveredTravelerTypeBeneficiaryName))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoveredTravelerTypeCoveredPerson))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PersonNameType
    {

        private string[] namePrefixField;

        private string[] givenNameField;

        private string[] middleNameField;

        private string surnamePrefixField;

        private string surnameField;

        private string[] nameSuffixField;

        private string[] nameTitleField;

        private PersonNameTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private PersonNameTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private string nameTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NamePrefix", Order = 0)]
        public string[] NamePrefix
        {
            get
            {
                return this.namePrefixField;
            }
            set
            {
                this.namePrefixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GivenName", Order = 1)]
        public string[] GivenName
        {
            get
            {
                return this.givenNameField;
            }
            set
            {
                this.givenNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MiddleName", Order = 2)]
        public string[] MiddleName
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string SurnamePrefix
        {
            get
            {
                return this.surnamePrefixField;
            }
            set
            {
                this.surnamePrefixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NameSuffix", Order = 5)]
        public string[] NameSuffix
        {
            get
            {
                return this.nameSuffixField;
            }
            set
            {
                this.nameSuffixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NameTitle", Order = 6)]
        public string[] NameTitle
        {
            get
            {
                return this.nameTitleField;
            }
            set
            {
                this.nameTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PersonNameTypeShareSynchInd ShareSynchInd
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
        public PersonNameTypeShareMarketInd ShareMarketInd
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
        public string NameType
        {
            get
            {
                return this.nameTypeField;
            }
            set
            {
                this.nameTypeField = value;
            }
        }
    }
}