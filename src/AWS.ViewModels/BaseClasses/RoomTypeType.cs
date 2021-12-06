namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RoomTypeType
    {

        private ParagraphType roomDescriptionField;

        private AdditionalDetailType[] additionalDetailsField;

        private RoomAmenityPrefType[] amenitiesField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private string numberOfUnitsField;

        private bool isRoomField;

        private bool isRoomFieldSpecified;

        private bool isConvertedField;

        private bool isConvertedFieldSpecified;

        private bool isAlternateField;

        private bool isAlternateFieldSpecified;

        private string reqdGuaranteeTypeField;

        private string roomTypeField;

        private string roomTypeCodeField;

        private string roomCategoryField;

        private string roomIDField;

        private string floorField;

        private string invBlockCodeField;

        private string roomLocationCodeField;

        private string roomViewCodeField;

        private string[] bedTypeCodeField;

        private bool nonSmokingField;

        private bool nonSmokingFieldSpecified;

        private string configurationField;

        private string sizeMeasurementField;

        private string quantityField;

        private bool compositeField;

        private bool compositeFieldSpecified;

        private string roomClassificationCodeField;

        private string roomArchitectureCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ParagraphType RoomDescription
        {
            get
            {
                return this.roomDescriptionField;
            }
            set
            {
                this.roomDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AdditionalDetail", IsNullable = false)]
        public AdditionalDetailType[] AdditionalDetails
        {
            get
            {
                return this.additionalDetailsField;
            }
            set
            {
                this.additionalDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Amenity", IsNullable = false)]
        public RoomAmenityPrefType[] Amenities
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string NumberOfUnits
        {
            get
            {
                return this.numberOfUnitsField;
            }
            set
            {
                this.numberOfUnitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsRoom
        {
            get
            {
                return this.isRoomField;
            }
            set
            {
                this.isRoomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsRoomSpecified
        {
            get
            {
                return this.isRoomFieldSpecified;
            }
            set
            {
                this.isRoomFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsConverted
        {
            get
            {
                return this.isConvertedField;
            }
            set
            {
                this.isConvertedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsConvertedSpecified
        {
            get
            {
                return this.isConvertedFieldSpecified;
            }
            set
            {
                this.isConvertedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsAlternate
        {
            get
            {
                return this.isAlternateField;
            }
            set
            {
                this.isAlternateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsAlternateSpecified
        {
            get
            {
                return this.isAlternateFieldSpecified;
            }
            set
            {
                this.isAlternateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReqdGuaranteeType
        {
            get
            {
                return this.reqdGuaranteeTypeField;
            }
            set
            {
                this.reqdGuaranteeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomType
        {
            get
            {
                return this.roomTypeField;
            }
            set
            {
                this.roomTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomTypeCode
        {
            get
            {
                return this.roomTypeCodeField;
            }
            set
            {
                this.roomTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomCategory
        {
            get
            {
                return this.roomCategoryField;
            }
            set
            {
                this.roomCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomID
        {
            get
            {
                return this.roomIDField;
            }
            set
            {
                this.roomIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Floor
        {
            get
            {
                return this.floorField;
            }
            set
            {
                this.floorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvBlockCode
        {
            get
            {
                return this.invBlockCodeField;
            }
            set
            {
                this.invBlockCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomLocationCode
        {
            get
            {
                return this.roomLocationCodeField;
            }
            set
            {
                this.roomLocationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomViewCode
        {
            get
            {
                return this.roomViewCodeField;
            }
            set
            {
                this.roomViewCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] BedTypeCode
        {
            get
            {
                return this.bedTypeCodeField;
            }
            set
            {
                this.bedTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonSmoking
        {
            get
            {
                return this.nonSmokingField;
            }
            set
            {
                this.nonSmokingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NonSmokingSpecified
        {
            get
            {
                return this.nonSmokingFieldSpecified;
            }
            set
            {
                this.nonSmokingFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Configuration
        {
            get
            {
                return this.configurationField;
            }
            set
            {
                this.configurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SizeMeasurement
        {
            get
            {
                return this.sizeMeasurementField;
            }
            set
            {
                this.sizeMeasurementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Composite
        {
            get
            {
                return this.compositeField;
            }
            set
            {
                this.compositeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CompositeSpecified
        {
            get
            {
                return this.compositeFieldSpecified;
            }
            set
            {
                this.compositeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomClassificationCode
        {
            get
            {
                return this.roomClassificationCodeField;
            }
            set
            {
                this.roomClassificationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomArchitectureCode
        {
            get
            {
                return this.roomArchitectureCodeField;
            }
            set
            {
                this.roomArchitectureCodeField = value;
            }
        }
    }
}