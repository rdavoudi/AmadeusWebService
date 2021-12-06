namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehRateRuleRS
    {

        private object[] itemsField;

        private string echoTokenField;

        private System.DateTime timeStampField;

        private bool timeStampFieldSpecified;

        private OTA_VehRateRuleRSTarget targetField;

        private decimal versionField;

        private string transactionIdentifierField;

        private string sequenceNmbrField;

        private OTA_VehRateRuleRSTransactionStatusCode transactionStatusCodeField;

        private bool transactionStatusCodeFieldSpecified;

        private bool retransmissionIndicatorField;

        private bool retransmissionIndicatorFieldSpecified;

        public OTA_VehRateRuleRS()
        {
            this.targetField = OTA_VehRateRuleRSTarget.Production;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Errors", typeof(ErrorsType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Fees", typeof(OTA_VehRateRuleRSFees), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("LocationDetails", typeof(OTA_VehRateRuleRSLocationDetails), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("PricedCoverages", typeof(OTA_VehRateRuleRSPricedCoverages), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("PricedEquips", typeof(OTA_VehRateRuleRSPricedEquips), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("RateRules", typeof(OTA_VehRateRuleRSRateRules), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("RentalRate", typeof(OTA_VehRateRuleRSRentalRate), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Success", typeof(SuccessType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("TPA_Extensions", typeof(TPA_ExtensionsType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("TotalCharge", typeof(OTA_VehRateRuleRSTotalCharge), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("VehRentalCore", typeof(OTA_VehRateRuleRSVehRentalCore), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Vehicle", typeof(OTA_VehRateRuleRSVehicle), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("VendorMessages", typeof(VendorMessagesType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Warnings", typeof(WarningsType), Order = 0)]
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
        [System.ComponentModel.DefaultValueAttribute(OTA_VehRateRuleRSTarget.Production)]
        public OTA_VehRateRuleRSTarget Target
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
        public OTA_VehRateRuleRSTransactionStatusCode TransactionStatusCode
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
    }
}