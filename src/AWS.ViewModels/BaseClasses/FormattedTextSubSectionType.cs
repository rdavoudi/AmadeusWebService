namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FormattedTextSubSectionType
    {

        private ParagraphType[] paragraphField;

        private string subTitleField;

        private string subCodeField;

        private string subSectionNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Paragraph", Order = 0)]
        public ParagraphType[] Paragraph
        {
            get
            {
                return this.paragraphField;
            }
            set
            {
                this.paragraphField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubTitle
        {
            get
            {
                return this.subTitleField;
            }
            set
            {
                this.subTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubCode
        {
            get
            {
                return this.subCodeField;
            }
            set
            {
                this.subCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string SubSectionNumber
        {
            get
            {
                return this.subSectionNumberField;
            }
            set
            {
                this.subSectionNumberField = value;
            }
        }
    }
}