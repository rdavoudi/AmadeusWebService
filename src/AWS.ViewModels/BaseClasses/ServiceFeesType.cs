namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ServiceFeesType
    {

        private ServiceFeeType[] serviceFeeField;

        private BookingFeeType bookingFeeField;

        private HotelExtraFeeType hotelExtraFeeField;

        private CarExtraFeeType carExtraFeeField;

        private InsuranceExtraFeeType insuranceExtraFeeField;

        private DeliveryFeeType deliveryFeeField;

        private PaymentFeeType paymentFeeField;

        private AirlineOBFeeType airlineOBFeeField;

        private AncillaryFeeType ancillaryFeeField;

        private CCOBFeeType cCOBFeeField;

        private OtherExtraCostType[] otherExtraCostField;

        private CouponFeeType couponFeeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceFee", Order = 0)]
        public ServiceFeeType[] ServiceFee
        {
            get
            {
                return this.serviceFeeField;
            }
            set
            {
                this.serviceFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public BookingFeeType BookingFee
        {
            get
            {
                return this.bookingFeeField;
            }
            set
            {
                this.bookingFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public HotelExtraFeeType HotelExtraFee
        {
            get
            {
                return this.hotelExtraFeeField;
            }
            set
            {
                this.hotelExtraFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CarExtraFeeType CarExtraFee
        {
            get
            {
                return this.carExtraFeeField;
            }
            set
            {
                this.carExtraFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public InsuranceExtraFeeType InsuranceExtraFee
        {
            get
            {
                return this.insuranceExtraFeeField;
            }
            set
            {
                this.insuranceExtraFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public DeliveryFeeType DeliveryFee
        {
            get
            {
                return this.deliveryFeeField;
            }
            set
            {
                this.deliveryFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public PaymentFeeType PaymentFee
        {
            get
            {
                return this.paymentFeeField;
            }
            set
            {
                this.paymentFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public AirlineOBFeeType AirlineOBFee
        {
            get
            {
                return this.airlineOBFeeField;
            }
            set
            {
                this.airlineOBFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public AncillaryFeeType AncillaryFee
        {
            get
            {
                return this.ancillaryFeeField;
            }
            set
            {
                this.ancillaryFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public CCOBFeeType CCOBFee
        {
            get
            {
                return this.cCOBFeeField;
            }
            set
            {
                this.cCOBFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherExtraCost", Order = 10)]
        public OtherExtraCostType[] OtherExtraCost
        {
            get
            {
                return this.otherExtraCostField;
            }
            set
            {
                this.otherExtraCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public CouponFeeType CouponFee
        {
            get
            {
                return this.couponFeeField;
            }
            set
            {
                this.couponFeeField = value;
            }
        }
    }
}