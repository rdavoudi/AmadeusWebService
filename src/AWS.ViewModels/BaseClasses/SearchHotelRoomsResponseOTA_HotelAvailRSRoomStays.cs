namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchHotelRoomsResponseOTA_HotelAvailRSRoomStays
    {

        private SearchHotelRoomsResponseOTA_HotelAvailRSRoomStaysRoomStay[] roomStayField;

        private string moreIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoomStay", Order = 0)]
        public SearchHotelRoomsResponseOTA_HotelAvailRSRoomStaysRoomStay[] RoomStay
        {
            get
            {
                return this.roomStayField;
            }
            set
            {
                this.roomStayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MoreIndicator
        {
            get
            {
                return this.moreIndicatorField;
            }
            set
            {
                this.moreIndicatorField = value;
            }
        }
    }
}