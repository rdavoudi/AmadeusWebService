namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehRateRuleRSPricedCoverages
    {

        private CoveragePricedType[] pricedCoverageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PricedCoverage", Order = 0)]
        public CoveragePricedType[] PricedCoverage
        {
            get
            {
                return this.pricedCoverageField;
            }
            set
            {
                this.pricedCoverageField = value;
            }
        }
    }
}