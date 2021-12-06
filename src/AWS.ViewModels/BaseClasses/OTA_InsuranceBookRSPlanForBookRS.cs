namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_InsuranceBookRSPlanForBookRS
    {

        private OTA_InsuranceBookRSPlanForBookRSPolicyDetail policyDetailField;

        private CoveredTravelerType[] coveredTravelersField;

        private InsCoverageDetailType insCoverageDetailField;

        private PlanCostType planCostField;

        private ContactPersonType[] contactField;

        private string planIDField;

        private string nameField;

        private string typeField;

        private string typeIDField;

        private string rPHField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_InsuranceBookRSPlanForBookRSPolicyDetail PolicyDetail
        {
            get
            {
                return this.policyDetailField;
            }
            set
            {
                this.policyDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CoveredTraveler", IsNullable = false)]
        public CoveredTravelerType[] CoveredTravelers
        {
            get
            {
                return this.coveredTravelersField;
            }
            set
            {
                this.coveredTravelersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public InsCoverageDetailType InsCoverageDetail
        {
            get
            {
                return this.insCoverageDetailField;
            }
            set
            {
                this.insCoverageDetailField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Contact", Order = 4)]
        public ContactPersonType[] Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
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