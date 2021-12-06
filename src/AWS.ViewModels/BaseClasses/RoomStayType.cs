namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RoomStayType
    {

        private RoomTypeType[] roomTypesField;

        private RatePlanType[] ratePlansField;

        private RoomStayTypeRoomRates roomRatesField;

        private GuestCountType guestCountsField;

        private DateTimeSpanType timeSpanField;

        private GuaranteeType[] guaranteeField;

        private ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePayment[] depositPaymentsField;

        private CancelPenaltiesType cancelPenaltiesField;

        private DiscountType discountField;

        private TotalType totalField;

        private BasicPropertyInfoType basicPropertyInfoField;

        private ServiceFeesType serviceFeesField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private string marketCodeField;

        private string sourceOfBusinessField;

        private string discountCodeField;

        private string promotionCodeField;

        private string[] promotionVendorCodeField;

        private string roomStayStatusField;

        private string[] warningRPHField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomType", IsNullable = false)]
        public RoomTypeType[] RoomTypes
        {
            get
            {
                return this.roomTypesField;
            }
            set
            {
                this.roomTypesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RatePlan", IsNullable = false)]
        public RatePlanType[] RatePlans
        {
            get
            {
                return this.ratePlansField;
            }
            set
            {
                this.ratePlansField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public RoomStayTypeRoomRates RoomRates
        {
            get
            {
                return this.roomRatesField;
            }
            set
            {
                this.roomRatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public GuestCountType GuestCounts
        {
            get
            {
                return this.guestCountsField;
            }
            set
            {
                this.guestCountsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public DateTimeSpanType TimeSpan
        {
            get
            {
                return this.timeSpanField;
            }
            set
            {
                this.timeSpanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Guarantee", Order = 5)]
        public GuaranteeType[] Guarantee
        {
            get
            {
                return this.guaranteeField;
            }
            set
            {
                this.guaranteeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 6)]
        [System.Xml.Serialization.XmlArrayItemAttribute("GuaranteePayment", IsNullable = false)]
        public ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePayment[] DepositPayments
        {
            get
            {
                return this.depositPaymentsField;
            }
            set
            {
                this.depositPaymentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public CancelPenaltiesType CancelPenalties
        {
            get
            {
                return this.cancelPenaltiesField;
            }
            set
            {
                this.cancelPenaltiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public DiscountType Discount
        {
            get
            {
                return this.discountField;
            }
            set
            {
                this.discountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public TotalType Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public BasicPropertyInfoType BasicPropertyInfo
        {
            get
            {
                return this.basicPropertyInfoField;
            }
            set
            {
                this.basicPropertyInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MarketCode
        {
            get
            {
                return this.marketCodeField;
            }
            set
            {
                this.marketCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SourceOfBusiness
        {
            get
            {
                return this.sourceOfBusinessField;
            }
            set
            {
                this.sourceOfBusinessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DiscountCode
        {
            get
            {
                return this.discountCodeField;
            }
            set
            {
                this.discountCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PromotionCode
        {
            get
            {
                return this.promotionCodeField;
            }
            set
            {
                this.promotionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] PromotionVendorCode
        {
            get
            {
                return this.promotionVendorCodeField;
            }
            set
            {
                this.promotionVendorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomStayStatus
        {
            get
            {
                return this.roomStayStatusField;
            }
            set
            {
                this.roomStayStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] WarningRPH
        {
            get
            {
                return this.warningRPHField;
            }
            set
            {
                this.warningRPHField = value;
            }
        }
    }
}