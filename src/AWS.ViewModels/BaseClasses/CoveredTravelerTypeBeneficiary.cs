namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CoveredTravelerTypeBeneficiary
    {

        private CoveredTravelerTypeBeneficiaryName nameField;

        private AddressInfoType addressField;

        private string relationField;

        private decimal benefitPercentField;

        private bool benefitPercentFieldSpecified;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CoveredTravelerTypeBeneficiaryName Name
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AddressInfoType Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Relation
        {
            get
            {
                return this.relationField;
            }
            set
            {
                this.relationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal BenefitPercent
        {
            get
            {
                return this.benefitPercentField;
            }
            set
            {
                this.benefitPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BenefitPercentSpecified
        {
            get
            {
                return this.benefitPercentFieldSpecified;
            }
            set
            {
                this.benefitPercentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}