namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ValidationError
    {

        private string relatedEntityPropertyNameField;

        private ValidationErrorCodes errorCodeField;

        private ValidationErrorTypes errorTypeField;

        private ValidationErrorCategories errorCategoryField;

        private string errorMessageField;

        private string[] messageValueListField;

        private string messageValueField;

        private string mainMessageField;

        private LocalizationTypes localizationTypeField;

        private LocalizationInnerTypes localizationInnerTypeField;

        private string errorFieldField;

        private string gotoPageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string RelatedEntityPropertyName
        {
            get
            {
                return this.relatedEntityPropertyNameField;
            }
            set
            {
                this.relatedEntityPropertyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ValidationErrorCodes ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ValidationErrorTypes ErrorType
        {
            get
            {
                return this.errorTypeField;
            }
            set
            {
                this.errorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public ValidationErrorCategories ErrorCategory
        {
            get
            {
                return this.errorCategoryField;
            }
            set
            {
                this.errorCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string ErrorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        public string[] MessageValueList
        {
            get
            {
                return this.messageValueListField;
            }
            set
            {
                this.messageValueListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string MessageValue
        {
            get
            {
                return this.messageValueField;
            }
            set
            {
                this.messageValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string MainMessage
        {
            get
            {
                return this.mainMessageField;
            }
            set
            {
                this.mainMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public LocalizationTypes LocalizationType
        {
            get
            {
                return this.localizationTypeField;
            }
            set
            {
                this.localizationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public LocalizationInnerTypes LocalizationInnerType
        {
            get
            {
                return this.localizationInnerTypeField;
            }
            set
            {
                this.localizationInnerTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string ErrorField
        {
            get
            {
                return this.errorFieldField;
            }
            set
            {
                this.errorFieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string GotoPage
        {
            get
            {
                return this.gotoPageField;
            }
            set
            {
                this.gotoPageField = value;
            }
        }
    }
}