namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfOTA_HotelAvailRSHotelStaysHotelStay
    {

        private ArrayOfOTA_HotelAvailRSHotelStaysHotelStayOTA_HotelAvailRSHotelStaysHotelStay[] oTA_HotelAvailRSHotelStaysHotelStayField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OTA_HotelAvailRSHotelStaysHotelStay", IsNullable = true, Order = 0)]
        public ArrayOfOTA_HotelAvailRSHotelStaysHotelStayOTA_HotelAvailRSHotelStaysHotelStay[] OTA_HotelAvailRSHotelStaysHotelStay
        {
            get
            {
                return this.oTA_HotelAvailRSHotelStaysHotelStayField;
            }
            set
            {
                this.oTA_HotelAvailRSHotelStaysHotelStayField = value;
            }
        }
    }
}