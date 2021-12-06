namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class APISRulesRQ
    {

        private int recommendationIDField;

        private int combinationIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int RecommendationID
        {
            get
            {
                return this.recommendationIDField;
            }
            set
            {
                this.recommendationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int CombinationID
        {
            get
            {
                return this.combinationIDField;
            }
            set
            {
                this.combinationIDField = value;
            }
        }
    }
}