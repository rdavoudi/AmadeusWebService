namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfTextItemsTypeTextItemTextItemsTypeTextItem : TextDescriptionType
    {

        private System.DateTime createDateTimeField;

        private bool createDateTimeFieldSpecified;

        private string creatorIDField;

        private System.DateTime lastModifyDateTimeField;

        private bool lastModifyDateTimeFieldSpecified;

        private string lastModifierIDField;

        private System.DateTime purgeDateField;

        private bool purgeDateFieldSpecified;

        private bool removalField;

        private string versionField;

        public ArrayOfTextItemsTypeTextItemTextItemsTypeTextItem()
        {
            this.removalField = false;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Removal
        {
            get
            {
                return this.removalField;
            }
            set
            {
                this.removalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }
}