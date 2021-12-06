namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RowDetailsTypeAirSeat
    {

        private AncillaryServiceFeeType[] serviceFeesField;

        private string seatAvailabilityField;

        private string seatNumberField;

        private string seatPriceField;

        private string seatPriceCurrencyField;

        private string[] seatCharacteristicsField;

        private string airBookDesigCodeField;

        private string rPHField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ServiceFee", IsNullable = false)]
        public AncillaryServiceFeeType[] ServiceFees
        {
            get
            {
                return this.serviceFeesField;
            }
            set
            {
                this.serviceFeesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatAvailability
        {
            get
            {
                return this.seatAvailabilityField;
            }
            set
            {
                this.seatAvailabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatNumber
        {
            get
            {
                return this.seatNumberField;
            }
            set
            {
                this.seatNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatPrice
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatPriceCurrency
        {
            get
            {
                return this.seatPriceCurrencyField;
            }
            set
            {
                this.seatPriceCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] SeatCharacteristics
        {
            get
            {
                return this.seatCharacteristicsField;
            }
            set
            {
                this.seatCharacteristicsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirBookDesigCode
        {
            get
            {
                return this.airBookDesigCodeField;
            }
            set
            {
                this.airBookDesigCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }
    }
}