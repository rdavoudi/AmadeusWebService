namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OtherSrvcPrefType
    {

        private string otherSrvcNameField;

        private CompanyNamePrefType[] vendorPrefField;

        private LoyaltyPrefType[] loyaltyPrefField;

        private PaymentFormPrefType[] paymentFormPrefField;

        private SpecRequestPrefType[] specRequestPrefField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private PreferLevelType preferLevelField;

        private OtherSrvcPrefTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private OtherSrvcPrefTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private string travelPurposeField;

        public OtherSrvcPrefType()
        {
            this.preferLevelField = PreferLevelType.Preferred;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string OtherSrvcName
        {
            get
            {
                return this.otherSrvcNameField;
            }
            set
            {
                this.otherSrvcNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VendorPref", Order = 1)]
        public CompanyNamePrefType[] VendorPref
        {
            get
            {
                return this.vendorPrefField;
            }
            set
            {
                this.vendorPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyPref", Order = 2)]
        public LoyaltyPrefType[] LoyaltyPref
        {
            get
            {
                return this.loyaltyPrefField;
            }
            set
            {
                this.loyaltyPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentFormPref", Order = 3)]
        public PaymentFormPrefType[] PaymentFormPref
        {
            get
            {
                return this.paymentFormPrefField;
            }
            set
            {
                this.paymentFormPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecRequestPref", Order = 4)]
        public SpecRequestPrefType[] SpecRequestPref
        {
            get
            {
                return this.specRequestPrefField;
            }
            set
            {
                this.specRequestPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
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
        [System.ComponentModel.DefaultValueAttribute(PreferLevelType.Preferred)]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this.preferLevelField;
            }
            set
            {
                this.preferLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OtherSrvcPrefTypeShareSynchInd ShareSynchInd
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
        public OtherSrvcPrefTypeShareMarketInd ShareMarketInd
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
        public string TravelPurpose
        {
            get
            {
                return this.travelPurposeField;
            }
            set
            {
                this.travelPurposeField = value;
            }
        }
    }
}