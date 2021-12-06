namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfRateTypeRateRate : AmountType
    {

        private TPA_ExtensionsType tPA_ExtensionsField;

        private string durationField;

        private string rateModeField;

        private bool cachedIndicatorField;

        private bool cachedIndicatorFieldSpecified;

        private string rateSourceField;

        private string rateTypeCodeField;

        private PricingType roomPricingTypeField;

        private bool roomPricingTypeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateMode
        {
            get
            {
                return this.rateModeField;
            }
            set
            {
                this.rateModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CachedIndicator
        {
            get
            {
                return this.cachedIndicatorField;
            }
            set
            {
                this.cachedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CachedIndicatorSpecified
        {
            get
            {
                return this.cachedIndicatorFieldSpecified;
            }
            set
            {
                this.cachedIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateSource
        {
            get
            {
                return this.rateSourceField;
            }
            set
            {
                this.rateSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateTypeCode
        {
            get
            {
                return this.rateTypeCodeField;
            }
            set
            {
                this.rateTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PricingType RoomPricingType
        {
            get
            {
                return this.roomPricingTypeField;
            }
            set
            {
                this.roomPricingTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RoomPricingTypeSpecified
        {
            get
            {
                return this.roomPricingTypeFieldSpecified;
            }
            set
            {
                this.roomPricingTypeFieldSpecified = value;
            }
        }
    }
}