namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfVideoItemsTypeVideoItem
    {

        private ArrayOfVideoItemsTypeVideoItemVideoItemsTypeVideoItem[] videoItemsTypeVideoItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VideoItemsTypeVideoItem", IsNullable = true, Order = 0)]
        public ArrayOfVideoItemsTypeVideoItemVideoItemsTypeVideoItem[] VideoItemsTypeVideoItem
        {
            get
            {
                return this.videoItemsTypeVideoItemField;
            }
            set
            {
                this.videoItemsTypeVideoItemField = value;
            }
        }
    }
}