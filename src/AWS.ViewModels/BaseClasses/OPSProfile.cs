namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OPSProfile
    {

        private string nGP_IDField;

        private string cSX_IDField;

        private System.Nullable<System.DateTime> createdIntegrationDateField;

        private System.Nullable<System.DateTime> readIntegrationDateField;

        private System.Nullable<System.DateTime> updateIntegrationDateField;

        private bool changedPersonelField;

        private bool changedContactInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string NGP_ID
        {
            get
            {
                return this.nGP_IDField;
            }
            set
            {
                this.nGP_IDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string CSX_ID
        {
            get
            {
                return this.cSX_IDField;
            }
            set
            {
                this.cSX_IDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> CreatedIntegrationDate
        {
            get
            {
                return this.createdIntegrationDateField;
            }
            set
            {
                this.createdIntegrationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> ReadIntegrationDate
        {
            get
            {
                return this.readIntegrationDateField;
            }
            set
            {
                this.readIntegrationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<System.DateTime> UpdateIntegrationDate
        {
            get
            {
                return this.updateIntegrationDateField;
            }
            set
            {
                this.updateIntegrationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public bool ChangedPersonel
        {
            get
            {
                return this.changedPersonelField;
            }
            set
            {
                this.changedPersonelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public bool ChangedContactInfo
        {
            get
            {
                return this.changedContactInfoField;
            }
            set
            {
                this.changedContactInfoField = value;
            }
        }
    }
}