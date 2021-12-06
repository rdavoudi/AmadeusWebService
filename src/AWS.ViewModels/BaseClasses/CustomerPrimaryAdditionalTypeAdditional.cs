namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CustomerPrimaryAdditionalTypeAdditional : CustomerType
    {

        private string startField;

        private string durationField;

        private string endField;

        private string corpDiscountNameField;

        private string corpDiscountNmbrField;

        private CustomerPrimaryAdditionalTypeAdditionalQualificationMethod qualificationMethodField;

        private bool qualificationMethodFieldSpecified;

        private string ageField;

        private string codeField;

        private string codeContextField;

        private string uRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CorpDiscountName
        {
            get
            {
                return this.corpDiscountNameField;
            }
            set
            {
                this.corpDiscountNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CorpDiscountNmbr
        {
            get
            {
                return this.corpDiscountNmbrField;
            }
            set
            {
                this.corpDiscountNmbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CustomerPrimaryAdditionalTypeAdditionalQualificationMethod QualificationMethod
        {
            get
            {
                return this.qualificationMethodField;
            }
            set
            {
                this.qualificationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QualificationMethodSpecified
        {
            get
            {
                return this.qualificationMethodFieldSpecified;
            }
            set
            {
                this.qualificationMethodFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
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
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeContext
        {
            get
            {
                return this.codeContextField;
            }
            set
            {
                this.codeContextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
    }
}