namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class MiniRules
    {

        private FlightTermsAndCondition[] termsAndConditionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public FlightTermsAndCondition[] TermsAndCondition
        {
            get
            {
                return this.termsAndConditionField;
            }
            set
            {
                this.termsAndConditionField = value;
            }
        }
    }
}