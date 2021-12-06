namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CoveragePricedType
    {

        private CoverageType coverageField;

        private VehicleChargeType chargeField;

        private bool requiredField;

        public CoveragePricedType()
        {
            this.requiredField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CoverageType Coverage
        {
            get
            {
                return this.coverageField;
            }
            set
            {
                this.coverageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public VehicleChargeType Charge
        {
            get
            {
                return this.chargeField;
            }
            set
            {
                this.chargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Required
        {
            get
            {
                return this.requiredField;
            }
            set
            {
                this.requiredField = value;
            }
        }
    }
}