namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_InsuranceBookRQPlanForBookRQ))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class InsCoverageType
    {

        private CoveredTravelerType[] coveredTravelersField;

        private InsCoverageDetailType insCoverageDetailField;

        private string planCodeField;

        private string planIDField;

        private string nameField;

        private string typeField;

        private string typeIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
    }
}