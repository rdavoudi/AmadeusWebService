namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightWithRecommendationOTA_AirBookRQ : GenericFlightRQ
    {

        private BrandCodeType brandCodeField;

        private PNRRemarkInfo[] pNRRemarksField;

        private AirItineraryPricingInfoType airItineraryPricingInfoField;

        private SourceType[] pOSField;

        private AirItineraryType airItineraryField;

        private BookFlightWithRecommendationOTA_AirBookRQPriceInfo priceInfoField;

        private TravelerInfoType travelerInfoField;

        private BookFlightWithRecommendationOTA_AirBookRQFulfillment fulfillmentField;

        private BookFlightWithRecommendationOTA_AirBookRQTicketing[] ticketingField;

        private BookFlightWithRecommendationOTA_AirBookRQQueue queueField;

        private UniqueID_Type bookingReferenceIDField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private InsurancePlan insurancePlanField;

        private RelatedMember relatedMemberField;

        private string referenceNumberField;

        private string controlNumberField;

        private string corporatePinNumberField;

        private string corporateFareCodeField;

        private string echoTokenField;

        private System.DateTime timeStampField;

        private bool timeStampFieldSpecified;

        private BookFlightWithRecommendationOTA_AirBookRQTarget targetField;

        private decimal versionField;

        private string transactionIdentifierField;

        private string sequenceNmbrField;

        private BookFlightWithRecommendationOTA_AirBookRQTransactionStatusCode transactionStatusCodeField;

        private bool transactionStatusCodeFieldSpecified;

        private bool retransmissionIndicatorField;

        private bool retransmissionIndicatorFieldSpecified;

        private TransactionActionType resStatusField;

        private bool resStatusFieldSpecified;

        private bool priceIndField;

        private bool priceIndFieldSpecified;

        public BookFlightWithRecommendationOTA_AirBookRQ()
        {
            this.targetField = BookFlightWithRecommendationOTA_AirBookRQTarget.Production;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public BrandCodeType BrandCode
        {
            get
            {
                return this.brandCodeField;
            }
            set
            {
                this.brandCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public AirItineraryPricingInfoType AirItineraryPricingInfo
        {
            get
            {
                return this.airItineraryPricingInfoField;
            }
            set
            {
                this.airItineraryPricingInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Source", IsNullable = false)]
        public SourceType[] POS
        {
            get
            {
                return this.pOSField;
            }
            set
            {
                this.pOSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public AirItineraryType AirItinerary
        {
            get
            {
                return this.airItineraryField;
            }
            set
            {
                this.airItineraryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public BookFlightWithRecommendationOTA_AirBookRQPriceInfo PriceInfo
        {
            get
            {
                return this.priceInfoField;
            }
            set
            {
                this.priceInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public BookFlightWithRecommendationOTA_AirBookRQFulfillment Fulfillment
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
        [System.Xml.Serialization.XmlElementAttribute("Ticketing", Order = 8)]
        public BookFlightWithRecommendationOTA_AirBookRQTicketing[] Ticketing
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public BookFlightWithRecommendationOTA_AirBookRQQueue Queue
        {
            get
            {
                return this.queueField;
            }
            set
            {
                this.queueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public UniqueID_Type BookingReferenceID
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public InsurancePlan InsurancePlan
        {
            get
            {
                return this.insurancePlanField;
            }
            set
            {
                this.insurancePlanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public RelatedMember RelatedMember
        {
            get
            {
                return this.relatedMemberField;
            }
            set
            {
                this.relatedMemberField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CorporateFareCode
        {
            get
            {
                return this.corporateFareCodeField;
            }
            set
            {
                this.corporateFareCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EchoToken
        {
            get
            {
                return this.echoTokenField;
            }
            set
            {
                this.echoTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this.timeStampField;
            }
            set
            {
                this.timeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeStampSpecified
        {
            get
            {
                return this.timeStampFieldSpecified;
            }
            set
            {
                this.timeStampFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(BookFlightWithRecommendationOTA_AirBookRQTarget.Production)]
        public BookFlightWithRecommendationOTA_AirBookRQTarget Target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransactionIdentifier
        {
            get
            {
                return this.transactionIdentifierField;
            }
            set
            {
                this.transactionIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string SequenceNmbr
        {
            get
            {
                return this.sequenceNmbrField;
            }
            set
            {
                this.sequenceNmbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public BookFlightWithRecommendationOTA_AirBookRQTransactionStatusCode TransactionStatusCode
        {
            get
            {
                return this.transactionStatusCodeField;
            }
            set
            {
                this.transactionStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionStatusCodeSpecified
        {
            get
            {
                return this.transactionStatusCodeFieldSpecified;
            }
            set
            {
                this.transactionStatusCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RetransmissionIndicator
        {
            get
            {
                return this.retransmissionIndicatorField;
            }
            set
            {
                this.retransmissionIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RetransmissionIndicatorSpecified
        {
            get
            {
                return this.retransmissionIndicatorFieldSpecified;
            }
            set
            {
                this.retransmissionIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransactionActionType ResStatus
        {
            get
            {
                return this.resStatusField;
            }
            set
            {
                this.resStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResStatusSpecified
        {
            get
            {
                return this.resStatusFieldSpecified;
            }
            set
            {
                this.resStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PriceInd
        {
            get
            {
                return this.priceIndField;
            }
            set
            {
                this.priceIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceIndSpecified
        {
            get
            {
                return this.priceIndFieldSpecified;
            }
            set
            {
                this.priceIndFieldSpecified = value;
            }
        }
    }
}