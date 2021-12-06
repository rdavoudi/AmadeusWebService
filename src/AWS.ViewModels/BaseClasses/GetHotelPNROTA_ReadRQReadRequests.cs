namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetHotelPNROTA_ReadRQReadRequests
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AirReadRequest", typeof(GetHotelPNROTA_ReadRQReadRequestsAirReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CruiseReadRequest", typeof(GetHotelPNROTA_ReadRQReadRequestsCruiseReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("GlobalReservationReadRequest", typeof(GetHotelPNROTA_ReadRQReadRequestsGlobalReservationReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("GolfReadRequest", typeof(GetHotelPNROTA_ReadRQReadRequestsGolfReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("HotelReadRequest", typeof(GetHotelPNROTA_ReadRQReadRequestsHotelReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("PkgReadRequest", typeof(GetHotelPNROTA_ReadRQReadRequestsPkgReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ReadRequest", typeof(GetHotelPNROTA_ReadRQReadRequestsReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("VehicleReadRequest", typeof(GetHotelPNROTA_ReadRQReadRequestsVehicleReadRequest), Order = 0)]
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