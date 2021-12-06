namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Organization))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Corporate))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Person))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PassengerDB))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(User))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class Entity : DBBaseEntity
    {

        private System.Nullable<int> travelPolicySetIDField;

        private string travelPolicySetNameField;

        private string taxOfficeField;

        private string taxNoField;

        private AddressDetails addressDetailsField;

        private CommunicationDetails communicationDetailsField;

        private DocumentDetails documentDetailsField;

        private string clientReferenceField;

        private string costNumberField;

        private string currentAccountCodeField;

        private string eMailFooterField;

        private string eMailHeaderField;

        private bool isUpdatableUserField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<int> TravelPolicySetID
        {
            get
            {
                return this.travelPolicySetIDField;
            }
            set
            {
                this.travelPolicySetIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string TravelPolicySetName
        {
            get
            {
                return this.travelPolicySetNameField;
            }
            set
            {
                this.travelPolicySetNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string TaxOffice
        {
            get
            {
                return this.taxOfficeField;
            }
            set
            {
                this.taxOfficeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string TaxNo
        {
            get
            {
                return this.taxNoField;
            }
            set
            {
                this.taxNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public AddressDetails AddressDetails
        {
            get
            {
                return this.addressDetailsField;
            }
            set
            {
                this.addressDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public CommunicationDetails CommunicationDetails
        {
            get
            {
                return this.communicationDetailsField;
            }
            set
            {
                this.communicationDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public DocumentDetails DocumentDetails
        {
            get
            {
                return this.documentDetailsField;
            }
            set
            {
                this.documentDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string ClientReference
        {
            get
            {
                return this.clientReferenceField;
            }
            set
            {
                this.clientReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string CostNumber
        {
            get
            {
                return this.costNumberField;
            }
            set
            {
                this.costNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string CurrentAccountCode
        {
            get
            {
                return this.currentAccountCodeField;
            }
            set
            {
                this.currentAccountCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string EMailFooter
        {
            get
            {
                return this.eMailFooterField;
            }
            set
            {
                this.eMailFooterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string EMailHeader
        {
            get
            {
                return this.eMailHeaderField;
            }
            set
            {
                this.eMailHeaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public bool IsUpdatableUser
        {
            get
            {
                return this.isUpdatableUserField;
            }
            set
            {
                this.isUpdatableUserField = value;
            }
        }
    }
}