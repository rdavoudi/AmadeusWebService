using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AWS.ViewModels
{
    /// <remarks/>
    [XmlIncludeAttribute(typeof(CrossBoarderSearchSetting))]
    [XmlIncludeAttribute(typeof(PassengerDetails))]
    [XmlIncludeAttribute(typeof(DocumentDetails))]
    [XmlIncludeAttribute(typeof(CommunicationDetails))]
    [XmlIncludeAttribute(typeof(AddressDetails))]
    [XmlIncludeAttribute(typeof(GenericItem))]
    [XmlIncludeAttribute(typeof(NameValueItem))]
    [XmlIncludeAttribute(typeof(NameValueTypeItem))]
    [XmlIncludeAttribute(typeof(DBBaseEntity))]
    [XmlIncludeAttribute(typeof(PassengerSpecialRequest))]
    [XmlIncludeAttribute(typeof(PassengerFlyerCard))]
    [XmlIncludeAttribute(typeof(DocumentHint))]
    [XmlIncludeAttribute(typeof(Document))]
    [XmlIncludeAttribute(typeof(CommunicationHint))]
    [XmlIncludeAttribute(typeof(Communication))]
    [XmlIncludeAttribute(typeof(AddressHint))]
    [XmlIncludeAttribute(typeof(AddressDB))]
    [XmlIncludeAttribute(typeof(Entity))]
    [XmlIncludeAttribute(typeof(Organization))]
    [XmlIncludeAttribute(typeof(Corporate))]
    [XmlIncludeAttribute(typeof(Person))]
    [XmlIncludeAttribute(typeof(PassengerDB))]
    [XmlIncludeAttribute(typeof(User))]
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public abstract partial class BaseEntity
    {
        private ValidationError[] validationErrorsField;
        private ValidationError[] selfValidationErrorsField;
        /// <remarks/>
        [XmlArrayAttribute(Order = 0)]
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
        [XmlArrayAttribute(Order = 1)]
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
