namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ImageItemType
    {

        private string uRLField;

        private string unitOfMeasureCodeField;

        private string widthField;

        private string heightField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI", Order = 0)]
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasureCode
        {
            get
            {
                return this.unitOfMeasureCodeField;
            }
            set
            {
                this.unitOfMeasureCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
    }
}