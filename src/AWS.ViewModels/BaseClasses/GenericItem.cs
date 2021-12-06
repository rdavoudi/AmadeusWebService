namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NameValueItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NameValueTypeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DBBaseEntity))]
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
    public partial class GenericItem : BaseEntity
    {

        private System.Nullable<bool> isDeletedField;

        private System.Nullable<System.Guid> idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<bool> IsDeleted
        {
            get
            {
                return this.isDeletedField;
            }
            set
            {
                this.isDeletedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<System.Guid> ID
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