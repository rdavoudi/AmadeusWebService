namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirItineraryType
    {

        private ArrayOfAirItineraryTypeOriginDestinationOptionOriginDestinationOption[] originDestinationOptionsField;

        private BrandFareResponseItem[] extraOTABrandInfoListField;

        private OriginDestinationCombinationType[] originDestinationCombinationsField;

        private string validatingAirlineCodeField;

        private AirTripType directionIndField;

        private bool directionIndFieldSpecified;

        private bool calculateSFField;

        private bool calculateSFFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("OriginDestinationOption", IsNullable = false)]
        public ArrayOfAirItineraryTypeOriginDestinationOptionOriginDestinationOption[] OriginDestinationOptions
        {
            get
            {
                return this.originDestinationOptionsField;
            }
            set
            {
                this.originDestinationOptionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("FareBrandOtaResponseItem")]
        public BrandFareResponseItem[] ExtraOTABrandInfoList
        {
            get
            {
                return this.extraOTABrandInfoListField;
            }
            set
            {
                this.extraOTABrandInfoListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("OriginDestinationCombination")]
        public OriginDestinationCombinationType[] OriginDestinationCombinations
        {
            get
            {
                return this.originDestinationCombinationsField;
            }
            set
            {
                this.originDestinationCombinationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ValidatingAirlineCode
        {
            get
            {
                return this.validatingAirlineCodeField;
            }
            set
            {
                this.validatingAirlineCodeField = value;
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
        public bool CalculateSF
        {
            get
            {
                return this.calculateSFField;
            }
            set
            {
                this.calculateSFField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CalculateSFSpecified
        {
            get
            {
                return this.calculateSFFieldSpecified;
            }
            set
            {
                this.calculateSFFieldSpecified = value;
            }
        }
    }
}