namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OtherExtraCostType : BookingFeeType
    {

        private string costTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CostType
        {
            get
            {
                return this.costTypeField;
            }
            set
            {
                this.costTypeField = value;
            }
        }
    }
}