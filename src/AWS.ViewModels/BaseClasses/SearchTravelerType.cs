namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchTravelerType
    {

        private AddressInfoType addressField;

        private SearchTravelerTypeCitizenCountryName citizenCountryNameField;

        private IndCoverageReqsType indCoverageReqsField;

        private PassengerTypeQuantityType passengerTypeField;

        private System.DateTime birthDateField;

        private bool birthDateFieldSpecified;

        private string ageField;

        private string relationField;

        private string genderField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public SearchTravelerTypeCitizenCountryName CitizenCountryName
        {
            get
            {
                return this.citizenCountryNameField;
            }
            set
            {
                this.citizenCountryNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public IndCoverageReqsType IndCoverageReqs
        {
            get
            {
                return this.indCoverageReqsField;
            }
            set
            {
                this.indCoverageReqsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public PassengerTypeQuantityType PassengerType
        {
            get
            {
                return this.passengerTypeField;
            }
            set
            {
                this.passengerTypeField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
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
        public string Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }
    }
}