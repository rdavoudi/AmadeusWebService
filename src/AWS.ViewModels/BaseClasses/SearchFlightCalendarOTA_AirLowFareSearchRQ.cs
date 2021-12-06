namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightCalendarOTA_AirLowFareSearchRQ
    {

        private SourceType[] pOSField;

        private SearchFlightCalendarOTA_AirLowFareSearchRQProcessingInfo processingInfoField;

        private SearchFlightCalendarOTA_AirLowFareSearchRQOriginDestinationInformation[] originDestinationInformationField;

        private SpecificFlightInfoType specificFlightInfoField;

        private SearchFlightCalendarOTA_AirLowFareSearchRQTravelPreferences[] travelPreferencesField;

        private SearchFlightCalendarOTA_AirLowFareSearchRQTravelerInfoSummary travelerInfoSummaryField;

        private SearchFlightCalendarOTA_AirLowFareSearchRQAdvanceSearchInfo advanceSearchInfoField;

        private string metaLinkField;

        private RefundableTypesEnum refundableTypeField;

        private decimal maxPriceField;

        private SearchTypeByProviderEnum providerTypeField;

        private string echoTokenField;

        private System.DateTime timeStampField;

        private bool timeStampFieldSpecified;

        private SearchFlightCalendarOTA_AirLowFareSearchRQTarget targetField;

        private decimal versionField;

        private string transactionIdentifierField;

        private string sequenceNmbrField;

        private SearchFlightCalendarOTA_AirLowFareSearchRQTransactionStatusCode transactionStatusCodeField;

        private bool transactionStatusCodeFieldSpecified;

        private bool retransmissionIndicatorField;

        private bool retransmissionIndicatorFieldSpecified;

        private string maxResponsesField;

        private bool directFlightsOnlyField;

        private bool availableFlightsOnlyField;

        private bool availableFlightsOnlyFieldSpecified;

        private bool forMetaBookField;

        public SearchFlightCalendarOTA_AirLowFareSearchRQ()
        {
            this.targetField = SearchFlightCalendarOTA_AirLowFareSearchRQTarget.Production;
            this.directFlightsOnlyField = false;
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
        public SearchFlightCalendarOTA_AirLowFareSearchRQProcessingInfo ProcessingInfo
        {
            get
            {
                return this.processingInfoField;
            }
            set
            {
                this.processingInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OriginDestinationInformation", Order = 2)]
        public SearchFlightCalendarOTA_AirLowFareSearchRQOriginDestinationInformation[] OriginDestinationInformation
        {
            get
            {
                return this.originDestinationInformationField;
            }
            set
            {
                this.originDestinationInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public SpecificFlightInfoType SpecificFlightInfo
        {
            get
            {
                return this.specificFlightInfoField;
            }
            set
            {
                this.specificFlightInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TravelPreferences", Order = 4)]
        public SearchFlightCalendarOTA_AirLowFareSearchRQTravelPreferences[] TravelPreferences
        {
            get
            {
                return this.travelPreferencesField;
            }
            set
            {
                this.travelPreferencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public SearchFlightCalendarOTA_AirLowFareSearchRQTravelerInfoSummary TravelerInfoSummary
        {
            get
            {
                return this.travelerInfoSummaryField;
            }
            set
            {
                this.travelerInfoSummaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public SearchFlightCalendarOTA_AirLowFareSearchRQAdvanceSearchInfo AdvanceSearchInfo
        {
            get
            {
                return this.advanceSearchInfoField;
            }
            set
            {
                this.advanceSearchInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string MetaLink
        {
            get
            {
                return this.metaLinkField;
            }
            set
            {
                this.metaLinkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RefundableTypesEnum RefundableType
        {
            get
            {
                return this.refundableTypeField;
            }
            set
            {
                this.refundableTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MaxPrice
        {
            get
            {
                return this.maxPriceField;
            }
            set
            {
                this.maxPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SearchTypeByProviderEnum ProviderType
        {
            get
            {
                return this.providerTypeField;
            }
            set
            {
                this.providerTypeField = value;
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
        [System.ComponentModel.DefaultValueAttribute(SearchFlightCalendarOTA_AirLowFareSearchRQTarget.Production)]
        public SearchFlightCalendarOTA_AirLowFareSearchRQTarget Target
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
        public SearchFlightCalendarOTA_AirLowFareSearchRQTransactionStatusCode TransactionStatusCode
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
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DirectFlightsOnly
        {
            get
            {
                return this.directFlightsOnlyField;
            }
            set
            {
                this.directFlightsOnlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AvailableFlightsOnly
        {
            get
            {
                return this.availableFlightsOnlyField;
            }
            set
            {
                this.availableFlightsOnlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AvailableFlightsOnlySpecified
        {
            get
            {
                return this.availableFlightsOnlyFieldSpecified;
            }
            set
            {
                this.availableFlightsOnlyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ForMetaBook
        {
            get
            {
                return this.forMetaBookField;
            }
            set
            {
                this.forMetaBookField = value;
            }
        }
    }
}