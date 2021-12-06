namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfResGuestsTypeResGuestResGuest
    {

        private ArrayOfProfilesTypeProfileInfoProfileInfo[] profilesField;

        private ArrayOfSpecialRequestTypeSpecialRequestSpecialRequest[] specialRequestsField;

        private ArrayOfCommentTypeCommentComment[] commentsField;

        private ArrayOfServiceRPHsTypeServiceRPHServiceRPH[] serviceRPHsField;

        private ArrayOfResGuestsTypeResGuestProfileRPHProfileRPH[] profileRPHsField;

        private TransportInfoType arrivalTransportField;

        private TransportInfoType departureTransportField;

        private GuestCountType guestCountsField;

        private DateTimeSpanType inHouseTimeSpanField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private string resGuestRPHField;

        private string ageQualifyingCodeField;

        private System.DateTime arrivalTimeField;

        private bool arrivalTimeFieldSpecified;

        private System.DateTime departureTimeField;

        private bool departureTimeFieldSpecified;

        private string groupEventCodeField;

        private bool vIPField;

        private bool vIPFieldSpecified;

        private bool primaryIndicatorField;

        private bool primaryIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileInfo", IsNullable = false)]
        public ArrayOfProfilesTypeProfileInfoProfileInfo[] Profiles
        {
            get
            {
                return this.profilesField;
            }
            set
            {
                this.profilesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SpecialRequest", IsNullable = false)]
        public ArrayOfSpecialRequestTypeSpecialRequestSpecialRequest[] SpecialRequests
        {
            get
            {
                return this.specialRequestsField;
            }
            set
            {
                this.specialRequestsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Comment", IsNullable = false)]
        public ArrayOfCommentTypeCommentComment[] Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileRPH", IsNullable = false)]
        public ArrayOfResGuestsTypeResGuestProfileRPHProfileRPH[] ProfileRPHs
        {
            get
            {
                return this.profileRPHsField;
            }
            set
            {
                this.profileRPHsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TransportInfoType ArrivalTransport
        {
            get
            {
                return this.arrivalTransportField;
            }
            set
            {
                this.arrivalTransportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public TransportInfoType DepartureTransport
        {
            get
            {
                return this.departureTransportField;
            }
            set
            {
                this.departureTransportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public DateTimeSpanType InHouseTimeSpan
        {
            get
            {
                return this.inHouseTimeSpanField;
            }
            set
            {
                this.inHouseTimeSpanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
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
        public string ResGuestRPH
        {
            get
            {
                return this.resGuestRPHField;
            }
            set
            {
                this.resGuestRPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgeQualifyingCode
        {
            get
            {
                return this.ageQualifyingCodeField;
            }
            set
            {
                this.ageQualifyingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime ArrivalTime
        {
            get
            {
                return this.arrivalTimeField;
            }
            set
            {
                this.arrivalTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArrivalTimeSpecified
        {
            get
            {
                return this.arrivalTimeFieldSpecified;
            }
            set
            {
                this.arrivalTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime DepartureTime
        {
            get
            {
                return this.departureTimeField;
            }
            set
            {
                this.departureTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepartureTimeSpecified
        {
            get
            {
                return this.departureTimeFieldSpecified;
            }
            set
            {
                this.departureTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GroupEventCode
        {
            get
            {
                return this.groupEventCodeField;
            }
            set
            {
                this.groupEventCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool VIP
        {
            get
            {
                return this.vIPField;
            }
            set
            {
                this.vIPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VIPSpecified
        {
            get
            {
                return this.vIPFieldSpecified;
            }
            set
            {
                this.vIPFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PrimaryIndicator
        {
            get
            {
                return this.primaryIndicatorField;
            }
            set
            {
                this.primaryIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrimaryIndicatorSpecified
        {
            get
            {
                return this.primaryIndicatorFieldSpecified;
            }
            set
            {
                this.primaryIndicatorFieldSpecified = value;
            }
        }
    }
}