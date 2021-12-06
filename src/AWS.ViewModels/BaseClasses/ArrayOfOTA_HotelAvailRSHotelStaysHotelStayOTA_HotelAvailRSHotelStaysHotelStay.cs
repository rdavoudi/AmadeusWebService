namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfOTA_HotelAvailRSHotelStaysHotelStayOTA_HotelAvailRSHotelStaysHotelStay
    {

        private ArrayOfOTA_HotelAvailRSHotelStaysHotelStayOTA_HotelAvailRSHotelStaysHotelStayAvailability[] availabilityField;

        private BasicPropertyInfoType basicPropertyInfoField;

        private string[] roomStayRPHField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Availability", Order = 0)]
        public ArrayOfOTA_HotelAvailRSHotelStaysHotelStayOTA_HotelAvailRSHotelStaysHotelStayAvailability[] Availability
        {
            get
            {
                return this.availabilityField;
            }
            set
            {
                this.availabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public BasicPropertyInfoType BasicPropertyInfo
        {
            get
            {
                return this.basicPropertyInfoField;
            }
            set
            {
                this.basicPropertyInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] RoomStayRPH
        {
            get
            {
                return this.roomStayRPHField;
            }
            set
            {
                this.roomStayRPHField = value;
            }
        }
    }
}