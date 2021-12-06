namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CommonPrefType
    {

        private NamePrefType[] namePrefField;

        private PhonePrefType[] phonePrefField;

        private AddressPrefType[] addressPrefField;

        private PaymentFormPrefType[] paymentFormPrefField;

        private InterestPrefType[] interestPrefField;

        private InsurancePrefType[] insurancePrefField;

        private SeatingPrefType[] seatingPrefField;

        private TicketDistribPrefType[] ticketDistribPrefField;

        private MediaEntertainPrefType[] mediaEntertainPrefField;

        private PetInfoPrefType[] petInfoPrefField;

        private MealPrefType[] mealPrefField;

        private LoyaltyPrefType[] loyaltyPrefField;

        private SpecRequestPrefType[] specRequestPrefField;

        private RelatedTravelerPrefType[] relatedTravelerPrefField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private CommonPrefTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private CommonPrefTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private bool smokingAllowedField;

        private string primaryLangIDField;

        private string altLangIDField;

        public CommonPrefType()
        {
            this.smokingAllowedField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NamePref", Order = 0)]
        public NamePrefType[] NamePref
        {
            get
            {
                return this.namePrefField;
            }
            set
            {
                this.namePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhonePref", Order = 1)]
        public PhonePrefType[] PhonePref
        {
            get
            {
                return this.phonePrefField;
            }
            set
            {
                this.phonePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddressPref", Order = 2)]
        public AddressPrefType[] AddressPref
        {
            get
            {
                return this.addressPrefField;
            }
            set
            {
                this.addressPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentFormPref", Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute("InterestPref", Order = 4)]
        public InterestPrefType[] InterestPref
        {
            get
            {
                return this.interestPrefField;
            }
            set
            {
                this.interestPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InsurancePref", Order = 5)]
        public InsurancePrefType[] InsurancePref
        {
            get
            {
                return this.insurancePrefField;
            }
            set
            {
                this.insurancePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SeatingPref", Order = 6)]
        public SeatingPrefType[] SeatingPref
        {
            get
            {
                return this.seatingPrefField;
            }
            set
            {
                this.seatingPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TicketDistribPref", Order = 7)]
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
        [System.Xml.Serialization.XmlElementAttribute("MediaEntertainPref", Order = 8)]
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
        [System.Xml.Serialization.XmlElementAttribute("PetInfoPref", Order = 9)]
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
        [System.Xml.Serialization.XmlElementAttribute("MealPref", Order = 10)]
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
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyPref", Order = 11)]
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
        [System.Xml.Serialization.XmlElementAttribute("RelatedTravelerPref", Order = 13)]
        public RelatedTravelerPrefType[] RelatedTravelerPref
        {
            get
            {
                return this.relatedTravelerPrefField;
            }
            set
            {
                this.relatedTravelerPrefField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CommonPrefTypeShareSynchInd ShareSynchInd
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
        public CommonPrefTypeShareMarketInd ShareMarketInd
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "language")]
        public string PrimaryLangID
        {
            get
            {
                return this.primaryLangIDField;
            }
            set
            {
                this.primaryLangIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "language")]
        public string AltLangID
        {
            get
            {
                return this.altLangIDField;
            }
            set
            {
                this.altLangIDField = value;
            }
        }
    }
}