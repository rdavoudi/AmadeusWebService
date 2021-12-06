namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CancelOTA_CancelRQ
    {

        private string pNRNoField;

        private UniqueID_Type bookingReferenceIDField;

        private SourceType[] pOSField;

        private CancelOTA_CancelRQUniqueID[] uniqueIDField;

        private VerificationType[] verificationField;

        private CancelOTA_CancelRQSegment[] segmentField;

        private CancelOTA_CancelRQCancellationOverrides cancellationOverridesField;

        private FreeTextType[] reasonsField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private string echoTokenField;

        private System.DateTime timeStampField;

        private bool timeStampFieldSpecified;

        private CancelOTA_CancelRQTarget targetField;

        private decimal versionField;

        private string transactionIdentifierField;

        private string sequenceNmbrField;

        private CancelOTA_CancelRQTransactionStatusCode transactionStatusCodeField;

        private bool transactionStatusCodeFieldSpecified;

        private bool retransmissionIndicatorField;

        private bool retransmissionIndicatorFieldSpecified;

        private string reqRespVersionField;

        private TransactionActionType cancelTypeField;

        private string travelSectorField;

        public CancelOTA_CancelRQ()
        {
            this.targetField = CancelOTA_CancelRQTarget.Production;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string PNRNo
        {
            get
            {
                return this.pNRNoField;
            }
            set
            {
                this.pNRNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public UniqueID_Type BookingReferenceID
        {
            get
            {
                return this.bookingReferenceIDField;
            }
            set
            {
                this.bookingReferenceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute("UniqueID", Order = 3)]
        public CancelOTA_CancelRQUniqueID[] UniqueID
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
        [System.Xml.Serialization.XmlElementAttribute("Verification", Order = 4)]
        public VerificationType[] Verification
        {
            get
            {
                return this.verificationField;
            }
            set
            {
                this.verificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Segment", Order = 5)]
        public CancelOTA_CancelRQSegment[] Segment
        {
            get
            {
                return this.segmentField;
            }
            set
            {
                this.segmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public CancelOTA_CancelRQCancellationOverrides CancellationOverrides
        {
            get
            {
                return this.cancellationOverridesField;
            }
            set
            {
                this.cancellationOverridesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Reason", IsNullable = false)]
        public FreeTextType[] Reasons
        {
            get
            {
                return this.reasonsField;
            }
            set
            {
                this.reasonsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
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
        [System.ComponentModel.DefaultValueAttribute(CancelOTA_CancelRQTarget.Production)]
        public CancelOTA_CancelRQTarget Target
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
        public CancelOTA_CancelRQTransactionStatusCode TransactionStatusCode
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
        public string ReqRespVersion
        {
            get
            {
                return this.reqRespVersionField;
            }
            set
            {
                this.reqRespVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransactionActionType CancelType
        {
            get
            {
                return this.cancelTypeField;
            }
            set
            {
                this.cancelTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelSector
        {
            get
            {
                return this.travelSectorField;
            }
            set
            {
                this.travelSectorField = value;
            }
        }
    }
}