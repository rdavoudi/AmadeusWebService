namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CrossBoarderSearchSetting))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PassengerDetails))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentDetails))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommunicationDetails))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AddressDetails))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GenericItem))]
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
    public abstract partial class BaseEntity
    {

        private ValidationError[] validationErrorsField;

        private ValidationError[] selfValidationErrorsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public ValidationError[] ValidationErrors
        {
            get
            {
                return this.validationErrorsField;
            }
            set
            {
                this.validationErrorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        public ValidationError[] SelfValidationErrors
        {
            get
            {
                return this.selfValidationErrorsField;
            }
            set
            {
                this.selfValidationErrorsField = value;
            }
        }
    }
}