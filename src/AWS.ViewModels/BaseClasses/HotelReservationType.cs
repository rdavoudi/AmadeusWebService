namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class HotelReservationType
    {

        private SourceType[] pOSField;

        private UniqueID_Type[] uniqueIDField;

        private ArrayOfOTA_HotelAvailRSRoomStaysRoomStayRoomStay[] roomStaysField;

        private HotelReservationTypeHotelStay hotelStayField;

        private HotelReservationTypeAreas areasField;

        private ArrayOfServicesTypeServiceService[] servicesField;

        private ArrayOfResGuestsTypeResGuestResGuest[] resGuestsField;

        private ResGlobalInfoType resGlobalInfoField;

        private WrittenConfInstType writtenConfInstField;

        private HotelReservationTypeQueue queueField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private bool roomStayReservationField;

        private bool roomStayReservationFieldSpecified;

        private System.DateTime createDateTimeField;

        private bool createDateTimeFieldSpecified;

        private string creatorIDField;

        private System.DateTime lastModifyDateTimeField;

        private bool lastModifyDateTimeFieldSpecified;

        private string lastModifierIDField;

        private System.DateTime purgeDateField;

        private bool purgeDateFieldSpecified;

        private string resStatusField;

        private bool forcedSellIndicatorField;

        private bool forcedSellIndicatorFieldSpecified;

        private bool serviceOverrideIndicatorField;

        private bool serviceOverrideIndicatorFieldSpecified;

        private bool rateOverrideIndicatorField;

        private bool rateOverrideIndicatorFieldSpecified;

        private bool walkInIndicatorField;

        private bool walkInIndicatorFieldSpecified;

        private bool roomNumberLockedIndicatorField;

        private bool roomNumberLockedIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Source", IsNullable = false)]
        public SourceType[] POS
        {
            get
            {
                return this.pOSField;
            }
            set
            {
                this.pOSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UniqueID", Order = 1)]
        public UniqueID_Type[] UniqueID
        {
            get
            {
                return this.uniqueIDField;
            }
            set
            {
                this.uniqueIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomStay", IsNullable = false)]
        public ArrayOfOTA_HotelAvailRSRoomStaysRoomStayRoomStay[] RoomStays
        {
            get
            {
                return this.roomStaysField;
            }
            set
            {
                this.roomStaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public HotelReservationTypeHotelStay HotelStay
        {
            get
            {
                return this.hotelStayField;
            }
            set
            {
                this.hotelStayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public HotelReservationTypeAreas Areas
        {
            get
            {
                return this.areasField;
            }
            set
            {
                this.areasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Service", IsNullable = false)]
        public ArrayOfServicesTypeServiceService[] Services
        {
            get
            {
                return this.servicesField;
            }
            set
            {
                this.servicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 6)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ResGuest", IsNullable = false)]
        public ArrayOfResGuestsTypeResGuestResGuest[] ResGuests
        {
            get
            {
                return this.resGuestsField;
            }
            set
            {
                this.resGuestsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public ResGlobalInfoType ResGlobalInfo
        {
            get
            {
                return this.resGlobalInfoField;
            }
            set
            {
                this.resGlobalInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public WrittenConfInstType WrittenConfInst
        {
            get
            {
                return this.writtenConfInstField;
            }
            set
            {
                this.writtenConfInstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public HotelReservationTypeQueue Queue
        {
            get
            {
                return this.queueField;
            }
            set
            {
                this.queueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
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
        public bool RoomStayReservation
        {
            get
            {
                return this.roomStayReservationField;
            }
            set
            {
                this.roomStayReservationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RoomStayReservationSpecified
        {
            get
            {
                return this.roomStayReservationFieldSpecified;
            }
            set
            {
                this.roomStayReservationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime CreateDateTime
        {
            get
            {
                return this.createDateTimeField;
            }
            set
            {
                this.createDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreateDateTimeSpecified
        {
            get
            {
                return this.createDateTimeFieldSpecified;
            }
            set
            {
                this.createDateTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CreatorID
        {
            get
            {
                return this.creatorIDField;
            }
            set
            {
                this.creatorIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastModifyDateTime
        {
            get
            {
                return this.lastModifyDateTimeField;
            }
            set
            {
                this.lastModifyDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastModifyDateTimeSpecified
        {
            get
            {
                return this.lastModifyDateTimeFieldSpecified;
            }
            set
            {
                this.lastModifyDateTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LastModifierID
        {
            get
            {
                return this.lastModifierIDField;
            }
            set
            {
                this.lastModifierIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime PurgeDate
        {
            get
            {
                return this.purgeDateField;
            }
            set
            {
                this.purgeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PurgeDateSpecified
        {
            get
            {
                return this.purgeDateFieldSpecified;
            }
            set
            {
                this.purgeDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResStatus
        {
            get
            {
                return this.resStatusField;
            }
            set
            {
                this.resStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ForcedSellIndicator
        {
            get
            {
                return this.forcedSellIndicatorField;
            }
            set
            {
                this.forcedSellIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ForcedSellIndicatorSpecified
        {
            get
            {
                return this.forcedSellIndicatorFieldSpecified;
            }
            set
            {
                this.forcedSellIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ServiceOverrideIndicator
        {
            get
            {
                return this.serviceOverrideIndicatorField;
            }
            set
            {
                this.serviceOverrideIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServiceOverrideIndicatorSpecified
        {
            get
            {
                return this.serviceOverrideIndicatorFieldSpecified;
            }
            set
            {
                this.serviceOverrideIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RateOverrideIndicator
        {
            get
            {
                return this.rateOverrideIndicatorField;
            }
            set
            {
                this.rateOverrideIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateOverrideIndicatorSpecified
        {
            get
            {
                return this.rateOverrideIndicatorFieldSpecified;
            }
            set
            {
                this.rateOverrideIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool WalkInIndicator
        {
            get
            {
                return this.walkInIndicatorField;
            }
            set
            {
                this.walkInIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WalkInIndicatorSpecified
        {
            get
            {
                return this.walkInIndicatorFieldSpecified;
            }
            set
            {
                this.walkInIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RoomNumberLockedIndicator
        {
            get
            {
                return this.roomNumberLockedIndicatorField;
            }
            set
            {
                this.roomNumberLockedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RoomNumberLockedIndicatorSpecified
        {
            get
            {
                return this.roomNumberLockedIndicatorFieldSpecified;
            }
            set
            {
                this.roomNumberLockedIndicatorFieldSpecified = value;
            }
        }
    }
}