namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PenaltyMiniRule
    {

        private string reissueRuleField;

        private string refundRuleField;

        private ChangePenalty[] changePenaltyListField;

        private CancellationPenalty[] cancellationPenaltyListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public string ReissueRule
        {
            get
            {
                return this.reissueRuleField;
            }
            set
            {
                this.reissueRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public string RefundRule
        {
            get
            {
                return this.refundRuleField;
            }
            set
            {
                this.refundRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true, Order = 2)]
        public ChangePenalty[] ChangePenaltyList
        {
            get
            {
                return this.changePenaltyListField;
            }
            set
            {
                this.changePenaltyListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true, Order = 3)]
        public CancellationPenalty[] CancellationPenaltyList
        {
            get
            {
                return this.cancellationPenaltyListField;
            }
            set
            {
                this.cancellationPenaltyListField = value;
            }
        }
    }
}