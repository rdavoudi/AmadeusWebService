namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlanRestrictionTypePlanRestriction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IndCoverageReqsTypePreexistingCondition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FareRuleResponseInfoTypeAdvisoryInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommissionInfoType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CertificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WarningType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ErrorType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FreeTextType
    {

        private string languageField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "language")]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}