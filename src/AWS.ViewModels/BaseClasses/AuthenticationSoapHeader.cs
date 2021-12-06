
namespace AWS.ViewModels.BaseClasses
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AuthenticationSoapHeader
    {
        private string wSUserNameField;

        private string wSPasswordField;

        private string wSCultureInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string WSUserName
        {
            get
            {
                return this.wSUserNameField;
            }
            set
            {
                this.wSUserNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string WSPassword
        {
            get
            {
                return this.wSPasswordField;
            }
            set
            {
                this.wSPasswordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string WSCultureInfo
        {
            get
            {
                return this.wSCultureInfoField;
            }
            set
            {
                this.wSCultureInfoField = value;
            }
        }
    }

    //public partial class PingResponseOTA_PingRS
    //{

    //    private object[] itemsField;

    //    private string echoTokenField;

    //    private System.DateTime timeStampField;

    //    private bool timeStampFieldSpecified;

    //    private PingResponseOTA_PingRSTarget targetField;

    //    private decimal versionField;

    //    private string transactionIdentifierField;

    //    private string sequenceNmbrField;

    //    private PingResponseOTA_PingRSTransactionStatusCode transactionStatusCodeField;

    //    private bool transactionStatusCodeFieldSpecified;

    //    private bool retransmissionIndicatorField;

    //    private bool retransmissionIndicatorFieldSpecified;

    //    public PingResponseOTA_PingRS()
    //    {
    //        this.targetField = PingResponseOTA_PingRSTarget.Production;
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute("EchoData", typeof(string), Order = 0)]
    //    [System.Xml.Serialization.XmlElementAttribute("Errors", typeof(ErrorsType), Order = 0)]
    //    [System.Xml.Serialization.XmlElementAttribute("Success", typeof(SuccessType), Order = 0)]
    //    [System.Xml.Serialization.XmlElementAttribute("Warnings", typeof(WarningsType), Order = 0)]
    //    public object[] Items
    //    {
    //        get
    //        {
    //            return this.itemsField;
    //        }
    //        set
    //        {
    //            this.itemsField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string EchoToken
    //    {
    //        get
    //        {
    //            return this.echoTokenField;
    //        }
    //        set
    //        {
    //            this.echoTokenField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public System.DateTime TimeStamp
    //    {
    //        get
    //        {
    //            return this.timeStampField;
    //        }
    //        set
    //        {
    //            this.timeStampField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool TimeStampSpecified
    //    {
    //        get
    //        {
    //            return this.timeStampFieldSpecified;
    //        }
    //        set
    //        {
    //            this.timeStampFieldSpecified = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    [System.ComponentModel.DefaultValueAttribute(PingResponseOTA_PingRSTarget.Production)]
    //    public PingResponseOTA_PingRSTarget Target
    //    {
    //        get
    //        {
    //            return this.targetField;
    //        }
    //        set
    //        {
    //            this.targetField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    //[System.Xml.Serialization.XmlAttributeAttribute()]
    //    //[XmlElement(IsNullable = true)]
    //    //public decimal Version
    //    //{
    //    //    get
    //    //    {
    //    //        return this.versionField;
    //    //    }
    //    //    set
    //    //    {
    //    //        this.versionField = value;
    //    //    }
    //    //}

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string TransactionIdentifier
    //    {
    //        get
    //        {
    //            return this.transactionIdentifierField;
    //        }
    //        set
    //        {
    //            this.transactionIdentifierField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    //    public string SequenceNmbr
    //    {
    //        get
    //        {
    //            return this.sequenceNmbrField;
    //        }
    //        set
    //        {
    //            this.sequenceNmbrField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public PingResponseOTA_PingRSTransactionStatusCode TransactionStatusCode
    //    {
    //        get
    //        {
    //            return this.transactionStatusCodeField;
    //        }
    //        set
    //        {
    //            this.transactionStatusCodeField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool TransactionStatusCodeSpecified
    //    {
    //        get
    //        {
    //            return this.transactionStatusCodeFieldSpecified;
    //        }
    //        set
    //        {
    //            this.transactionStatusCodeFieldSpecified = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public bool RetransmissionIndicator
    //    {
    //        get
    //        {
    //            return this.retransmissionIndicatorField;
    //        }
    //        set
    //        {
    //            this.retransmissionIndicatorField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool RetransmissionIndicatorSpecified
    //    {
    //        get
    //        {
    //            return this.retransmissionIndicatorFieldSpecified;
    //        }
    //        set
    //        {
    //            this.retransmissionIndicatorFieldSpecified = value;
    //        }
    //    }
    //}
}
