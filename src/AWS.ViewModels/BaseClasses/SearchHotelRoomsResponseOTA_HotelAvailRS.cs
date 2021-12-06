namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchHotelRoomsResponseOTA_HotelAvailRS
    {

        private SourceType[] pOSField;

        private object[] itemsField;

        private string echoTokenField;

        private System.DateTime timeStampField;

        private bool timeStampFieldSpecified;

        private SearchHotelRoomsResponseOTA_HotelAvailRSTarget targetField;

        private decimal versionField;

        private string transactionIdentifierField;

        private string sequenceNmbrField;

        private SearchHotelRoomsResponseOTA_HotelAvailRSTransactionStatusCode transactionStatusCodeField;

        private bool transactionStatusCodeFieldSpecified;

        private bool retransmissionIndicatorField;

        private bool retransmissionIndicatorFieldSpecified;

        private SearchHotelRoomsResponseOTA_HotelAvailRSSearchCacheLevel searchCacheLevelField;

        private bool searchCacheLevelFieldSpecified;

        public SearchHotelRoomsResponseOTA_HotelAvailRS()
        {
            this.targetField = SearchHotelRoomsResponseOTA_HotelAvailRSTarget.Production;
        }

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
        [System.Xml.Serialization.XmlElementAttribute("Areas", typeof(ArrayOfAreasTypeArea), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("Criteria", typeof(HotelSearchCriterionType[]), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("Errors", typeof(ErrorsType), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("HotelStays", typeof(ArrayOfOTA_HotelAvailRSHotelStaysHotelStay), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("Profiles", typeof(ArrayOfProfilesTypeProfileInfo1), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("RoomStays", typeof(SearchHotelRoomsResponseOTA_HotelAvailRSRoomStays), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("Services", typeof(ArrayOfServicesTypeService1), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("Success", typeof(SuccessType), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("TPA_Extensions", typeof(TPA_ExtensionsType), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("Warnings", typeof(WarningType[]), Order = 1)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EchoToken
        {
            get
            {
                return this.echoTokenField;
            }
            set
            {
                this.echoTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this.timeStampField;
            }
            set
            {
                this.timeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeStampSpecified
        {
            get
            {
                return this.timeStampFieldSpecified;
            }
            set
            {
                this.timeStampFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SearchHotelRoomsResponseOTA_HotelAvailRSTarget.Production)]
        public SearchHotelRoomsResponseOTA_HotelAvailRSTarget Target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransactionIdentifier
        {
            get
            {
                return this.transactionIdentifierField;
            }
            set
            {
                this.transactionIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string SequenceNmbr
        {
            get
            {
                return this.sequenceNmbrField;
            }
            set
            {
                this.sequenceNmbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SearchHotelRoomsResponseOTA_HotelAvailRSTransactionStatusCode TransactionStatusCode
        {
            get
            {
                return this.transactionStatusCodeField;
            }
            set
            {
                this.transactionStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionStatusCodeSpecified
        {
            get
            {
                return this.transactionStatusCodeFieldSpecified;
            }
            set
            {
                this.transactionStatusCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RetransmissionIndicator
        {
            get
            {
                return this.retransmissionIndicatorField;
            }
            set
            {
                this.retransmissionIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RetransmissionIndicatorSpecified
        {
            get
            {
                return this.retransmissionIndicatorFieldSpecified;
            }
            set
            {
                this.retransmissionIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SearchHotelRoomsResponseOTA_HotelAvailRSSearchCacheLevel SearchCacheLevel
        {
            get
            {
                return this.searchCacheLevelField;
            }
            set
            {
                this.searchCacheLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SearchCacheLevelSpecified
        {
            get
            {
                return this.searchCacheLevelFieldSpecified;
            }
            set
            {
                this.searchCacheLevelFieldSpecified = value;
            }
        }
    }
}