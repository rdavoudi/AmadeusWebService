namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BookingFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HotelExtraFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CarExtraFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsuranceExtraFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeliveryFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AirlineOBFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AncillaryFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CCOBFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherExtraCostType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CouponFeeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ServiceFeeType
    {

        private PassengerTypeQuantityType passengerTypeQuantityField;

        private decimal amountField;

        private decimal surChargeAmountField;

        private bool surChargeAmountFieldSpecified;

        private decimal externalServiceFeeField;

        private bool externalServiceFeeFieldSpecified;

        private int itineraryIndexField;

        private bool itineraryIndexFieldSpecified;

        private bool totalForAllPaxField;

        private bool totalForAllPaxFieldSpecified;

        private decimal markupFeeAmountField;

        private bool markupFeeAmountFieldSpecified;

        private decimal extraSeatAmountField;

        private bool extraSeatAmountFieldSpecified;

        private decimal cabinBaggageAmountField;

        private bool cabinBaggageAmountFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PassengerTypeQuantityType PassengerTypeQuantity
        {
            get
            {
                return this.passengerTypeQuantityField;
            }
            set
            {
                this.passengerTypeQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SurChargeAmount
        {
            get
            {
                return this.surChargeAmountField;
            }
            set
            {
                this.surChargeAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SurChargeAmountSpecified
        {
            get
            {
                return this.surChargeAmountFieldSpecified;
            }
            set
            {
                this.surChargeAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ExternalServiceFee
        {
            get
            {
                return this.externalServiceFeeField;
            }
            set
            {
                this.externalServiceFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExternalServiceFeeSpecified
        {
            get
            {
                return this.externalServiceFeeFieldSpecified;
            }
            set
            {
                this.externalServiceFeeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ItineraryIndex
        {
            get
            {
                return this.itineraryIndexField;
            }
            set
            {
                this.itineraryIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItineraryIndexSpecified
        {
            get
            {
                return this.itineraryIndexFieldSpecified;
            }
            set
            {
                this.itineraryIndexFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TotalForAllPax
        {
            get
            {
                return this.totalForAllPaxField;
            }
            set
            {
                this.totalForAllPaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalForAllPaxSpecified
        {
            get
            {
                return this.totalForAllPaxFieldSpecified;
            }
            set
            {
                this.totalForAllPaxFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MarkupFeeAmount
        {
            get
            {
                return this.markupFeeAmountField;
            }
            set
            {
                this.markupFeeAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MarkupFeeAmountSpecified
        {
            get
            {
                return this.markupFeeAmountFieldSpecified;
            }
            set
            {
                this.markupFeeAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ExtraSeatAmount
        {
            get
            {
                return this.extraSeatAmountField;
            }
            set
            {
                this.extraSeatAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExtraSeatAmountSpecified
        {
            get
            {
                return this.extraSeatAmountFieldSpecified;
            }
            set
            {
                this.extraSeatAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal CabinBaggageAmount
        {
            get
            {
                return this.cabinBaggageAmountField;
            }
            set
            {
                this.cabinBaggageAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CabinBaggageAmountSpecified
        {
            get
            {
                return this.cabinBaggageAmountFieldSpecified;
            }
            set
            {
                this.cabinBaggageAmountFieldSpecified = value;
            }
        }
    }
}