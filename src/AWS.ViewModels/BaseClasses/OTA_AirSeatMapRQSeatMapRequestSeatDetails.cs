namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_AirSeatMapRQSeatMapRequestSeatDetails
    {

        private OTA_AirSeatMapRQSeatMapRequestSeatDetailsCabinClass[] cabinClassField;

        private OTA_AirSeatMapRQSeatMapRequestSeatDetailsResBookDesignation[] resBookDesignationsField;

        private bool seatUpgradeField;

        public OTA_AirSeatMapRQSeatMapRequestSeatDetails()
        {
            this.seatUpgradeField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CabinClass", Order = 0)]
        public OTA_AirSeatMapRQSeatMapRequestSeatDetailsCabinClass[] CabinClass
        {
            get
            {
                return this.cabinClassField;
            }
            set
            {
                this.cabinClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ResBookDesignation", IsNullable = false)]
        public OTA_AirSeatMapRQSeatMapRequestSeatDetailsResBookDesignation[] ResBookDesignations
        {
            get
            {
                return this.resBookDesignationsField;
            }
            set
            {
                this.resBookDesignationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SeatUpgrade
        {
            get
            {
                return this.seatUpgradeField;
            }
            set
            {
                this.seatUpgradeField = value;
            }
        }
    }
}