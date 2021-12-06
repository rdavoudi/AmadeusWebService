namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfOTA_HotelAvailRSRoomStaysRoomStayRoomStay : RoomStayType
    {

        private ArrayOfOTA_HotelAvailRSRoomStaysRoomStayRoomStayReference referenceField;

        private ArrayOfServiceRPHsTypeServiceRPHServiceRPH[] serviceRPHsField;

        private string roomIDField;

        private bool isAlternateField;

        private RateIndicatorType availabilityStatusField;

        private bool availabilityStatusFieldSpecified;

        private ArrayOfOTA_HotelAvailRSRoomStaysRoomStayRoomStayResponseType responseTypeField;

        private string roomStayCandidateRPHField;

        private string moreDataEchoTokenField;

        private string infoSourceField;

        private string rPHField;

        private bool availableIndicatorField;

        private bool availableIndicatorFieldSpecified;

        public ArrayOfOTA_HotelAvailRSRoomStaysRoomStayRoomStay()
        {
            this.isAlternateField = false;
            this.responseTypeField = ArrayOfOTA_HotelAvailRSRoomStaysRoomStayRoomStayResponseType.PropertyList;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ArrayOfOTA_HotelAvailRSRoomStaysRoomStayRoomStayReference Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ServiceRPH", IsNullable = false)]
        public ArrayOfServiceRPHsTypeServiceRPHServiceRPH[] ServiceRPHs
        {
            get
            {
                return this.serviceRPHsField;
            }
            set
            {
                this.serviceRPHsField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
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
        [System.ComponentModel.DefaultValueAttribute(ArrayOfOTA_HotelAvailRSRoomStaysRoomStayRoomStayResponseType.PropertyList)]
        public ArrayOfOTA_HotelAvailRSRoomStaysRoomStayRoomStayResponseType ResponseType
        {
            get
            {
                return this.responseTypeField;
            }
            set
            {
                this.responseTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomStayCandidateRPH
        {
            get
            {
                return this.roomStayCandidateRPHField;
            }
            set
            {
                this.roomStayCandidateRPHField = value;
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
        public string InfoSource
        {
            get
            {
                return this.infoSourceField;
            }
            set
            {
                this.infoSourceField = value;
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
        public bool AvailableIndicator
        {
            get
            {
                return this.availableIndicatorField;
            }
            set
            {
                this.availableIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AvailableIndicatorSpecified
        {
            get
            {
                return this.availableIndicatorFieldSpecified;
            }
            set
            {
                this.availableIndicatorFieldSpecified = value;
            }
        }
    }
}