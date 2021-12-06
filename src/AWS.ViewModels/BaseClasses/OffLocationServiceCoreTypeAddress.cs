namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OffLocationServiceCoreTypeAddress : AddressType
    {

        private string siteIDField;

        private string siteNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SiteID
        {
            get
            {
                return this.siteIDField;
            }
            set
            {
                this.siteIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SiteName
        {
            get
            {
                return this.siteNameField;
            }
            set
            {
                this.siteNameField = value;
            }
        }
    }
}