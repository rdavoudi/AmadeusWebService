namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfSpecialRequestTypeSpecialRequestSpecialRequest : ParagraphType
    {

        private string requestCodeField;

        private string codeContextField;

        private string numberOfUnitsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequestCode
        {
            get
            {
                return this.requestCodeField;
            }
            set
            {
                this.requestCodeField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string NumberOfUnits
        {
            get
            {
                return this.numberOfUnitsField;
            }
            set
            {
                this.numberOfUnitsField = value;
            }
        }
    }
}