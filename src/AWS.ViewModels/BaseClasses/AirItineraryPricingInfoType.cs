namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BookingPriceInfoType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirItineraryPricingInfoType
    {

        private FareType itinTotalFareField;

        private decimal minCCOBFeeField;

        private bool minCCOBFeeFieldSpecified;

        private decimal maxCCOBFeeField;

        private bool maxCCOBFeeFieldSpecified;

        private decimal cCOBFeeField;

        private bool cCOBFeeFieldSpecified;

        private PTCFareBreakdownType[] pTC_FareBreakdownsField;

        private ArrayOfAirItineraryPricingInfoTypeFareInfoFareInfo[] fareInfosField;

        private ServiceFeesType serviceFeesField;

        private int iTIndexField;

        private bool iTIndexFieldSpecified;

        private PricingSourceType pricingSourceField;

        private bool pricingSourceFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public FareType ItinTotalFare
        {
            get
            {
                return this.itinTotalFareField;
            }
            set
            {
                this.itinTotalFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public decimal MinCCOBFee
        {
            get
            {
                return this.minCCOBFeeField;
            }
            set
            {
                this.minCCOBFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinCCOBFeeSpecified
        {
            get
            {
                return this.minCCOBFeeFieldSpecified;
            }
            set
            {
                this.minCCOBFeeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public decimal MaxCCOBFee
        {
            get
            {
                return this.maxCCOBFeeField;
            }
            set
            {
                this.maxCCOBFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxCCOBFeeSpecified
        {
            get
            {
                return this.maxCCOBFeeFieldSpecified;
            }
            set
            {
                this.maxCCOBFeeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public decimal CCOBFee
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CCOBFeeSpecified
        {
            get
            {
                return this.cCOBFeeFieldSpecified;
            }
            set
            {
                this.cCOBFeeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PTC_FareBreakdown", IsNullable = false)]
        public PTCFareBreakdownType[] PTC_FareBreakdowns
        {
            get
            {
                return this.pTC_FareBreakdownsField;
            }
            set
            {
                this.pTC_FareBreakdownsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("FareInfo", IsNullable = false)]
        public ArrayOfAirItineraryPricingInfoTypeFareInfoFareInfo[] FareInfos
        {
            get
            {
                return this.fareInfosField;
            }
            set
            {
                this.fareInfosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public ServiceFeesType ServiceFees
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
        public int ITIndex
        {
            get
            {
                return this.iTIndexField;
            }
            set
            {
                this.iTIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ITIndexSpecified
        {
            get
            {
                return this.iTIndexFieldSpecified;
            }
            set
            {
                this.iTIndexFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PricingSourceType PricingSource
        {
            get
            {
                return this.pricingSourceField;
            }
            set
            {
                this.pricingSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PricingSourceSpecified
        {
            get
            {
                return this.pricingSourceFieldSpecified;
            }
            set
            {
                this.pricingSourceFieldSpecified = value;
            }
        }
    }
}