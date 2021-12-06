namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PriceInfoRQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaggageInfoRQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AncillaryInfoRQ))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ServiceFeeInfoRQ : GenericFlightRQ
    {

        private ServiceFeeInfoRQFlightInfo flightInfoField;

        private ServiceFeeInfoRQHotelInfo hotelInfoField;

        private ServiceFeeInfoRQCarInfo carInfoField;

        private ServiceFeeInfoRQInsuranceInfo insuranceInfoField;

        private string typeField;

        private string couponCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ServiceFeeInfoRQFlightInfo FlightInfo
        {
            get
            {
                return this.flightInfoField;
            }
            set
            {
                this.flightInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ServiceFeeInfoRQHotelInfo HotelInfo
        {
            get
            {
                return this.hotelInfoField;
            }
            set
            {
                this.hotelInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ServiceFeeInfoRQCarInfo CarInfo
        {
            get
            {
                return this.carInfoField;
            }
            set
            {
                this.carInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public ServiceFeeInfoRQInsuranceInfo InsuranceInfo
        {
            get
            {
                return this.insuranceInfoField;
            }
            set
            {
                this.insuranceInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CouponCode
        {
            get
            {
                return this.couponCodeField;
            }
            set
            {
                this.couponCodeField = value;
            }
        }
    }
}