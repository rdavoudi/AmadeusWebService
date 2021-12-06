namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CarryOnBaggageAllowance
    {

        private FreeBaggageAllowance freeBaggageAllowanceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public FreeBaggageAllowance FreeBaggageAllowance
        {
            get
            {
                return this.freeBaggageAllowanceField;
            }
            set
            {
                this.freeBaggageAllowanceField = value;
            }
        }
    }
}