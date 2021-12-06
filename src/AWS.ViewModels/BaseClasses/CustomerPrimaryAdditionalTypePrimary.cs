namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CustomerPrimaryAdditionalTypePrimary : CustomerType
    {

        private UniqueID_Type customerIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public UniqueID_Type CustomerID
        {
            get
            {
                return this.customerIDField;
            }
            set
            {
                this.customerIDField = value;
            }
        }
    }
}