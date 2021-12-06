namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ParagraphType
    {

        private object[] itemsField;

        private string nameField;

        private string paragraphNumberField;

        private System.DateTime createDateTimeField;

        private bool createDateTimeFieldSpecified;

        private string creatorIDField;

        private System.DateTime lastModifyDateTimeField;

        private bool lastModifyDateTimeFieldSpecified;

        private string lastModifierIDField;

        private System.DateTime purgeDateField;

        private bool purgeDateFieldSpecified;

        private string languageField;

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Image", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ListItem", typeof(ParagraphTypeListItem), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Text", typeof(FormattedTextTextType), Order = 0)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string ParagraphNumber
        {
            get
            {
                return this.paragraphNumberField;
            }
            set
            {
                this.paragraphNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime CreateDateTime
        {
            get
            {
                return this.createDateTimeField;
            }
            set
            {
                this.createDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreateDateTimeSpecified
        {
            get
            {
                return this.createDateTimeFieldSpecified;
            }
            set
            {
                this.createDateTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CreatorID
        {
            get
            {
                return this.creatorIDField;
            }
            set
            {
                this.creatorIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastModifyDateTime
        {
            get
            {
                return this.lastModifyDateTimeField;
            }
            set
            {
                this.lastModifyDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastModifyDateTimeSpecified
        {
            get
            {
                return this.lastModifyDateTimeFieldSpecified;
            }
            set
            {
                this.lastModifyDateTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LastModifierID
        {
            get
            {
                return this.lastModifierIDField;
            }
            set
            {
                this.lastModifierIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime PurgeDate
        {
            get
            {
                return this.purgeDateField;
            }
            set
            {
                this.purgeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PurgeDateSpecified
        {
            get
            {
                return this.purgeDateFieldSpecified;
            }
            set
            {
                this.purgeDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "language")]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
}