namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfSpecialRemarkTypeAuthorizedViewerAuthorizedViewer
    {

        private string viewerCodeField;

        private string viewerCarrierCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ViewerCode
        {
            get
            {
                return this.viewerCodeField;
            }
            set
            {
                this.viewerCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ViewerCarrierCode
        {
            get
            {
                return this.viewerCarrierCodeField;
            }
            set
            {
                this.viewerCarrierCodeField = value;
            }
        }
    }
}