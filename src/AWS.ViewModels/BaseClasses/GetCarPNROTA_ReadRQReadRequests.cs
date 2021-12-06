namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetCarPNROTA_ReadRQReadRequests
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AirReadRequest", typeof(GetCarPNROTA_ReadRQReadRequestsAirReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CruiseReadRequest", typeof(GetCarPNROTA_ReadRQReadRequestsCruiseReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("GlobalReservationReadRequest", typeof(GetCarPNROTA_ReadRQReadRequestsGlobalReservationReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("GolfReadRequest", typeof(GetCarPNROTA_ReadRQReadRequestsGolfReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("HotelReadRequest", typeof(GetCarPNROTA_ReadRQReadRequestsHotelReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("PkgReadRequest", typeof(GetCarPNROTA_ReadRQReadRequestsPkgReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ReadRequest", typeof(GetCarPNROTA_ReadRQReadRequestsReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("VehicleReadRequest", typeof(GetCarPNROTA_ReadRQReadRequestsVehicleReadRequest), Order = 0)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
}