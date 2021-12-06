namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookingToBeCancelled
    {

        private string pNRNoField;

        private string providerTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PNRNo
        {
            get
            {
                return this.pNRNoField;
            }
            set
            {
                this.pNRNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProviderType
        {
            get
            {
                return this.providerTypeField;
            }
            set
            {
                this.providerTypeField = value;
            }
        }
    }
}