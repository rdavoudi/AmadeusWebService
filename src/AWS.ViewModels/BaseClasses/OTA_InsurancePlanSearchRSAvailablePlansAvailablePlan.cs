namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_InsurancePlanSearchRSAvailablePlansAvailablePlan
    {

        private OTA_InsurancePlanSearchRSAvailablePlansAvailablePlanPlanDetail planDetailField;

        private OTA_InsurancePlanSearchRSAvailablePlansAvailablePlanProviderDetail providerDetailField;

        private OTA_InsurancePlanSearchRSAvailablePlansAvailablePlanUnderwriterDetail underwriterDetailField;

        private PlanCostType planCostField;

        private PlanRestrictionTypePlanRestriction[] planRestrictionsField;

        private bool featuredField;

        private bool featuredFieldSpecified;

        private PreferLevelType preferLevelField;

        private bool preferLevelFieldSpecified;

        private string planCodeField;

        private string planIDField;

        private string nameField;

        private string typeField;

        private string typeIDField;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private System.DateTime expireDateField;

        private bool expireDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_InsurancePlanSearchRSAvailablePlansAvailablePlanPlanDetail PlanDetail
        {
            get
            {
                return this.planDetailField;
            }
            set
            {
                this.planDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_InsurancePlanSearchRSAvailablePlansAvailablePlanProviderDetail ProviderDetail
        {
            get
            {
                return this.providerDetailField;
            }
            set
            {
                this.providerDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public OTA_InsurancePlanSearchRSAvailablePlansAvailablePlanUnderwriterDetail UnderwriterDetail
        {
            get
            {
                return this.underwriterDetailField;
            }
            set
            {
                this.underwriterDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public PlanCostType PlanCost
        {
            get
            {
                return this.planCostField;
            }
            set
            {
                this.planCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PlanRestriction", IsNullable = false)]
        public PlanRestrictionTypePlanRestriction[] PlanRestrictions
        {
            get
            {
                return this.planRestrictionsField;
            }
            set
            {
                this.planRestrictionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Featured
        {
            get
            {
                return this.featuredField;
            }
            set
            {
                this.featuredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeaturedSpecified
        {
            get
            {
                return this.featuredFieldSpecified;
            }
            set
            {
                this.featuredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this.preferLevelField;
            }
            set
            {
                this.preferLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PreferLevelSpecified
        {
            get
            {
                return this.preferLevelFieldSpecified;
            }
            set
            {
                this.preferLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PlanCode
        {
            get
            {
                return this.planCodeField;
            }
            set
            {
                this.planCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PlanID
        {
            get
            {
                return this.planIDField;
            }
            set
            {
                this.planIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TypeID
        {
            get
            {
                return this.typeIDField;
            }
            set
            {
                this.typeIDField = value;
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