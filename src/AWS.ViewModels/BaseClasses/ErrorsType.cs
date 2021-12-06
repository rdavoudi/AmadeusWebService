namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ErrorsType
    {

        private ErrorType[] errorField;

        private string myPropertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Error", Order = 0)]
        public ErrorType[] Error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string MyProperty
        {
            get
            {
                return this.myPropertyField;
            }
            set
            {
                this.myPropertyField = value;
            }
        }
    }
}