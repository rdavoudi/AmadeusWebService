namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_InsurancePlanSearchRQ
    {

        private SourceType[] pOSField;

        private OTA_InsurancePlanSearchRQCoveragePreference[] coveragePreferencesField;

        private OTA_InsurancePlanSearchRQSearchTripInfo searchTripInfoField;

        private OTA_InsurancePlanSearchRQSearchFlightInfo searchFlightInfoField;

        private OTA_InsurancePlanSearchRQSearchTravInfo searchTravInfoField;

        private string echoTokenField;

        private System.DateTime timeStampField;

        private bool timeStampFieldSpecified;

        private OTA_InsurancePlanSearchRQTarget targetField;

        private decimal versionField;

        private string transactionIdentifierField;

        private string sequenceNmbrField;

        private OTA_InsurancePlanSearchRQTransactionStatusCode transactionStatusCodeField;

        private bool transactionStatusCodeFieldSpecified;

        private bool retransmissionIndicatorField;

        private bool retransmissionIndicatorFieldSpecified;

        private string searchResponseFilterField;

        private bool detailResponseField;

        public OTA_InsurancePlanSearchRQ()
        {
            this.targetField = OTA_InsurancePlanSearchRQTarget.Production;
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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CoveragePreference", IsNullable = false)]
        public OTA_InsurancePlanSearchRQCoveragePreference[] CoveragePreferences
        {
            get
            {
                return this.coveragePreferencesField;
            }
            set
            {
                this.coveragePreferencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public OTA_InsurancePlanSearchRQSearchTripInfo SearchTripInfo
        {
            get
            {
                return this.searchTripInfoField;
            }
            set
            {
                this.searchTripInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public OTA_InsurancePlanSearchRQSearchFlightInfo SearchFlightInfo
        {
            get
            {
                return this.searchFlightInfoField;
            }
            set
            {
                this.searchFlightInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public OTA_InsurancePlanSearchRQSearchTravInfo SearchTravInfo
        {
            get
            {
                return this.searchTravInfoField;
            }
            set
            {
                this.searchTravInfoField = value;
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
        [System.ComponentModel.DefaultValueAttribute(OTA_InsurancePlanSearchRQTarget.Production)]
        public OTA_InsurancePlanSearchRQTarget Target
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
        public OTA_InsurancePlanSearchRQTransactionStatusCode TransactionStatusCode
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
        public string SearchResponseFilter
        {
            get
            {
                return this.searchResponseFilterField;
            }
            set
            {
                this.searchResponseFilterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DetailResponse
        {
            get
            {
                return this.detailResponseField;
            }
            set
            {
                this.detailResponseField = value;
            }
        }
    }
}