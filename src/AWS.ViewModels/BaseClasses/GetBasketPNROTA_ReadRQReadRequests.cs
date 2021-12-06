namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetBasketPNROTA_ReadRQReadRequests
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AirReadRequest", typeof(GetBasketPNROTA_ReadRQReadRequestsAirReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CruiseReadRequest", typeof(GetBasketPNROTA_ReadRQReadRequestsCruiseReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("GlobalReservationReadRequest", typeof(GetBasketPNROTA_ReadRQReadRequestsGlobalReservationReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("GolfReadRequest", typeof(GetBasketPNROTA_ReadRQReadRequestsGolfReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("HotelReadRequest", typeof(GetBasketPNROTA_ReadRQReadRequestsHotelReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("PkgReadRequest", typeof(GetBasketPNROTA_ReadRQReadRequestsPkgReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ReadRequest", typeof(GetBasketPNROTA_ReadRQReadRequestsReadRequest), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("VehicleReadRequest", typeof(GetBasketPNROTA_ReadRQReadRequestsVehicleReadRequest), Order = 0)]
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