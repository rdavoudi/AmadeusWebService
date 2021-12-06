namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleReservationRQCoreTypeSpecialEquipPrefs
    {

        private VehicleReservationRQCoreTypeSpecialEquipPrefsSpecialEquipPref[] specialEquipPrefField;

        private VehicleChargeType chargeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialEquipPref", Order = 0)]
        public VehicleReservationRQCoreTypeSpecialEquipPrefsSpecialEquipPref[] SpecialEquipPref
        {
            get
            {
                return this.specialEquipPrefField;
            }
            set
            {
                this.specialEquipPrefField = value;
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