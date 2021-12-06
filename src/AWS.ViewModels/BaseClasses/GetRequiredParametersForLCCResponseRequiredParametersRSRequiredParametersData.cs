namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetRequiredParametersForLCCResponseRequiredParametersRSRequiredParametersData
    {

        private LCCRequiredParameter[] requiredParametersOnProcessDetailsField;

        private LCCSupportedCard[] lCCSupportedCardListField;

        private LCCBaggageFee[] lCCBaggageFeeListField;

        private LCCBaggageFee[] outwardLuggageOptionsField;

        private LCCBaggageFee[] returnLuggageOptionsField;

        private LCCBaggageFee[] lCCHandLuggageFeeListField;

        private LCCOtherFee[] lCCOtherFeeListField;

        private LCCCheckInOption[] lCCCheckInOptionListField;

        private string lCCRuleLinkField;

        private string baggageAllowanceNoteField;

        private string supplierNameField;

        private string supplierCodeField;

        private int itineraryIndexField;

        private bool itineraryIndexFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public LCCRequiredParameter[] RequiredParametersOnProcessDetails
        {
            get
            {
                return this.requiredParametersOnProcessDetailsField;
            }
            set
            {
                this.requiredParametersOnProcessDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        public LCCSupportedCard[] LCCSupportedCardList
        {
            get
            {
                return this.lCCSupportedCardListField;
            }
            set
            {
                this.lCCSupportedCardListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        public LCCBaggageFee[] LCCBaggageFeeList
        {
            get
            {
                return this.lCCBaggageFeeListField;
            }
            set
            {
                this.lCCBaggageFeeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        public LCCBaggageFee[] OutwardLuggageOptions
        {
            get
            {
                return this.outwardLuggageOptionsField;
            }
            set
            {
                this.outwardLuggageOptionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        public LCCBaggageFee[] ReturnLuggageOptions
        {
            get
            {
                return this.returnLuggageOptionsField;
            }
            set
            {
                this.returnLuggageOptionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        public LCCBaggageFee[] LCCHandLuggageFeeList
        {
            get
            {
                return this.lCCHandLuggageFeeListField;
            }
            set
            {
                this.lCCHandLuggageFeeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 6)]
        public LCCOtherFee[] LCCOtherFeeList
        {
            get
            {
                return this.lCCOtherFeeListField;
            }
            set
            {
                this.lCCOtherFeeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 7)]
        public LCCCheckInOption[] LCCCheckInOptionList
        {
            get
            {
                return this.lCCCheckInOptionListField;
            }
            set
            {
                this.lCCCheckInOptionListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string LCCRuleLink
        {
            get
            {
                return this.lCCRuleLinkField;
            }
            set
            {
                this.lCCRuleLinkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string BaggageAllowanceNote
        {
            get
            {
                return this.baggageAllowanceNoteField;
            }
            set
            {
                this.baggageAllowanceNoteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string SupplierName
        {
            get
            {
                return this.supplierNameField;
            }
            set
            {
                this.supplierNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string SupplierCode
        {
            get
            {
                return this.supplierCodeField;
            }
            set
            {
                this.supplierCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ItineraryIndex
        {
            get
            {
                return this.itineraryIndexField;
            }
            set
            {
                this.itineraryIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItineraryIndexSpecified
        {
            get
            {
                return this.itineraryIndexFieldSpecified;
            }
            set
            {
                this.itineraryIndexFieldSpecified = value;
            }
        }
    }
}