namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_InsurancePlanSearchRQCoveragePreference))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CoverageLimitType
    {

        private CoverageLimitTypeDeductible deductibleField;

        private CoverageLimitTypePolicyLimit policyLimitField;

        private CoverageLimitTypeIndividualLimit individualLimitField;

        private string coverageLevelField;

        private string coverageTypeField;

        private bool unlimitedCoverageField;

        private bool unlimitedCoverageFieldSpecified;

        private bool coveredField;

        private bool coveredFieldSpecified;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private System.DateTime expireDateField;

        private bool expireDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CoverageLimitTypeDeductible Deductible
        {
            get
            {
                return this.deductibleField;
            }
            set
            {
                this.deductibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CoverageLimitTypePolicyLimit PolicyLimit
        {
            get
            {
                return this.policyLimitField;
            }
            set
            {
                this.policyLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CoverageLimitTypeIndividualLimit IndividualLimit
        {
            get
            {
                return this.individualLimitField;
            }
            set
            {
                this.individualLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CoverageLevel
        {
            get
            {
                return this.coverageLevelField;
            }
            set
            {
                this.coverageLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CoverageType
        {
            get
            {
                return this.coverageTypeField;
            }
            set
            {
                this.coverageTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool UnlimitedCoverage
        {
            get
            {
                return this.unlimitedCoverageField;
            }
            set
            {
                this.unlimitedCoverageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnlimitedCoverageSpecified
        {
            get
            {
                return this.unlimitedCoverageFieldSpecified;
            }
            set
            {
                this.unlimitedCoverageFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Covered
        {
            get
            {
                return this.coveredField;
            }
            set
            {
                this.coveredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CoveredSpecified
        {
            get
            {
                return this.coveredFieldSpecified;
            }
            set
            {
                this.coveredFieldSpecified = value;
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
    }
}