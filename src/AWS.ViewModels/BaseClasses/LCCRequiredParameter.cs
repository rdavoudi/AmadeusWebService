namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class LCCRequiredParameter
    {

        private bool enabledField;

        private bool mandatoryField;

        private string infoField;

        private bool perPassengerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public bool Mandatory
        {
            get
            {
                return this.mandatoryField;
            }
            set
            {
                this.mandatoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public bool PerPassenger
        {
            get
            {
                return this.perPassengerField;
            }
            set
            {
                this.perPassengerField = value;
            }
        }
    }
}