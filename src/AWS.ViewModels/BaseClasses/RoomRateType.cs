namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RoomRateType
    {

        private ArrayOfRateTypeRateRate[] ratesField;

        private ParagraphType[] roomRateDescriptionField;

        private ArrayOfRoomRateTypeFeatureFeature[] featuresField;

        private TotalType totalField;

        private RoomRateTypeAvailability[] availabilityField;

        private string bookingCodeField;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private System.DateTime expireDateField;

        private bool expireDateFieldSpecified;

        private string roomTypeCodeField;

        private string invBlockCodeField;

        private string numberOfUnitsField;

        private string ratePlanTypeField;

        private string ratePlanCodeField;

        private string ratePlanIDField;

        private bool ratePlanQualifierField;

        private bool ratePlanQualifierFieldSpecified;

        private string ratePlanCategoryField;

        private RateIndicatorType availabilityStatusField;

        private bool availabilityStatusFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Rate", IsNullable = false)]
        public ArrayOfRateTypeRateRate[] Rates
        {
            get
            {
                return this.ratesField;
            }
            set
            {
                this.ratesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoomRateDescription", Order = 1)]
        public ParagraphType[] RoomRateDescription
        {
            get
            {
                return this.roomRateDescriptionField;
            }
            set
            {
                this.roomRateDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Feature", IsNullable = false)]
        public ArrayOfRoomRateTypeFeatureFeature[] Features
        {
            get
            {
                return this.featuresField;
            }
            set
            {
                this.featuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TotalType Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Availability", Order = 4)]
        public RoomRateTypeAvailability[] Availability
        {
            get
            {
                return this.availabilityField;
            }
            set
            {
                this.availabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BookingCode
        {
            get
            {
                return this.bookingCodeField;
            }
            set
            {
                this.bookingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EffectiveDateSpecified
        {
            get
            {
                return this.effectiveDateFieldSpecified;
            }
            set
            {
                this.effectiveDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpireDateSpecified
        {
            get
            {
                return this.expireDateFieldSpecified;
            }
            set
            {
                this.expireDateFieldSpecified = value;
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
        public string RatePlanType
        {
            get
            {
                return this.ratePlanTypeField;
            }
            set
            {
                this.ratePlanTypeField = value;
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
        public string RatePlanID
        {
            get
            {
                return this.ratePlanIDField;
            }
            set
            {
                this.ratePlanIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RatePlanQualifier
        {
            get
            {
                return this.ratePlanQualifierField;
            }
            set
            {
                this.ratePlanQualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RatePlanQualifierSpecified
        {
            get
            {
                return this.ratePlanQualifierFieldSpecified;
            }
            set
            {
                this.ratePlanQualifierFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanCategory
        {
            get
            {
                return this.ratePlanCategoryField;
            }
            set
            {
                this.ratePlanCategoryField = value;
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
    }
}