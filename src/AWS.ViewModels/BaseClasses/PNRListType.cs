namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PNRListType
    {

        private PNRListItemType[] pNRListItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PNRListItem", Order = 0)]
        public PNRListItemType[] PNRListItem
        {
            get
            {
                return this.pNRListItemField;
            }
            set
            {
                this.pNRListItemField = value;
            }
        }
    }
}