namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ExecuteCommandAmadeusAPICommandRQ
    {

        private string commandField;

        private string serverField;

        private string portNumberField;

        private string corporateIdField;

        private string userIdField;

        private string passwordField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Command
        {
            get
            {
                return this.commandField;
            }
            set
            {
                this.commandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Server
        {
            get
            {
                return this.serverField;
            }
            set
            {
                this.serverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PortNumber
        {
            get
            {
                return this.portNumberField;
            }
            set
            {
                this.portNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CorporateId
        {
            get
            {
                return this.corporateIdField;
            }
            set
            {
                this.corporateIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }
}