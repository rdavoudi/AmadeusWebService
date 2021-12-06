namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class TicketingInfoRS_Type : TicketingInfoType
    {

        private string eTicketNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string eTicketNumber
        {
            get
            {
                return this.eTicketNumberField;
            }
            set
            {
                this.eTicketNumberField = value;
            }
        }
    }
}