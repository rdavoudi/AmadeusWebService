namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleReservationRQCoreTypeRateDistance
    {

        private bool unlimitedField;

        private string quantityField;

        private DistanceUnitNameType distUnitNameField;

        private bool distUnitNameFieldSpecified;

        private VehiclePeriodUnitNameType vehiclePeriodUnitNameField;

        private bool vehiclePeriodUnitNameFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Unlimited
        {
            get
            {
                return this.unlimitedField;
            }
            set
            {
                this.unlimitedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DistanceUnitNameType DistUnitName
        {
            get
            {
                return this.distUnitNameField;
            }
            set
            {
                this.distUnitNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DistUnitNameSpecified
        {
            get
            {
                return this.distUnitNameFieldSpecified;
            }
            set
            {
                this.distUnitNameFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehiclePeriodUnitNameType VehiclePeriodUnitName
        {
            get
            {
                return this.vehiclePeriodUnitNameField;
            }
            set
            {
                this.vehiclePeriodUnitNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VehiclePeriodUnitNameSpecified
        {
            get
            {
                return this.vehiclePeriodUnitNameFieldSpecified;
            }
            set
            {
                this.vehiclePeriodUnitNameFieldSpecified = value;
            }
        }
    }
}