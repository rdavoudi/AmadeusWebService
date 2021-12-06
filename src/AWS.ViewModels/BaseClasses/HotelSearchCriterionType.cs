namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class HotelSearchCriterionType : ItemSearchCriterionType
    {

        private HotelSearchCriterionTypeHotelAmenity[] hotelAmenityField;

        private RoomAmenityPrefType[] roomAmenityField;

        private HotelSearchCriterionTypeAward[] awardField;

        private HotelSearchCriterionTypeRecreation[] recreationField;

        private HotelSearchCriterionTypeService[] serviceField;

        private HotelSearchCriterionTypeTransportation[] transportationField;

        private DateTimeSpanType stayDateRangeField;

        private HotelSearchCriterionTypeRateRange[] rateRangeField;

        private ArrayOfRatePlanCandidatesTypeRatePlanCandidateRatePlanCandidate[] ratePlanCandidatesField;

        private ArrayOfProfilesTypeProfileInfoProfileInfo[] profilesField;

        private RoomStayCandidateType[] roomStayCandidatesField;

        private PaymentFormType[] acceptedPaymentsField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private string occupancyField;

        private string rateCodesField;

        private string refNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HotelAmenity", Order = 0)]
        public HotelSearchCriterionTypeHotelAmenity[] HotelAmenity
        {
            get
            {
                return this.hotelAmenityField;
            }
            set
            {
                this.hotelAmenityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoomAmenity", Order = 1)]
        public RoomAmenityPrefType[] RoomAmenity
        {
            get
            {
                return this.roomAmenityField;
            }
            set
            {
                this.roomAmenityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Award", Order = 2)]
        public HotelSearchCriterionTypeAward[] Award
        {
            get
            {
                return this.awardField;
            }
            set
            {
                this.awardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Recreation", Order = 3)]
        public HotelSearchCriterionTypeRecreation[] Recreation
        {
            get
            {
                return this.recreationField;
            }
            set
            {
                this.recreationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service", Order = 4)]
        public HotelSearchCriterionTypeService[] Service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Transportation", Order = 5)]
        public HotelSearchCriterionTypeTransportation[] Transportation
        {
            get
            {
                return this.transportationField;
            }
            set
            {
                this.transportationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public DateTimeSpanType StayDateRange
        {
            get
            {
                return this.stayDateRangeField;
            }
            set
            {
                this.stayDateRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RateRange", Order = 7)]
        public HotelSearchCriterionTypeRateRange[] RateRange
        {
            get
            {
                return this.rateRangeField;
            }
            set
            {
                this.rateRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 8)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RatePlanCandidate", IsNullable = false)]
        public ArrayOfRatePlanCandidatesTypeRatePlanCandidateRatePlanCandidate[] RatePlanCandidates
        {
            get
            {
                return this.ratePlanCandidatesField;
            }
            set
            {
                this.ratePlanCandidatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 9)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileInfo", IsNullable = false)]
        public ArrayOfProfilesTypeProfileInfoProfileInfo[] Profiles
        {
            get
            {
                return this.profilesField;
            }
            set
            {
                this.profilesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 10)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomStayCandidate", IsNullable = false)]
        public RoomStayCandidateType[] RoomStayCandidates
        {
            get
            {
                return this.roomStayCandidatesField;
            }
            set
            {
                this.roomStayCandidatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 11)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AcceptedPayment", IsNullable = false)]
        public PaymentFormType[] AcceptedPayments
        {
            get
            {
                return this.acceptedPaymentsField;
            }
            set
            {
                this.acceptedPaymentsField = value;
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
        public string Occupancy
        {
            get
            {
                return this.occupancyField;
            }
            set
            {
                this.occupancyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateCodes
        {
            get
            {
                return this.rateCodesField;
            }
            set
            {
                this.rateCodesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string RefNumber
        {
            get
            {
                return this.refNumberField;
            }
            set
            {
                this.refNumberField = value;
            }
        }
    }
}