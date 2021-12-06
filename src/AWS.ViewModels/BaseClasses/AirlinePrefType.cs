namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirlinePrefType
    {

        private LoyaltyPrefType[] loyaltyPrefField;

        private CompanyNamePrefType[] vendorPrefField;

        private PaymentFormPrefType[] paymentFormPrefField;

        private AirportPrefType[] airportOriginPrefField;

        private AirportPrefType[] airportRoutePrefField;

        private AirlinePrefTypeFareRestrictPref[] fareRestrictPrefField;

        private AirlinePrefTypeFlightTypePref[] flightTypePrefField;

        private EquipmentTypePref[] equipPrefField;

        private AirlinePrefTypeCabinPref[] cabinPrefField;

        private AirlinePrefTypeSeatPref[] seatPrefField;

        private TicketDistribPrefType[] ticketDistribPrefField;

        private MealPrefType[] mealPrefField;

        private SpecRequestPrefType[] specRequestPrefField;

        private AirlinePrefTypeSSR_Pref[] sSR_PrefField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private MediaEntertainPrefType[] mediaEntertainPrefField;

        private PetInfoPrefType[] petInfoPrefField;

        private AirlinePrefTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private AirlinePrefTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private PreferLevelType preferLevelField;

        private bool smokingAllowedField;

        private string passengerTypeCodeField;

        private TicketType airTicketTypeField;

        private bool airTicketTypeFieldSpecified;

        public AirlinePrefType()
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
        [System.Xml.Serialization.XmlElementAttribute("VendorPref", Order = 1)]
        public CompanyNamePrefType[] VendorPref
        {
            get
            {
                return this.vendorPrefField;
            }
            set
            {
                this.vendorPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentFormPref", Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute("AirportOriginPref", Order = 3)]
        public AirportPrefType[] AirportOriginPref
        {
            get
            {
                return this.airportOriginPrefField;
            }
            set
            {
                this.airportOriginPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AirportRoutePref", Order = 4)]
        public AirportPrefType[] AirportRoutePref
        {
            get
            {
                return this.airportRoutePrefField;
            }
            set
            {
                this.airportRoutePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FareRestrictPref", Order = 5)]
        public AirlinePrefTypeFareRestrictPref[] FareRestrictPref
        {
            get
            {
                return this.fareRestrictPrefField;
            }
            set
            {
                this.fareRestrictPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FlightTypePref", Order = 6)]
        public AirlinePrefTypeFlightTypePref[] FlightTypePref
        {
            get
            {
                return this.flightTypePrefField;
            }
            set
            {
                this.flightTypePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipPref", Order = 7)]
        public EquipmentTypePref[] EquipPref
        {
            get
            {
                return this.equipPrefField;
            }
            set
            {
                this.equipPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CabinPref", Order = 8)]
        public AirlinePrefTypeCabinPref[] CabinPref
        {
            get
            {
                return this.cabinPrefField;
            }
            set
            {
                this.cabinPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SeatPref", Order = 9)]
        public AirlinePrefTypeSeatPref[] SeatPref
        {
            get
            {
                return this.seatPrefField;
            }
            set
            {
                this.seatPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TicketDistribPref", Order = 10)]
        public TicketDistribPrefType[] TicketDistribPref
        {
            get
            {
                return this.ticketDistribPrefField;
            }
            set
            {
                this.ticketDistribPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MealPref", Order = 11)]
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
        [System.Xml.Serialization.XmlElementAttribute("SpecRequestPref", Order = 12)]
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
        [System.Xml.Serialization.XmlElementAttribute("SSR_Pref", Order = 13)]
        public AirlinePrefTypeSSR_Pref[] SSR_Pref
        {
            get
            {
                return this.sSR_PrefField;
            }
            set
            {
                this.sSR_PrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
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
        [System.Xml.Serialization.XmlElementAttribute("MediaEntertainPref", Order = 15)]
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
        [System.Xml.Serialization.XmlElementAttribute("PetInfoPref", Order = 16)]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirlinePrefTypeShareSynchInd ShareSynchInd
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
        public AirlinePrefTypeShareMarketInd ShareMarketInd
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
        public string PassengerTypeCode
        {
            get
            {
                return this.passengerTypeCodeField;
            }
            set
            {
                this.passengerTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TicketType AirTicketType
        {
            get
            {
                return this.airTicketTypeField;
            }
            set
            {
                this.airTicketTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AirTicketTypeSpecified
        {
            get
            {
                return this.airTicketTypeFieldSpecified;
            }
            set
            {
                this.airTicketTypeFieldSpecified = value;
            }
        }
    }
}