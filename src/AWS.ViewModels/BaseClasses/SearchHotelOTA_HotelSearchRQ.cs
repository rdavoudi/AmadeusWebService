namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchHotelOTA_HotelSearchRQ
    {

        private SourceType[] pOSField;

        private HotelSearchCriteriaType criteriaField;

        private bool moreResultsField;

        private string echoTokenField;

        private System.DateTime timeStampField;

        private bool timeStampFieldSpecified;

        private SearchHotelOTA_HotelSearchRQTarget targetField;

        private decimal versionField;

        private string transactionIdentifierField;

        private string sequenceNmbrField;

        private SearchHotelOTA_HotelSearchRQTransactionStatusCode transactionStatusCodeField;

        private bool transactionStatusCodeFieldSpecified;

        private bool retransmissionIndicatorField;

        private bool retransmissionIndicatorFieldSpecified;

        private string maxResponsesField;

        private SearchHotelOTA_HotelSearchRQResponseType responseTypeField;

        private string rateCodesField;

        public SearchHotelOTA_HotelSearchRQ()
        {
            this.targetField = SearchHotelOTA_HotelSearchRQTarget.Production;
            this.responseTypeField = SearchHotelOTA_HotelSearchRQResponseType.PropertyList;
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public HotelSearchCriteriaType Criteria
        {
            get
            {
                return this.criteriaField;
            }
            set
            {
                this.criteriaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MoreResults
        {
            get
            {
                return this.moreResultsField;
            }
            set
            {
                this.moreResultsField = value;
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
        [System.ComponentModel.DefaultValueAttribute(SearchHotelOTA_HotelSearchRQTarget.Production)]
        public SearchHotelOTA_HotelSearchRQTarget Target
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
        public SearchHotelOTA_HotelSearchRQTransactionStatusCode TransactionStatusCode
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string MaxResponses
        {
            get
            {
                return this.maxResponsesField;
            }
            set
            {
                this.maxResponsesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SearchHotelOTA_HotelSearchRQResponseType.PropertyList)]
        public SearchHotelOTA_HotelSearchRQResponseType ResponseType
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
        public string RateCodes
        {
            get
            {
                return this.rateCodesField;
            }
            set
            {
                this.rateCodesField = value;
            }
        }
    }
}