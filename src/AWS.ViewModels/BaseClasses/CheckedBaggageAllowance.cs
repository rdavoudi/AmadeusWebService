namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "java:com.thy.websdom.ws.response")]
    public partial class CheckedBaggageAllowance
    {

        private FreeBaggageAllowance1 freeBaggageAllowanceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public FreeBaggageAllowance1 FreeBaggageAllowance
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