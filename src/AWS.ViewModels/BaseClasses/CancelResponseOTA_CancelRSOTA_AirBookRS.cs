namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CancelResponseOTA_CancelRSOTA_AirBookRS
    {

        private AirItineraryPricingInfoType newPriceField;

        private AirlineServicePricingType newAirlineServicePriceField;

        private FailbackRS failbackField;

        private AirItineraryPricingInfoType oldPriceField;

        private CancelResponseOTA_CancelRSOTA_AirBookRSAirReservation airReservationField;

        private object[] itemsField;

        private BookingToBeCancelled bookingToBeCancelledField;

        private string referenceNumberField;

        private string paymentRequestURLField;

        private bool cancelField;

        private string echoTokenField;

        private System.DateTime timeStampField;

        private bool timeStampFieldSpecified;

        private CancelResponseOTA_CancelRSOTA_AirBookRSTarget targetField;

        private decimal versionField;

        private string transactionIdentifierField;

        private string sequenceNmbrField;

        private CancelResponseOTA_CancelRSOTA_AirBookRSTransactionStatusCode transactionStatusCodeField;

        private bool transactionStatusCodeFieldSpecified;

        private bool retransmissionIndicatorField;

        private bool retransmissionIndicatorFieldSpecified;

        private bool priceIndField;

        private bool priceIndFieldSpecified;

        public CancelResponseOTA_CancelRSOTA_AirBookRS()
        {
            this.cancelField = false;
            this.targetField = CancelResponseOTA_CancelRSOTA_AirBookRSTarget.Production;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AirItineraryPricingInfoType NewPrice
        {
            get
            {
                return this.newPriceField;
            }
            set
            {
                this.newPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AirlineServicePricingType NewAirlineServicePrice
        {
            get
            {
                return this.newAirlineServicePriceField;
            }
            set
            {
                this.newAirlineServicePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public FailbackRS Failback
        {
            get
            {
                return this.failbackField;
            }
            set
            {
                this.failbackField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public AirItineraryPricingInfoType OldPrice
        {
            get
            {
                return this.oldPriceField;
            }
            set
            {
                this.oldPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public CancelResponseOTA_CancelRSOTA_AirBookRSAirReservation AirReservation
        {
            get
            {
                return this.airReservationField;
            }
            set
            {
                this.airReservationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Errors", typeof(ErrorsType), Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute("Success", typeof(SuccessType), Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute("Warnings", typeof(WarningsType), Order = 5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public BookingToBeCancelled BookingToBeCancelled
        {
            get
            {
                return this.bookingToBeCancelledField;
            }
            set
            {
                this.bookingToBeCancelledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceNumber
        {
            get
            {
                return this.referenceNumberField;
            }
            set
            {
                this.referenceNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentRequestURL
        {
            get
            {
                return this.paymentRequestURLField;
            }
            set
            {
                this.paymentRequestURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Cancel
        {
            get
            {
                return this.cancelField;
            }
            set
            {
                this.cancelField = value;
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
        [System.ComponentModel.DefaultValueAttribute(CancelResponseOTA_CancelRSOTA_AirBookRSTarget.Production)]
        public CancelResponseOTA_CancelRSOTA_AirBookRSTarget Target
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
        public CancelResponseOTA_CancelRSOTA_AirBookRSTransactionStatusCode TransactionStatusCode
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
        public bool PriceInd
        {
            get
            {
                return this.priceIndField;
            }
            set
            {
                this.priceIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceIndSpecified
        {
            get
            {
                return this.priceIndFieldSpecified;
            }
            set
            {
                this.priceIndFieldSpecified = value;
            }
        }
    }
}