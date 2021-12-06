namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class WarningsType
    {

        private WarningType[] warningField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Warning", Order = 0)]
        public WarningType[] Warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }
    }
}