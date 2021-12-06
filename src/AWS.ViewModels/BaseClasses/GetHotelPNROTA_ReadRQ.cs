namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetHotelPNROTA_ReadRQ
    {

        private SourceType[] pOSField;

        private UniqueID_Type bookingReferenceIDField;

        private GetHotelPNROTA_ReadRQReadRequests readRequestsField;

        private string echoTokenField;

        private System.DateTime timeStampField;

        private bool timeStampFieldSpecified;

        private GetHotelPNROTA_ReadRQTarget targetField;

        private decimal versionField;

        private string transactionIdentifierField;

        private string sequenceNmbrField;

        private GetHotelPNROTA_ReadRQTransactionStatusCode transactionStatusCodeField;

        private bool transactionStatusCodeFieldSpecified;

        private bool retransmissionIndicatorField;

        private bool retransmissionIndicatorFieldSpecified;

        private string reqRespVersionField;

        private string reservationTypeField;

        private bool returnListIndicatorField;

        private bool returnListIndicatorFieldSpecified;

        private bool moreIndicatorField;

        private bool moreIndicatorFieldSpecified;

        private string moreDataEchoTokenField;

        public GetHotelPNROTA_ReadRQ()
        {
            this.targetField = GetHotelPNROTA_ReadRQTarget.Production;
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public GetHotelPNROTA_ReadRQReadRequests ReadRequests
        {
            get
            {
                return this.readRequestsField;
            }
            set
            {
                this.readRequestsField = value;
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
        [System.ComponentModel.DefaultValueAttribute(GetHotelPNROTA_ReadRQTarget.Production)]
        public GetHotelPNROTA_ReadRQTarget Target
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
        public GetHotelPNROTA_ReadRQTransactionStatusCode TransactionStatusCode
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
        public string ReservationType
        {
            get
            {
                return this.reservationTypeField;
            }
            set
            {
                this.reservationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReturnListIndicator
        {
            get
            {
                return this.returnListIndicatorField;
            }
            set
            {
                this.returnListIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnListIndicatorSpecified
        {
            get
            {
                return this.returnListIndicatorFieldSpecified;
            }
            set
            {
                this.returnListIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MoreIndicator
        {
            get
            {
                return this.moreIndicatorField;
            }
            set
            {
                this.moreIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MoreIndicatorSpecified
        {
            get
            {
                return this.moreIndicatorFieldSpecified;
            }
            set
            {
                this.moreIndicatorFieldSpecified = value;
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
    }
}