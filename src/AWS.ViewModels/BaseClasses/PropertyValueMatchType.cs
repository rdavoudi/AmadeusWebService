namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PropertyValueMatchType : BasicPropertyInfoType
    {

        private PropertyValueMatchTypeSearchValueMatch[] searchValueMatchField;

        private ArrayOfPropertyValueMatchTypeAmenityAmenity[] amenitiesField;

        private PropertyValueMatchTypeRateRange rateRangeField;

        private string moreDataEchoTokenField;

        private bool sameCountryIndField;

        private bool sameCountryIndFieldSpecified;

        private RateIndicatorType availabilityStatusField;

        private bool availabilityStatusFieldSpecified;

        private string hotelCurrencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SearchValueMatch", Order = 0)]
        public PropertyValueMatchTypeSearchValueMatch[] SearchValueMatch
        {
            get
            {
                return this.searchValueMatchField;
            }
            set
            {
                this.searchValueMatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Amenity", IsNullable = false)]
        public ArrayOfPropertyValueMatchTypeAmenityAmenity[] Amenities
        {
            get
            {
                return this.amenitiesField;
            }
            set
            {
                this.amenitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public PropertyValueMatchTypeRateRange RateRange
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MoreDataEchoToken
        {
            get
            {
                return this.moreDataEchoTokenField;
            }
            set
            {
                this.moreDataEchoTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SameCountryInd
        {
            get
            {
                return this.sameCountryIndField;
            }
            set
            {
                this.sameCountryIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SameCountryIndSpecified
        {
            get
            {
                return this.sameCountryIndFieldSpecified;
            }
            set
            {
                this.sameCountryIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RateIndicatorType AvailabilityStatus
        {
            get
            {
                return this.availabilityStatusField;
            }
            set
            {
                this.availabilityStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AvailabilityStatusSpecified
        {
            get
            {
                return this.availabilityStatusFieldSpecified;
            }
            set
            {
                this.availabilityStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCurrency
        {
            get
            {
                return this.hotelCurrencyField;
            }
            set
            {
                this.hotelCurrencyField = value;
            }
        }
    }
}