namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirReservationType
    {

        private OSIelement[] oSIElementsField;

        private AirItineraryType airItineraryField;

        private BookingPriceInfoType priceInfoField;

        private TravelerInfoType travelerInfoField;

        private AirReservationTypeFulfillment fulfillmentField;

        private GroupInfoType groupInfoField;

        private TicketingInfoType[] ticketingField;

        private ArrayOfAirReservationTypeQueueQueue[] queuesField;

        private UniqueID_Type[] bookingReferenceIDField;

        private FareRuleResponseInfoType[] flightRulePenaltiesField;

        private MiniRules[] flightMiniRulesField;

        private PriceMessageInfoType priceMessageInfoField;

        private FormattedTextTextType commentField;

        private AirReservationTypePricingOverview pricingOverviewField;

        private PNRRemarkInfo[] pNRRemarksField;

        private string lastModifiedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public OSIelement[] OSIElements
        {
            get
            {
                return this.oSIElementsField;
            }
            set
            {
                this.oSIElementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public BookingPriceInfoType PriceInfo
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public AirReservationTypeFulfillment Fulfillment
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public GroupInfoType GroupInfo
        {
            get
            {
                return this.groupInfoField;
            }
            set
            {
                this.groupInfoField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Queue", IsNullable = false)]
        public ArrayOfAirReservationTypeQueueQueue[] Queues
        {
            get
            {
                return this.queuesField;
            }
            set
            {
                this.queuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BookingReferenceID", Order = 8)]
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
        [System.Xml.Serialization.XmlElementAttribute("FlightRulePenalties", Order = 9)]
        public FareRuleResponseInfoType[] FlightRulePenalties
        {
            get
            {
                return this.flightRulePenaltiesField;
            }
            set
            {
                this.flightRulePenaltiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 10)]
        [System.Xml.Serialization.XmlArrayItemAttribute("MiniRuleInfo", IsNullable = false)]
        public MiniRules[] FlightMiniRules
        {
            get
            {
                return this.flightMiniRulesField;
            }
            set
            {
                this.flightMiniRulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public PriceMessageInfoType PriceMessageInfo
        {
            get
            {
                return this.priceMessageInfoField;
            }
            set
            {
                this.priceMessageInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public FormattedTextTextType Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public AirReservationTypePricingOverview PricingOverview
        {
            get
            {
                return this.pricingOverviewField;
            }
            set
            {
                this.pricingOverviewField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 14)]
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
        public string LastModified
        {
            get
            {
                return this.lastModifiedField;
            }
            set
            {
                this.lastModifiedField = value;
            }
        }
    }
}