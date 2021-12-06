namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CoveredTravelerTypeCoveredPerson : PersonNameType
    {

        private string relationField;

        private System.DateTime birthDateField;

        private bool birthDateFieldSpecified;

        private string ageField;

        private string passengerTypeCodeField;

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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PassengerTypeCode
        {
            get
            {
                return this.passengerTypeCodeField;
            }
            set
            {
                this.passengerTypeCodeField = value;
            }
        }
    }
}