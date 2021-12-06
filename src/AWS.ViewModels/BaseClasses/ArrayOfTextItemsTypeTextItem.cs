namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfTextItemsTypeTextItem
    {

        private ArrayOfTextItemsTypeTextItemTextItemsTypeTextItem[] textItemsTypeTextItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TextItemsTypeTextItem", IsNullable = true, Order = 0)]
        public ArrayOfTextItemsTypeTextItemTextItemsTypeTextItem[] TextItemsTypeTextItem
        {
            get
            {
                return this.textItemsTypeTextItemField;
            }
            set
            {
                this.textItemsTypeTextItemField = value;
            }
        }
    }
}