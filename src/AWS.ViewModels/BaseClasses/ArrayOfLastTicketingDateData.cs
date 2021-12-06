namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfLastTicketingDateData
    {

        private ArrayOfLastTicketingDateDataLastTicketingDateData[] lastTicketingDateDataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LastTicketingDateData", IsNullable = true, Order = 0)]
        public ArrayOfLastTicketingDateDataLastTicketingDateData[] LastTicketingDateData
        {
            get
            {
                return this.lastTicketingDateDataField;
            }
            set
            {
                this.lastTicketingDateDataField = value;
            }
        }
    }
}