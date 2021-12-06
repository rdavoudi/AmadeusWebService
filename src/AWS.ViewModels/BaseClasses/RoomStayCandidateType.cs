namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RoomStayCandidateType
    {

        private GuestCountType guestCountsField;

        private RoomAmenityPrefType[] roomAmenityField;

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

        private string rPHField;

        private string ratePlanCandidateRPHField;

        private string bookingCodeField;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private System.DateTime expireDateField;

        private bool expireDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public GuestCountType GuestCounts
        {
            get
            {
                return this.guestCountsField;
            }
            set
            {
                this.guestCountsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoomAmenity", Order = 1)]
        public RoomAmenityPrefType[] RoomAmenity
        {
            get
            {
                return this.roomAmenityField;
            }
            set
            {
                this.roomAmenityField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanCandidateRPH
        {
            get
            {
                return this.ratePlanCandidateRPHField;
            }
            set
            {
                this.ratePlanCandidateRPHField = value;
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
    }
}