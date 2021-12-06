namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehAvailVendorRQ
    {

        private int vendorIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int VendorID
        {
            get
            {
                return this.vendorIDField;
            }
            set
            {
                this.vendorIDField = value;
            }
        }
    }
}