namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VideoDescriptionType
    {

        private VideoDescriptionTypeVideoFormat[] videoFormatField;

        private string categoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VideoFormat", Order = 0)]
        public VideoDescriptionTypeVideoFormat[] VideoFormat
        {
            get
            {
                return this.videoFormatField;
            }
            set
            {
                this.videoFormatField = value;
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