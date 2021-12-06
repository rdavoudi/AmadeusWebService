namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookBookBasketRQHotelReservation
    {

        private int hotelIDField;

        private int roomIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int HotelID
        {
            get
            {
                return this.hotelIDField;
            }
            set
            {
                this.hotelIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int RoomID
        {
            get
            {
                return this.roomIDField;
            }
            set
            {
                this.roomIDField = value;
            }
        }
    }
}