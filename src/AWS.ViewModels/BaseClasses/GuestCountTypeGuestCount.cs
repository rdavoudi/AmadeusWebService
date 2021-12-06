namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GuestCountTypeGuestCount
    {

        private string ageQualifyingCodeField;

        private string ageField;

        private string countField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgeQualifyingCode
        {
            get
            {
                return this.ageQualifyingCodeField;
            }
            set
            {
                this.ageQualifyingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }
    }
}