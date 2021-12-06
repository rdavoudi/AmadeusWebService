namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PassengerSpecialRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PassengerFlyerCard))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentHint))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Document))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommunicationHint))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Communication))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AddressHint))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AddressDB))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Entity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Organization))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Corporate))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Person))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PassengerDB))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(User))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class DBBaseEntity : GenericItem
    {

        private string updatedByField;

        private System.Nullable<System.DateTime> updatedDateField;

        private string insertedByField;

        private System.Nullable<System.DateTime> insertedDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string UpdatedBy
        {
            get
            {
                return this.updatedByField;
            }
            set
            {
                this.updatedByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<System.DateTime> UpdatedDate
        {
            get
            {
                return this.updatedDateField;
            }
            set
            {
                this.updatedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string InsertedBy
        {
            get
            {
                return this.insertedByField;
            }
            set
            {
                this.insertedByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> InsertedDate
        {
            get
            {
                return this.insertedDateField;
            }
            set
            {
                this.insertedDateField = value;
            }
        }
    }
}