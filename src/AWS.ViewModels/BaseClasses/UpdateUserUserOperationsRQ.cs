namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class UpdateUserUserOperationsRQ
    {

        private string cultureCodeField;

        private User userField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string CultureCode
        {
            get
            {
                return this.cultureCodeField;
            }
            set
            {
                this.cultureCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public User User
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }
    }
}