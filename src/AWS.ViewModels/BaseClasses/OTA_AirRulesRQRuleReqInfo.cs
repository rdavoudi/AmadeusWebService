namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_AirRulesRQRuleReqInfo : FareInfoType
    {

        private OTA_AirRulesRQRuleReqInfoSubSection[] subSectionField;

        private string languageRequestedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubSection", Order = 0)]
        public OTA_AirRulesRQRuleReqInfoSubSection[] SubSection
        {
            get
            {
                return this.subSectionField;
            }
            set
            {
                this.subSectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LanguageRequested
        {
            get
            {
                return this.languageRequestedField;
            }
            set
            {
                this.languageRequestedField = value;
            }
        }
    }
}