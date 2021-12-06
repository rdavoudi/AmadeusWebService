namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookBookBasketRQ
    {

        private BookBookBasketRQFlightReservation flightReservationField;

        private BookBookBasketRQHotelReservation hotelReservationField;

        private BookBookBasketRQCarReservation carReservationField;

        private BookBookBasketRQInsuranceReservation insuranceReservationField;

        private TravelerInfoType travelerInfoField;

        private BookBookBasketRQFulfillment fulfillmentField;

        private TicketingInfoType[] ticketingField;

        private PNRRemarkInfo[] pNRRemarksField;

        private string referenceNumberField;

        private string controlNumberField;

        private string corporatePinNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public BookBookBasketRQFlightReservation FlightReservation
        {
            get
            {
                return this.flightReservationField;
            }
            set
            {
                this.flightReservationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public BookBookBasketRQHotelReservation HotelReservation
        {
            get
            {
                return this.hotelReservationField;
            }
            set
            {
                this.hotelReservationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public BookBookBasketRQCarReservation CarReservation
        {
            get
            {
                return this.carReservationField;
            }
            set
            {
                this.carReservationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public BookBookBasketRQInsuranceReservation InsuranceReservation
        {
            get
            {
                return this.insuranceReservationField;
            }
            set
            {
                this.insuranceReservationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TravelerInfoType TravelerInfo
        {
            get
            {
                return this.travelerInfoField;
            }
            set
            {
                this.travelerInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public BookBookBasketRQFulfillment Fulfillment
        {
            get
            {
                return this.fulfillmentField;
            }
            set
            {
                this.fulfillmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Ticketing", Order = 6)]
        public TicketingInfoType[] Ticketing
        {
            get
            {
                return this.ticketingField;
            }
            set
            {
                this.ticketingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PNRRemark")]
        public PNRRemarkInfo[] PNRRemarks
        {
            get
            {
                return this.pNRRemarksField;
            }
            set
            {
                this.pNRRemarksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceNumber
        {
            get
            {
                return this.referenceNumberField;
            }
            set
            {
                this.referenceNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ControlNumber
        {
            get
            {
                return this.controlNumberField;
            }
            set
            {
                this.controlNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CorporatePinNumber
        {
            get
            {
                return this.corporatePinNumberField;
            }
            set
            {
                this.corporatePinNumberField = value;
            }
        }
    }
}