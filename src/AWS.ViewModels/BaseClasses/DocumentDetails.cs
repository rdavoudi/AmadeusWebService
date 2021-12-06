namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class DocumentDetails : BaseEntity
    {

        private Document[] documentsField;

        private DocumentHint[] documentHintsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public Document[] Documents
        {
            get
            {
                return this.documentsField;
            }
            set
            {
                this.documentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        public DocumentHint[] DocumentHints
        {
            get
            {
                return this.documentHintsField;
            }
            set
            {
                this.documentHintsField = value;
            }
        }
    }
}