namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OrganizationType
    {

        private OrganizationTypeOrgMemberName orgMemberNameField;

        private CompanyNameType orgNameField;

        private CompanyNameType[] relatedOrgNameField;

        private TravelArrangerType[] travelArrangerField;

        private bool defaultIndField;

        private OrganizationTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private OrganizationTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private System.DateTime expireDateField;

        private bool expireDateFieldSpecified;

        private OfficeLocationType officeTypeField;

        private bool officeTypeFieldSpecified;

        public OrganizationType()
        {
            this.defaultIndField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OrganizationTypeOrgMemberName OrgMemberName
        {
            get
            {
                return this.orgMemberNameField;
            }
            set
            {
                this.orgMemberNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CompanyNameType OrgName
        {
            get
            {
                return this.orgNameField;
            }
            set
            {
                this.orgNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RelatedOrgName", Order = 2)]
        public CompanyNameType[] RelatedOrgName
        {
            get
            {
                return this.relatedOrgNameField;
            }
            set
            {
                this.relatedOrgNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TravelArranger", Order = 3)]
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
        public OrganizationTypeShareSynchInd ShareSynchInd
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
        public OrganizationTypeShareMarketInd ShareMarketInd
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
        public OfficeLocationType OfficeType
        {
            get
            {
                return this.officeTypeField;
            }
            set
            {
                this.officeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OfficeTypeSpecified
        {
            get
            {
                return this.officeTypeFieldSpecified;
            }
            set
            {
                this.officeTypeFieldSpecified = value;
            }
        }
    }
}