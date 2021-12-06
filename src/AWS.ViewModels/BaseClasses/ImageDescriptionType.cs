namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ImageDescriptionType
    {

        private ImageDescriptionTypeImageFormat[] imageFormatField;

        private ImageDescriptionTypeDescription[] descriptionField;

        private string categoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ImageFormat", Order = 0)]
        public ImageDescriptionTypeImageFormat[] ImageFormat
        {
            get
            {
                return this.imageFormatField;
            }
            set
            {
                this.imageFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Order = 1)]
        public ImageDescriptionTypeDescription[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }
    }
}