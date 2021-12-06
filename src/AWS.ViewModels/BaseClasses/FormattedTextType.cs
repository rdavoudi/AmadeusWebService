namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VendorMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleLocationInformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleLocationAdditionalDetailsTypeShuttleShuttleInfo))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FormattedTextType
    {

        private FormattedTextSubSectionType[] subSectionField;

        private string titleField;

        private string languageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubSection", Order = 0)]
        public FormattedTextSubSectionType[] SubSection
        {
            get
            {
                return this.subSectionField;
            }
            set
            {
                this.subSectionField = value;
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
    }
}