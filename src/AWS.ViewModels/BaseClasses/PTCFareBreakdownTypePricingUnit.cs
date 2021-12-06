namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PTCFareBreakdownTypePricingUnit
    {

        private PTCFareBreakdownTypePricingUnitFareComponent[] fareComponentField;

        private string unitNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FareComponent", Order = 0)]
        public PTCFareBreakdownTypePricingUnitFareComponent[] FareComponent
        {
            get
            {
                return this.fareComponentField;
            }
            set
            {
                this.fareComponentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string UnitNumber
        {
            get
            {
                return this.unitNumberField;
            }
            set
            {
                this.unitNumberField = value;
            }
        }
    }
}