using System.Xml.Serialization;

namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    [XmlType("OTA_PingRQ")]
    public partial class PingOTA_PingRQ
    {

        private string echoDataField;

        private string echoTokenField;

        private System.DateTime timeStampField;

        private bool timeStampFieldSpecified;

        private PingOTA_PingRQTarget targetField;

        private decimal versionField;

        private string transactionIdentifierField;

        private string sequenceNmbrField;

        private PingOTA_PingRQTransactionStatusCode transactionStatusCodeField;

        private bool transactionStatusCodeFieldSpecified;

        private bool retransmissionIndicatorField;

        private bool retransmissionIndicatorFieldSpecified;

        public PingOTA_PingRQ()
        {
            this.targetField = PingOTA_PingRQTarget.Test;
        }

        /// <remarks/>
        [XmlElement(Order = 0)]
        public string EchoData
        {
            get
            {
                return this.echoDataField;
            }
            set
            {
                this.echoDataField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
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
        [XmlAttribute()]
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
        [XmlIgnore()]
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
        [XmlAttribute()]
        [System.ComponentModel.DefaultValueAttribute(PingOTA_PingRQTarget.Test)]
        public PingOTA_PingRQTarget Target
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
        //[System.Xml.Serialization.XmlAttributeAttribute()]
        //public decimal Version
        //{
        //    get
        //    {
        //        return this.versionField;
        //    }
        //    set
        //    {
        //        this.versionField = value;
        //    }
        //}

        /// <remarks/>
        [XmlAttribute()]
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
        [XmlAttribute(DataType = "nonNegativeInteger")]
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
        [XmlAttribute()]
        public PingOTA_PingRQTransactionStatusCode TransactionStatusCode
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
        [XmlIgnore()]
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
        [XmlAttribute()]
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
        [XmlIgnore()]
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
    }
}