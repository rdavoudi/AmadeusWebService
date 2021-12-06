namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetPNROTA_ReadRQReadRequests
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AirReadRequest", typeof(GetPNROTA_ReadRQReadRequestsAirReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CruiseReadRequest", typeof(GetPNROTA_ReadRQReadRequestsCruiseReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("GlobalReservationReadRequest", typeof(GetPNROTA_ReadRQReadRequestsGlobalReservationReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("GolfReadRequest", typeof(GetPNROTA_ReadRQReadRequestsGolfReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("HotelReadRequest", typeof(GetPNROTA_ReadRQReadRequestsHotelReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("PkgReadRequest", typeof(GetPNROTA_ReadRQReadRequestsPkgReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ReadRequest", typeof(GetPNROTA_ReadRQReadRequestsReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("VehicleReadRequest", typeof(GetPNROTA_ReadRQReadRequestsVehicleReadRequest), Order = 0)]
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