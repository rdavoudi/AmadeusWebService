namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightOTA_AirLowFareSearchRQAdvanceSearchInfo
    {

        private int numberOfRecommendationField;

        private int maxEFTPercentageField;

        private SearchFlightOTA_AirLowFareSearchRQAdvanceSearchInfoMaxLayoverPerConnection maxLayoverPerConnectionField;

        private string overrideFareTypesField;

        private AirlineDiversityEnum[] airlineDiversityField;

        private bool ignoreAvailabilityField;

        private string currencyField;

        private ExpandedParameterEnum[] expandedParametersField;

        private bool returnMoreOvernightFlightsField;

        private bool returnMoreOvernightFlightsFieldSpecified;

        private DuplicatedRecommedationsBehaviorEnum duplicatedRecommedationsBehaviorField;

        private bool duplicatedRecommedationsBehaviorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int NumberOfRecommendation
        {
            get
            {
                return this.numberOfRecommendationField;
            }
            set
            {
                this.numberOfRecommendationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int MaxEFTPercentage
        {
            get
            {
                return this.maxEFTPercentageField;
            }
            set
            {
                this.maxEFTPercentageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public SearchFlightOTA_AirLowFareSearchRQAdvanceSearchInfoMaxLayoverPerConnection MaxLayoverPerConnection
        {
            get
            {
                return this.maxLayoverPerConnectionField;
            }
            set
            {
                this.maxLayoverPerConnectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string OverrideFareTypes
        {
            get
            {
                return this.overrideFareTypesField;
            }
            set
            {
                this.overrideFareTypesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("DiversityType", IsNullable = false)]
        public AirlineDiversityEnum[] AirlineDiversity
        {
            get
            {
                return this.airlineDiversityField;
            }
            set
            {
                this.airlineDiversityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public bool IgnoreAvailability
        {
            get
            {
                return this.ignoreAvailabilityField;
            }
            set
            {
                this.ignoreAvailabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Param", IsNullable = false)]
        public ExpandedParameterEnum[] ExpandedParameters
        {
            get
            {
                return this.expandedParametersField;
            }
            set
            {
                this.expandedParametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public bool ReturnMoreOvernightFlights
        {
            get
            {
                return this.returnMoreOvernightFlightsField;
            }
            set
            {
                this.returnMoreOvernightFlightsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnMoreOvernightFlightsSpecified
        {
            get
            {
                return this.returnMoreOvernightFlightsFieldSpecified;
            }
            set
            {
                this.returnMoreOvernightFlightsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public DuplicatedRecommedationsBehaviorEnum DuplicatedRecommedationsBehavior
        {
            get
            {
                return this.duplicatedRecommedationsBehaviorField;
            }
            set
            {
                this.duplicatedRecommedationsBehaviorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DuplicatedRecommedationsBehaviorSpecified
        {
            get
            {
                return this.duplicatedRecommedationsBehaviorFieldSpecified;
            }
            set
            {
                this.duplicatedRecommedationsBehaviorFieldSpecified = value;
            }
        }
    }
}