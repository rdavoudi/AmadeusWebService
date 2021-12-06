namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CommunicationDetails : BaseEntity
    {

        private Communication[] communicationsField;

        private CommunicationHint[] communicationHintField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public Communication[] Communications
        {
            get
            {
                return this.communicationsField;
            }
            set
            {
                this.communicationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        public CommunicationHint[] CommunicationHint
        {
            get
            {
                return this.communicationHintField;
            }
            set
            {
                this.communicationHintField = value;
            }
        }
    }
}