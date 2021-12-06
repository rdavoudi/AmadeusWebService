namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PriceMessageInfoType
    {

        private MiniRulesPriceMessages[] priceMessageInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public MiniRulesPriceMessages[] PriceMessageInfo
        {
            get
            {
                return this.priceMessageInfoField;
            }
            set
            {
                this.priceMessageInfoField = value;
            }
        }
    }
}