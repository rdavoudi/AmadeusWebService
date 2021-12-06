namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class Communication : DBBaseEntity
    {

        private System.Nullable<System.Guid> entityIDField;

        private string communicationMediaCodeField;

        private string valueTextField;

        private string phoneCountryCodeField;

        private string phoneAreaCodeField;

        private string phoneNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<System.Guid> EntityID
        {
            get
            {
                return this.entityIDField;
            }
            set
            {
                this.entityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string CommunicationMediaCode
        {
            get
            {
                return this.communicationMediaCodeField;
            }
            set
            {
                this.communicationMediaCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ValueText
        {
            get
            {
                return this.valueTextField;
            }
            set
            {
                this.valueTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string PhoneCountryCode
        {
            get
            {
                return this.phoneCountryCodeField;
            }
            set
            {
                this.phoneCountryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string PhoneAreaCode
        {
            get
            {
                return this.phoneAreaCodeField;
            }
            set
            {
                this.phoneAreaCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumberField;
            }
            set
            {
                this.phoneNumberField = value;
            }
        }
    }
}