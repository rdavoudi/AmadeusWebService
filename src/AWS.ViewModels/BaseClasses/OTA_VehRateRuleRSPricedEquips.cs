namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehRateRuleRSPricedEquips
    {

        private VehicleEquipmentPricedType[] pricedEquipField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PricedEquip", Order = 0)]
        public VehicleEquipmentPricedType[] PricedEquip
        {
            get
            {
                return this.pricedEquipField;
            }
            set
            {
                this.pricedEquipField = value;
            }
        }
    }
}