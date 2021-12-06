namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParagraphTypeListItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RateQualifierTypeRateComment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoverageDetailsType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FormattedTextTextType
    {

        private bool formattedField;

        private bool formattedFieldSpecified;

        private string languageField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Formatted
        {
            get
            {
                return this.formattedField;
            }
            set
            {
                this.formattedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FormattedSpecified
        {
            get
            {
                return this.formattedFieldSpecified;
            }
            set
            {
                this.formattedFieldSpecified = value;
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
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}