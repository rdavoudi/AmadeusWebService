namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleEquipmentPricedType
    {

        private VehicleEquipmentType equipmentField;

        private VehicleChargeType chargeField;

        private bool requiredField;

        public VehicleEquipmentPricedType()
        {
            this.requiredField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public VehicleEquipmentType Equipment
        {
            get
            {
                return this.equipmentField;
            }
            set
            {
                this.equipmentField = value;
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