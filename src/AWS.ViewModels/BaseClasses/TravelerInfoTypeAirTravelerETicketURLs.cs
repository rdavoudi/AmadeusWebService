namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class TravelerInfoTypeAirTravelerETicketURLs
    {

        private string eTicketURLField;

        private string providerTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ETicketURL
        {
            get
            {
                return this.eTicketURLField;
            }
            set
            {
                this.eTicketURLField = value;
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