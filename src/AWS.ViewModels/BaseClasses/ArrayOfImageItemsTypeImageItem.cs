namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfImageItemsTypeImageItem
    {

        private ArrayOfImageItemsTypeImageItemImageItemsTypeImageItem[] imageItemsTypeImageItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ImageItemsTypeImageItem", IsNullable = true, Order = 0)]
        public ArrayOfImageItemsTypeImageItemImageItemsTypeImageItem[] ImageItemsTypeImageItem
        {
            get
            {
                return this.imageItemsTypeImageItemField;
            }
            set
            {
                this.imageItemsTypeImageItemField = value;
            }
        }
    }
}