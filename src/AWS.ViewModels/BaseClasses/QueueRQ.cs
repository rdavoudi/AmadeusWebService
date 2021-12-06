namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class QueueRQ
    {

        private string queueNumberField;

        private string categoryNumberField;

        private string pNRNoField;

        private string officeIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string QueueNumber
        {
            get
            {
                return this.queueNumberField;
            }
            set
            {
                this.queueNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string CategoryNumber
        {
            get
            {
                return this.categoryNumberField;
            }
            set
            {
                this.categoryNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string OfficeId
        {
            get
            {
                return this.officeIdField;
            }
            set
            {
                this.officeIdField = value;
            }
        }
    }
}