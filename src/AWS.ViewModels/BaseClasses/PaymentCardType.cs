namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PaymentCardType
    {

        private string cardHolderNameField;

        private PaymentCardTypeCardIssuerName cardIssuerNameField;

        private AddressType addressField;

        private PaymentCardTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private PaymentCardTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private string cardTypeField;

        private string securityNumberField;

        private string cardCodeField;

        private string cardNumberField;

        private string seriesCodeField;

        private string effectiveDateField;

        private System.DateTime expireDateField;

        private bool expireDateFieldSpecified;

        private string maskedCardNumberField;

        private string cardHolderRPHField;

        private bool extendPaymentIndicatorField;

        private bool extendPaymentIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string CardHolderName
        {
            get
            {
                return this.cardHolderNameField;
            }
            set
            {
                this.cardHolderNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public PaymentCardTypeCardIssuerName CardIssuerName
        {
            get
            {
                return this.cardIssuerNameField;
            }
            set
            {
                this.cardIssuerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public AddressType Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentCardTypeShareSynchInd ShareSynchInd
        {
            get
            {
                return this.shareSynchIndField;
            }
            set
            {
                this.shareSynchIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShareSynchIndSpecified
        {
            get
            {
                return this.shareSynchIndFieldSpecified;
            }
            set
            {
                this.shareSynchIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentCardTypeShareMarketInd ShareMarketInd
        {
            get
            {
                return this.shareMarketIndField;
            }
            set
            {
                this.shareMarketIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShareMarketIndSpecified
        {
            get
            {
                return this.shareMarketIndFieldSpecified;
            }
            set
            {
                this.shareMarketIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CardType
        {
            get
            {
                return this.cardTypeField;
            }
            set
            {
                this.cardTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SecurityNumber
        {
            get
            {
                return this.securityNumberField;
            }
            set
            {
                this.securityNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CardCode
        {
            get
            {
                return this.cardCodeField;
            }
            set
            {
                this.cardCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CardNumber
        {
            get
            {
                return this.cardNumberField;
            }
            set
            {
                this.cardNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeriesCode
        {
            get
            {
                return this.seriesCodeField;
            }
            set
            {
                this.seriesCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EffectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpireDateSpecified
        {
            get
            {
                return this.expireDateFieldSpecified;
            }
            set
            {
                this.expireDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MaskedCardNumber
        {
            get
            {
                return this.maskedCardNumberField;
            }
            set
            {
                this.maskedCardNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CardHolderRPH
        {
            get
            {
                return this.cardHolderRPHField;
            }
            set
            {
                this.cardHolderRPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExtendPaymentIndicator
        {
            get
            {
                return this.extendPaymentIndicatorField;
            }
            set
            {
                this.extendPaymentIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExtendPaymentIndicatorSpecified
        {
            get
            {
                return this.extendPaymentIndicatorFieldSpecified;
            }
            set
            {
                this.extendPaymentIndicatorFieldSpecified = value;
            }
        }
    }
}