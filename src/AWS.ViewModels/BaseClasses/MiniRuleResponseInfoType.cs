namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class MiniRuleResponseInfoType
    {

        private MiniRules[] miniRuleInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MiniRuleInfo", Order = 0)]
        public MiniRules[] MiniRuleInfo
        {
            get
            {
                return this.miniRuleInfoField;
            }
            set
            {
                this.miniRuleInfoField = value;
            }
        }
    }
}