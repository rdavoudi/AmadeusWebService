namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AncillaryTicketRemarkType
    {

        private string remarkTypeCodeField;

        private string remarkTypeField;

        private string remarkField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string RemarkTypeCode
        {
            get
            {
                return this.remarkTypeCodeField;
            }
            set
            {
                this.remarkTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string RemarkType
        {
            get
            {
                return this.remarkTypeField;
            }
            set
            {
                this.remarkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Remark
        {
            get
            {
                return this.remarkField;
            }
            set
            {
                this.remarkField = value;
            }
        }
    }
}