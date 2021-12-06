namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class MultimediaDescriptionType
    {

        private object itemField;

        private string infoCodeField;

        private string additionalDetailCodeField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ImageItems", typeof(ArrayOfImageItemsTypeImageItem), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("TextItems", typeof(ArrayOfTextItemsTypeTextItem), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("VideoItems", typeof(ArrayOfVideoItemsTypeVideoItem), Order = 0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InfoCode
        {
            get
            {
                return this.infoCodeField;
            }
            set
            {
                this.infoCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdditionalDetailCode
        {
            get
            {
                return this.additionalDetailCodeField;
            }
            set
            {
                this.additionalDetailCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}