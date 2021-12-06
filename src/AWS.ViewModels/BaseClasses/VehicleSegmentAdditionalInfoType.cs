namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleSegmentAdditionalInfoType
    {

        private MonetaryRuleType[] paymentRulesField;

        private PaymentDetailType[] rentalPaymentAmountField;

        private CoveragePricedType[] pricedCoveragesField;

        private OffLocationServicePricedType[] pricedOffLocServiceField;

        private FormattedTextType[] vendorMessagesField;

        private VehicleLocationDetailsType[] locationDetailsField;

        private VehicleTourInfoType tourInfoField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private bool writtenConfIndField;

        private bool writtenConfIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PaymentRule", IsNullable = false)]
        public MonetaryRuleType[] PaymentRules
        {
            get
            {
                return this.paymentRulesField;
            }
            set
            {
                this.paymentRulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RentalPaymentAmount", Order = 1)]
        public PaymentDetailType[] RentalPaymentAmount
        {
            get
            {
                return this.rentalPaymentAmountField;
            }
            set
            {
                this.rentalPaymentAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PricedCoverage", IsNullable = false)]
        public CoveragePricedType[] PricedCoverages
        {
            get
            {
                return this.pricedCoveragesField;
            }
            set
            {
                this.pricedCoveragesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PricedOffLocService", Order = 3)]
        public OffLocationServicePricedType[] PricedOffLocService
        {
            get
            {
                return this.pricedOffLocServiceField;
            }
            set
            {
                this.pricedOffLocServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("VendorMessage", IsNullable = false)]
        public FormattedTextType[] VendorMessages
        {
            get
            {
                return this.vendorMessagesField;
            }
            set
            {
                this.vendorMessagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LocationDetails", Order = 5)]
        public VehicleLocationDetailsType[] LocationDetails
        {
            get
            {
                return this.locationDetailsField;
            }
            set
            {
                this.locationDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public VehicleTourInfoType TourInfo
        {
            get
            {
                return this.tourInfoField;
            }
            set
            {
                this.tourInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
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
        public bool WrittenConfInd
        {
            get
            {
                return this.writtenConfIndField;
            }
            set
            {
                this.writtenConfIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WrittenConfIndSpecified
        {
            get
            {
                return this.writtenConfIndFieldSpecified;
            }
            set
            {
                this.writtenConfIndFieldSpecified = value;
            }
        }
    }
}