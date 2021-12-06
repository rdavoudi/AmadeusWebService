namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class APISRules
    {

        private APISRuleDocs aPISRuleDocsField;

        private APISRuleDoco aPISRuleDocoField;

        private APISRuleDoca aPISRuleDocaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public APISRuleDocs APISRuleDocs
        {
            get
            {
                return this.aPISRuleDocsField;
            }
            set
            {
                this.aPISRuleDocsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public APISRuleDoco APISRuleDoco
        {
            get
            {
                return this.aPISRuleDocoField;
            }
            set
            {
                this.aPISRuleDocoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public APISRuleDoca APISRuleDoca
        {
            get
            {
                return this.aPISRuleDocaField;
            }
            set
            {
                this.aPISRuleDocaField = value;
            }
        }
    }
}