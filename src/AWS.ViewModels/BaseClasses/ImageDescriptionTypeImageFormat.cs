namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ImageDescriptionTypeImageFormat : ImageItemType
    {

        private string contentIDField;

        private string titleField;

        private string authorField;

        private string copyrightNoticeField;

        private string copyrightOwnerField;

        private string copyrightStartField;

        private string copyrightEndField;

        private string effectiveStartField;

        private string effectiveEndField;

        private string applicableStartField;

        private string applicableEndField;

        private string recordIDField;

        private string sourceIDField;

        private string languageField;

        private string formatField;

        private string fileNameField;

        private string fileSizeField;

        private string dimensionCategoryField;

        private bool isOriginalIndicatorField;

        private bool isOriginalIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContentID
        {
            get
            {
                return this.contentIDField;
            }
            set
            {
                this.contentIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CopyrightNotice
        {
            get
            {
                return this.copyrightNoticeField;
            }
            set
            {
                this.copyrightNoticeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CopyrightOwner
        {
            get
            {
                return this.copyrightOwnerField;
            }
            set
            {
                this.copyrightOwnerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CopyrightStart
        {
            get
            {
                return this.copyrightStartField;
            }
            set
            {
                this.copyrightStartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CopyrightEnd
        {
            get
            {
                return this.copyrightEndField;
            }
            set
            {
                this.copyrightEndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EffectiveStart
        {
            get
            {
                return this.effectiveStartField;
            }
            set
            {
                this.effectiveStartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EffectiveEnd
        {
            get
            {
                return this.effectiveEndField;
            }
            set
            {
                this.effectiveEndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ApplicableStart
        {
            get
            {
                return this.applicableStartField;
            }
            set
            {
                this.applicableStartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ApplicableEnd
        {
            get
            {
                return this.applicableEndField;
            }
            set
            {
                this.applicableEndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RecordID
        {
            get
            {
                return this.recordIDField;
            }
            set
            {
                this.recordIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SourceID
        {
            get
            {
                return this.sourceIDField;
            }
            set
            {
                this.sourceIDField = value;
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
        public string Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string FileSize
        {
            get
            {
                return this.fileSizeField;
            }
            set
            {
                this.fileSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DimensionCategory
        {
            get
            {
                return this.dimensionCategoryField;
            }
            set
            {
                this.dimensionCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsOriginalIndicator
        {
            get
            {
                return this.isOriginalIndicatorField;
            }
            set
            {
                this.isOriginalIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsOriginalIndicatorSpecified
        {
            get
            {
                return this.isOriginalIndicatorFieldSpecified;
            }
            set
            {
                this.isOriginalIndicatorFieldSpecified = value;
            }
        }
    }
}