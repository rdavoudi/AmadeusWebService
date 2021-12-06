namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(User))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PassengerDB : Person
    {

        private PassengerDetails passengerDetailsField;

        private string typeCodeField;

        private System.Nullable<System.Guid> userIDField;

        private string formOfIdentificationField;

        private string formOfIdentificationTypeField;

        private string formOfIdentificationCreditCardTypeField;

        private System.Nullable<System.DateTime> formOfIdentificationExpirationDateField;

        private string formOfIdentificationIssueLocationField;

        private string identityNoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PassengerDetails PassengerDetails
        {
            get
            {
                return this.passengerDetailsField;
            }
            set
            {
                this.passengerDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.Guid> UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string FormOfIdentification
        {
            get
            {
                return this.formOfIdentificationField;
            }
            set
            {
                this.formOfIdentificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string FormOfIdentificationType
        {
            get
            {
                return this.formOfIdentificationTypeField;
            }
            set
            {
                this.formOfIdentificationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string FormOfIdentificationCreditCardType
        {
            get
            {
                return this.formOfIdentificationCreditCardTypeField;
            }
            set
            {
                this.formOfIdentificationCreditCardTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> FormOfIdentificationExpirationDate
        {
            get
            {
                return this.formOfIdentificationExpirationDateField;
            }
            set
            {
                this.formOfIdentificationExpirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string FormOfIdentificationIssueLocation
        {
            get
            {
                return this.formOfIdentificationIssueLocationField;
            }
            set
            {
                this.formOfIdentificationIssueLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string IdentityNo
        {
            get
            {
                return this.identityNoField;
            }
            set
            {
                this.identityNoField = value;
            }
        }
    }
}