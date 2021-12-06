namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfAirItineraryTypeOriginDestinationOptionOriginDestinationOption : OriginDestinationOptionType
    {

        private BrandInfo[] brandInfosField;

        private MiniRule[] miniRulesField;

        private AirItineraryPricingInfoType optionPricingInfoField;

        private FareType itinBaseFareField;

        private string corporateFareCodeField;

        private string refNumberField;

        private AirTripType directionIndField;

        private bool directionIndFieldSpecified;

        private int directionIdField;

        private string elapsedTimeField;

        private string providerTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Brand")]
        public BrandInfo[] BrandInfos
        {
            get
            {
                return this.brandInfosField;
            }
            set
            {
                this.brandInfosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        public MiniRule[] MiniRules
        {
            get
            {
                return this.miniRulesField;
            }
            set
            {
                this.miniRulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public AirItineraryPricingInfoType OptionPricingInfo
        {
            get
            {
                return this.optionPricingInfoField;
            }
            set
            {
                this.optionPricingInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public FareType ItinBaseFare
        {
            get
            {
                return this.itinBaseFareField;
            }
            set
            {
                this.itinBaseFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirTripType DirectionInd
        {
            get
            {
                return this.directionIndField;
            }
            set
            {
                this.directionIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DirectionIndSpecified
        {
            get
            {
                return this.directionIndFieldSpecified;
            }
            set
            {
                this.directionIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int DirectionId
        {
            get
            {
                return this.directionIdField;
            }
            set
            {
                this.directionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ElapsedTime
        {
            get
            {
                return this.elapsedTimeField;
            }
            set
            {
                this.elapsedTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProviderType
        {
            get
            {
                return this.providerTypeField;
            }
            set
            {
                this.providerTypeField = value;
            }
        }
    }
}