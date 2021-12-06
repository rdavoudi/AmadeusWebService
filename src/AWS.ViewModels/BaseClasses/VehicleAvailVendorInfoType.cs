namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleAvailVendorInfoType
    {

        private VendorMessageType[] vendorMessagesField;

        private OffLocationServicePricedType[] offLocServicesField;

        private MonetaryRuleType[] paymentRulesField;

        private VehicleLocationDetailsType[] locationDetailsField;

        private VehicleTourInfoType tourInfoField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("VendorMessage", IsNullable = false)]
        public VendorMessageType[] VendorMessages
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
        [System.Xml.Serialization.XmlElementAttribute("OffLocServices", Order = 1)]
        public OffLocationServicePricedType[] OffLocServices
        {
            get
            {
                return this.offLocServicesField;
            }
            set
            {
                this.offLocServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute("LocationDetails", Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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
    }
}