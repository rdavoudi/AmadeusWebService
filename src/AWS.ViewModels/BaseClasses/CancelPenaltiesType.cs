namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CancelPenaltiesType
    {

        private CancelPenaltyType[] cancelPenaltyField;

        private bool cancelPolicyIndicatorField;

        private bool cancelPolicyIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CancelPenalty", Order = 0)]
        public CancelPenaltyType[] CancelPenalty
        {
            get
            {
                return this.cancelPenaltyField;
            }
            set
            {
                this.cancelPenaltyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CancelPolicyIndicator
        {
            get
            {
                return this.cancelPolicyIndicatorField;
            }
            set
            {
                this.cancelPolicyIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CancelPolicyIndicatorSpecified
        {
            get
            {
                return this.cancelPolicyIndicatorFieldSpecified;
            }
            set
            {
                this.cancelPolicyIndicatorFieldSpecified = value;
            }
        }
    }
}