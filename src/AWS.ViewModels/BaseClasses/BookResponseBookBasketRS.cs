namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookResponseBookBasketRS
    {

        private BookResponseBookBasketRSAirReservation airReservationField;

        private OTA_InsuranceBookRSPlanForBookRS insuranceReservationField;

        private OTA_HotelResRS hotelReservationField;

        private OTA_VehResRS carReservationField;

        private TravelerInfoType travelerInfoField;

        private BookResponseBookBasketRSFullFilment fullFilmentField;

        private object[] itemsField;

        private UniqueID_Type[] bookingReferenceIDField;

        private AirItineraryPricingInfoType newPriceField;

        private FailbackRS failbackField;

        private bool cancelField;

        private string referenceNumberField;

        public BookResponseBookBasketRS()
        {
            this.cancelField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public BookResponseBookBasketRSAirReservation AirReservation
        {
            get
            {
                return this.airReservationField;
            }
            set
            {
                this.airReservationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_InsuranceBookRSPlanForBookRS InsuranceReservation
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public OTA_HotelResRS HotelReservation
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public OTA_VehResRS CarReservation
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
        public BookResponseBookBasketRSFullFilment FullFilment
        {
            get
            {
                return this.fullFilmentField;
            }
            set
            {
                this.fullFilmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Errors", typeof(ErrorsType), Order = 6)]
        [System.Xml.Serialization.XmlElementAttribute("Success", typeof(SuccessType), Order = 6)]
        [System.Xml.Serialization.XmlElementAttribute("Warnings", typeof(WarningsType), Order = 6)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BookingReferenceID", Order = 7)]
        public UniqueID_Type[] BookingReferenceID
        {
            get
            {
                return this.bookingReferenceIDField;
            }
            set
            {
                this.bookingReferenceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public AirItineraryPricingInfoType NewPrice
        {
            get
            {
                return this.newPriceField;
            }
            set
            {
                this.newPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public FailbackRS Failback
        {
            get
            {
                return this.failbackField;
            }
            set
            {
                this.failbackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Cancel
        {
            get
            {
                return this.cancelField;
            }
            set
            {
                this.cancelField = value;
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
    }
}