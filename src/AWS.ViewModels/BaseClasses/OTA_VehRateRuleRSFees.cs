namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehRateRuleRSFees
    {

        private VehicleChargePurposeType[] feeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Fee", Order = 0)]
        public VehicleChargePurposeType[] Fee
        {
            get
            {
                return this.feeField;
            }
            set
            {
                this.feeField = value;
            }
        }
    }
}