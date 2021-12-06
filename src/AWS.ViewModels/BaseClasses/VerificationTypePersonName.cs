namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VerificationTypePersonName : PersonNameType
    {

        private bool partialNameField;

        private bool partialNameFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PartialName
        {
            get
            {
                return this.partialNameField;
            }
            set
            {
                this.partialNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PartialNameSpecified
        {
            get
            {
                return this.partialNameFieldSpecified;
            }
            set
            {
                this.partialNameFieldSpecified = value;
            }
        }
    }
}