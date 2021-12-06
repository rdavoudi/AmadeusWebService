namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class HotelPrefType
    {

        private LoyaltyPrefType[] loyaltyPrefField;

        private PaymentFormPrefType[] paymentFormPrefField;

        private CompanyNamePrefType[] hotelChainPrefField;

        private PropertyNamePrefType[] propertyNamePrefField;

        private PropertyLocationPrefType[] propertyLocationPrefField;

        private PropertyTypePrefType[] propertyTypePrefField;

        private PropertyClassPrefType[] propertyClassPrefField;

        private PropertyAmenityPrefType[] propertyAmenityPrefField;

        private RoomAmenityPrefType[] roomAmenityPrefField;

        private RoomLocationPrefType[] roomLocationPrefField;

        private BedTypePrefType[] bedTypePrefField;

        private FoodSrvcPrefType[] foodSrvcPrefField;

        private MediaEntertainPrefType[] mediaEntertainPrefField;

        private PetInfoPrefType[] petInfoPrefField;

        private MealPrefType[] mealPrefField;

        private RecreationSrvcPrefType[] recreationSrvcPrefField;

        private BusinessSrvcPrefType[] businessSrvcPrefField;

        private PersonalSrvcPrefType[] personalSrvcPrefField;

        private SecurityFeaturePrefType[] securityFeaturePrefField;

        private PhysChallFeaturePrefType[] physChallFeaturePrefField;

        private SpecRequestPrefType[] specRequestPrefField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private PreferLevelType preferLevelField;

        private HotelPrefTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private HotelPrefTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private bool smokingAllowedField;

        private string ratePlanCodeField;

        private string hotelGuestTypeField;

        public HotelPrefType()
        {
            this.preferLevelField = PreferLevelType.Preferred;
            this.smokingAllowedField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyPref", Order = 0)]
        public LoyaltyPrefType[] LoyaltyPref
        {
            get
            {
                return this.loyaltyPrefField;
            }
            set
            {
                this.loyaltyPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentFormPref", Order = 1)]
        public PaymentFormPrefType[] PaymentFormPref
        {
            get
            {
                return this.paymentFormPrefField;
            }
            set
            {
                this.paymentFormPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HotelChainPref", Order = 2)]
        public CompanyNamePrefType[] HotelChainPref
        {
            get
            {
                return this.hotelChainPrefField;
            }
            set
            {
                this.hotelChainPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyNamePref", Order = 3)]
        public PropertyNamePrefType[] PropertyNamePref
        {
            get
            {
                return this.propertyNamePrefField;
            }
            set
            {
                this.propertyNamePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyLocationPref", Order = 4)]
        public PropertyLocationPrefType[] PropertyLocationPref
        {
            get
            {
                return this.propertyLocationPrefField;
            }
            set
            {
                this.propertyLocationPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyTypePref", Order = 5)]
        public PropertyTypePrefType[] PropertyTypePref
        {
            get
            {
                return this.propertyTypePrefField;
            }
            set
            {
                this.propertyTypePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyClassPref", Order = 6)]
        public PropertyClassPrefType[] PropertyClassPref
        {
            get
            {
                return this.propertyClassPrefField;
            }
            set
            {
                this.propertyClassPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyAmenityPref", Order = 7)]
        public PropertyAmenityPrefType[] PropertyAmenityPref
        {
            get
            {
                return this.propertyAmenityPrefField;
            }
            set
            {
                this.propertyAmenityPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoomAmenityPref", Order = 8)]
        public RoomAmenityPrefType[] RoomAmenityPref
        {
            get
            {
                return this.roomAmenityPrefField;
            }
            set
            {
                this.roomAmenityPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoomLocationPref", Order = 9)]
        public RoomLocationPrefType[] RoomLocationPref
        {
            get
            {
                return this.roomLocationPrefField;
            }
            set
            {
                this.roomLocationPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BedTypePref", Order = 10)]
        public BedTypePrefType[] BedTypePref
        {
            get
            {
                return this.bedTypePrefField;
            }
            set
            {
                this.bedTypePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FoodSrvcPref", Order = 11)]
        public FoodSrvcPrefType[] FoodSrvcPref
        {
            get
            {
                return this.foodSrvcPrefField;
            }
            set
            {
                this.foodSrvcPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MediaEntertainPref", Order = 12)]
        public MediaEntertainPrefType[] MediaEntertainPref
        {
            get
            {
                return this.mediaEntertainPrefField;
            }
            set
            {
                this.mediaEntertainPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PetInfoPref", Order = 13)]
        public PetInfoPrefType[] PetInfoPref
        {
            get
            {
                return this.petInfoPrefField;
            }
            set
            {
                this.petInfoPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MealPref", Order = 14)]
        public MealPrefType[] MealPref
        {
            get
            {
                return this.mealPrefField;
            }
            set
            {
                this.mealPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecreationSrvcPref", Order = 15)]
        public RecreationSrvcPrefType[] RecreationSrvcPref
        {
            get
            {
                return this.recreationSrvcPrefField;
            }
            set
            {
                this.recreationSrvcPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BusinessSrvcPref", Order = 16)]
        public BusinessSrvcPrefType[] BusinessSrvcPref
        {
            get
            {
                return this.businessSrvcPrefField;
            }
            set
            {
                this.businessSrvcPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonalSrvcPref", Order = 17)]
        public PersonalSrvcPrefType[] PersonalSrvcPref
        {
            get
            {
                return this.personalSrvcPrefField;
            }
            set
            {
                this.personalSrvcPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SecurityFeaturePref", Order = 18)]
        public SecurityFeaturePrefType[] SecurityFeaturePref
        {
            get
            {
                return this.securityFeaturePrefField;
            }
            set
            {
                this.securityFeaturePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysChallFeaturePref", Order = 19)]
        public PhysChallFeaturePrefType[] PhysChallFeaturePref
        {
            get
            {
                return this.physChallFeaturePrefField;
            }
            set
            {
                this.physChallFeaturePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecRequestPref", Order = 20)]
        public SpecRequestPrefType[] SpecRequestPref
        {
            get
            {
                return this.specRequestPrefField;
            }
            set
            {
                this.specRequestPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
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
        [System.ComponentModel.DefaultValueAttribute(PreferLevelType.Preferred)]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this.preferLevelField;
            }
            set
            {
                this.preferLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HotelPrefTypeShareSynchInd ShareSynchInd
        {
            get
            {
                return this.shareSynchIndField;
            }
            set
            {
                this.shareSynchIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShareSynchIndSpecified
        {
            get
            {
                return this.shareSynchIndFieldSpecified;
            }
            set
            {
                this.shareSynchIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HotelPrefTypeShareMarketInd ShareMarketInd
        {
            get
            {
                return this.shareMarketIndField;
            }
            set
            {
                this.shareMarketIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShareMarketIndSpecified
        {
            get
            {
                return this.shareMarketIndFieldSpecified;
            }
            set
            {
                this.shareMarketIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SmokingAllowed
        {
            get
            {
                return this.smokingAllowedField;
            }
            set
            {
                this.smokingAllowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanCode
        {
            get
            {
                return this.ratePlanCodeField;
            }
            set
            {
                this.ratePlanCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelGuestType
        {
            get
            {
                return this.hotelGuestTypeField;
            }
            set
            {
                this.hotelGuestTypeField = value;
            }
        }
    }
}