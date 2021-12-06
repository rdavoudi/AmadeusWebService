namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ImageDescriptionTypeDescription : FormattedTextTextType
    {

        private string captionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }
    }
}