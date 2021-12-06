namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CustomerPrimaryAdditionalType
    {

        private CustomerPrimaryAdditionalTypePrimary primaryField;

        private CustomerPrimaryAdditionalTypeAdditional[] additionalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CustomerPrimaryAdditionalTypePrimary Primary
        {
            get
            {
                return this.primaryField;
            }
            set
            {
                this.primaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Additional", Order = 1)]
        public CustomerPrimaryAdditionalTypeAdditional[] Additional
        {
            get
            {
                return this.additionalField;
            }
            set
            {
                this.additionalField = value;
            }
        }
    }
}