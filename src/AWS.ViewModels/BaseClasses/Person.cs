namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PassengerDB))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(User))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class Person : Entity
    {

        private string firstNameField;

        private string secondaryNameField;

        private string secondarySurnameNameField;

        private string surNameField;

        private string titleField;

        private string genderCodeField;

        private System.Nullable<System.DateTime> birthDateField;

        private string educationField;

        private string occupationField;

        private string maritalStatusField;

        private string citizenShipField;

        private string motherMaidenNameField;

        private string languageSpokenField;

        private string birthCountryField;

        private string birthCityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string SecondaryName
        {
            get
            {
                return this.secondaryNameField;
            }
            set
            {
                this.secondaryNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string SecondarySurnameName
        {
            get
            {
                return this.secondarySurnameNameField;
            }
            set
            {
                this.secondarySurnameNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string SurName
        {
            get
            {
                return this.surNameField;
            }
            set
            {
                this.surNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string GenderCode
        {
            get
            {
                return this.genderCodeField;
            }
            set
            {
                this.genderCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> BirthDate
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string Education
        {
            get
            {
                return this.educationField;
            }
            set
            {
                this.educationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string Occupation
        {
            get
            {
                return this.occupationField;
            }
            set
            {
                this.occupationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string MaritalStatus
        {
            get
            {
                return this.maritalStatusField;
            }
            set
            {
                this.maritalStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string CitizenShip
        {
            get
            {
                return this.citizenShipField;
            }
            set
            {
                this.citizenShipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string MotherMaidenName
        {
            get
            {
                return this.motherMaidenNameField;
            }
            set
            {
                this.motherMaidenNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string LanguageSpoken
        {
            get
            {
                return this.languageSpokenField;
            }
            set
            {
                this.languageSpokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string BirthCountry
        {
            get
            {
                return this.birthCountryField;
            }
            set
            {
                this.birthCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string BirthCity
        {
            get
            {
                return this.birthCityField;
            }
            set
            {
                this.birthCityField = value;
            }
        }
    }
}