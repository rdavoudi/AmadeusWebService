namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class TransportInfoType
    {

        private TransportInfoTypeTransportInfo transportInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TransportInfoTypeTransportInfo TransportInfo
        {
            get
            {
                return this.transportInfoField;
            }
            set
            {
                this.transportInfoField = value;
            }
        }
    }
}