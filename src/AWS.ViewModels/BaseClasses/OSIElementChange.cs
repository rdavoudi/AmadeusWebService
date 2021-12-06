namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OSIElementChange
    {

        private PersonNameType personNameField;

        private string oSIMessageField;

        private ChangeDetailActionTypes changeDetailActionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PersonNameType PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string OSIMessage
        {
            get
            {
                return this.oSIMessageField;
            }
            set
            {
                this.oSIMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ChangeDetailActionTypes ChangeDetailAction
        {
            get
            {
                return this.changeDetailActionField;
            }
            set
            {
                this.changeDetailActionField = value;
            }
        }
    }
}