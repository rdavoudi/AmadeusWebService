namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyValueMatchType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BasicPropertyInfoType
    {

        private string guarenteeField;

        private string stayField;

        private string depositField;

        private string safetyField;

        private string fireSafetyField;

        private string transportationField;

        private string taxField;

        private string mealsField;

        private string[] imagesField;

        private string extraChargesField;

        private string bestTransportationTypeField;

        private string addRoomOccupantField;

        private string thumbnailImageField;

        private BasicPropertyInfoTypePosition positionField;

        private AddressInfoType addressField;

        private ArrayOfBasicPropertyInfoTypeContactNumberContactNumber[] contactNumbersField;

        private BasicPropertyInfoTypeAward[] awardField;

        private string introductionField;

        private RelativePositionType relativePositionField;

        private BasicPropertyInfoTypeHotelAmenity[] hotelAmenityField;

        private BasicPropertyInfoTypeRecreation[] recreationField;

        private BasicPropertyInfoTypeService[] serviceField;

        private string policyField;

        private int hotelIDField;

        private string chainCodeField;

        private string brandCodeField;

        private string hotelCodeField;

        private string hotelCityCodeField;

        private string hotelNameField;

        private string hotelCodeContextField;

        private string chainNameField;

        private string brandNameField;

        private string hotelSegmentCategoryCodeField;

        private string supplierIntegrationLevelField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Guarentee
        {
            get
            {
                return this.guarenteeField;
            }
            set
            {
                this.guarenteeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Stay
        {
            get
            {
                return this.stayField;
            }
            set
            {
                this.stayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Deposit
        {
            get
            {
                return this.depositField;
            }
            set
            {
                this.depositField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Safety
        {
            get
            {
                return this.safetyField;
            }
            set
            {
                this.safetyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string FireSafety
        {
            get
            {
                return this.fireSafetyField;
            }
            set
            {
                this.fireSafetyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string Transportation
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
        public string Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string Meals
        {
            get
            {
                return this.mealsField;
            }
            set
            {
                this.mealsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 8)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Image")]
        public string[] Images
        {
            get
            {
                return this.imagesField;
            }
            set
            {
                this.imagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string ExtraCharges
        {
            get
            {
                return this.extraChargesField;
            }
            set
            {
                this.extraChargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string BestTransportationType
        {
            get
            {
                return this.bestTransportationTypeField;
            }
            set
            {
                this.bestTransportationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string AddRoomOccupant
        {
            get
            {
                return this.addRoomOccupantField;
            }
            set
            {
                this.addRoomOccupantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string ThumbnailImage
        {
            get
            {
                return this.thumbnailImageField;
            }
            set
            {
                this.thumbnailImageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public BasicPropertyInfoTypePosition Position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public AddressInfoType Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 15)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ContactNumber", IsNullable = false)]
        public ArrayOfBasicPropertyInfoTypeContactNumberContactNumber[] ContactNumbers
        {
            get
            {
                return this.contactNumbersField;
            }
            set
            {
                this.contactNumbersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Award", Order = 16)]
        public BasicPropertyInfoTypeAward[] Award
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string Introduction
        {
            get
            {
                return this.introductionField;
            }
            set
            {
                this.introductionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public RelativePositionType RelativePosition
        {
            get
            {
                return this.relativePositionField;
            }
            set
            {
                this.relativePositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HotelAmenity", Order = 19)]
        public BasicPropertyInfoTypeHotelAmenity[] HotelAmenity
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
        [System.Xml.Serialization.XmlElementAttribute("Recreation", Order = 20)]
        public BasicPropertyInfoTypeRecreation[] Recreation
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
        [System.Xml.Serialization.XmlElementAttribute("Service", Order = 21)]
        public BasicPropertyInfoTypeService[] Service
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public string Policy
        {
            get
            {
                return this.policyField;
            }
            set
            {
                this.policyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int HotelID
        {
            get
            {
                return this.hotelIDField;
            }
            set
            {
                this.hotelIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChainCode
        {
            get
            {
                return this.chainCodeField;
            }
            set
            {
                this.chainCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandCode
        {
            get
            {
                return this.brandCodeField;
            }
            set
            {
                this.brandCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCode
        {
            get
            {
                return this.hotelCodeField;
            }
            set
            {
                this.hotelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCityCode
        {
            get
            {
                return this.hotelCityCodeField;
            }
            set
            {
                this.hotelCityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelName
        {
            get
            {
                return this.hotelNameField;
            }
            set
            {
                this.hotelNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCodeContext
        {
            get
            {
                return this.hotelCodeContextField;
            }
            set
            {
                this.hotelCodeContextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChainName
        {
            get
            {
                return this.chainNameField;
            }
            set
            {
                this.chainNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandName
        {
            get
            {
                return this.brandNameField;
            }
            set
            {
                this.brandNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelSegmentCategoryCode
        {
            get
            {
                return this.hotelSegmentCategoryCodeField;
            }
            set
            {
                this.hotelSegmentCategoryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string SupplierIntegrationLevel
        {
            get
            {
                return this.supplierIntegrationLevelField;
            }
            set
            {
                this.supplierIntegrationLevelField = value;
            }
        }
    }
}