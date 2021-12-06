namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OffLocationServicePricedType
    {

        private OffLocationServiceType offLocServiceField;

        private VehicleChargeType chargeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OffLocationServiceType OffLocService
        {
            get
            {
                return this.offLocServiceField;
            }
            set
            {
                this.offLocServiceField = value;
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
    }
}