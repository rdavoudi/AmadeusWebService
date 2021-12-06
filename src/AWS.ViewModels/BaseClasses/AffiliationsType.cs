namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BoundedAffiliationsType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AffiliationsType
    {

        private OrganizationType[] organizationField;

        private EmployerType[] employerField;

        private TravelArrangerType[] travelArrangerField;

        private TravelClubType[] travelClubField;

        private InsuranceType[] insuranceField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private AffiliationsTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private AffiliationsTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Organization", Order = 0)]
        public OrganizationType[] Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Employer", Order = 1)]
        public EmployerType[] Employer
        {
            get
            {
                return this.employerField;
            }
            set
            {
                this.employerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TravelArranger", Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute("TravelClub", Order = 3)]
        public TravelClubType[] TravelClub
        {
            get
            {
                return this.travelClubField;
            }
            set
            {
                this.travelClubField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Insurance", Order = 4)]
        public InsuranceType[] Insurance
        {
            get
            {
                return this.insuranceField;
            }
            set
            {
                this.insuranceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
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
        public AffiliationsTypeShareSynchInd ShareSynchInd
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
        public AffiliationsTypeShareMarketInd ShareMarketInd
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
    }
}