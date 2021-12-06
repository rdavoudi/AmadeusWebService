namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VendorMessagesType
    {

        private VendorMessageType[] vendorMessageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VendorMessage", Order = 0)]
        public VendorMessageType[] VendorMessage
        {
            get
            {
                return this.vendorMessageField;
            }
            set
            {
                this.vendorMessageField = value;
            }
        }
    }
}