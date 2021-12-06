namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FrequentFlyerCardsWithPassengerForSeatMap
    {

        private string surNameField;

        private int segmentNoField;

        private string passengerTypeField;

        private System.Nullable<decimal> seatPriceField;

        private string seatRowNumberField;

        private string seatColumnField;

        private FlayerCardForSeatMap[] flyerCardsField;

        private int itineraryNoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string SurName
        {
            get
            {
                return this.surNameField;
            }
            set
            {
                this.surNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int SegmentNo
        {
            get
            {
                return this.segmentNoField;
            }
            set
            {
                this.segmentNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string PassengerType
        {
            get
            {
                return this.passengerTypeField;
            }
            set
            {
                this.passengerTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<decimal> SeatPrice
        {
            get
            {
                return this.seatPriceField;
            }
            set
            {
                this.seatPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string SeatRowNumber
        {
            get
            {
                return this.seatRowNumberField;
            }
            set
            {
                this.seatRowNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string SeatColumn
        {
            get
            {
                return this.seatColumnField;
            }
            set
            {
                this.seatColumnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 6)]
        public FlayerCardForSeatMap[] FlyerCards
        {
            get
            {
                return this.flyerCardsField;
            }
            set
            {
                this.flyerCardsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public int ItineraryNo
        {
            get
            {
                return this.itineraryNoField;
            }
            set
            {
                this.itineraryNoField = value;
            }
        }
    }
}