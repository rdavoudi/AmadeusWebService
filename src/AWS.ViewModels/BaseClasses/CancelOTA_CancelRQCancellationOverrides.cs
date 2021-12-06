namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CancelOTA_CancelRQCancellationOverrides
    {

        private CancelRuleType cancellationOverrideField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CancelRuleType CancellationOverride
        {
            get
            {
                return this.cancellationOverrideField;
            }
            set
            {
                this.cancellationOverrideField = value;
            }
        }
    }
}