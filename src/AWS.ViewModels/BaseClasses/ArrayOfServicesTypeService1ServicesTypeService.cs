namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfServicesTypeService1ServicesTypeService
    {

        private AmountType[] priceField;

        private ResCommonDetailType serviceDetailsField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private PricingType servicePricingTypeField;

        private bool servicePricingTypeFieldSpecified;

        private PMS_ResStatusType reservationStatusTypeField;

        private bool reservationStatusTypeFieldSpecified;

        private string serviceRPHField;

        private string serviceInventoryCodeField;

        private string ratePlanCodeField;

        private string inventoryBlockCodeField;

        private bool priceGuaranteedField;

        private bool priceGuaranteedFieldSpecified;

        private bool inclusiveField;

        private bool inclusiveFieldSpecified;

        private string quantityField;

        private bool requestedIndicatorField;

        private bool requestedIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Price", Order = 0)]
        public AmountType[] Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ResCommonDetailType ServiceDetails
        {
            get
            {
                return this.serviceDetailsField;
            }
            set
            {
                this.serviceDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
        public PricingType ServicePricingType
        {
            get
            {
                return this.servicePricingTypeField;
            }
            set
            {
                this.servicePricingTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServicePricingTypeSpecified
        {
            get
            {
                return this.servicePricingTypeFieldSpecified;
            }
            set
            {
                this.servicePricingTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PMS_ResStatusType ReservationStatusType
        {
            get
            {
                return this.reservationStatusTypeField;
            }
            set
            {
                this.reservationStatusTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReservationStatusTypeSpecified
        {
            get
            {
                return this.reservationStatusTypeFieldSpecified;
            }
            set
            {
                this.reservationStatusTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ServiceRPH
        {
            get
            {
                return this.serviceRPHField;
            }
            set
            {
                this.serviceRPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ServiceInventoryCode
        {
            get
            {
                return this.serviceInventoryCodeField;
            }
            set
            {
                this.serviceInventoryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanCode
        {
            get
            {
                return this.ratePlanCodeField;
            }
            set
            {
                this.ratePlanCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InventoryBlockCode
        {
            get
            {
                return this.inventoryBlockCodeField;
            }
            set
            {
                this.inventoryBlockCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PriceGuaranteed
        {
            get
            {
                return this.priceGuaranteedField;
            }
            set
            {
                this.priceGuaranteedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceGuaranteedSpecified
        {
            get
            {
                return this.priceGuaranteedFieldSpecified;
            }
            set
            {
                this.priceGuaranteedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Inclusive
        {
            get
            {
                return this.inclusiveField;
            }
            set
            {
                this.inclusiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InclusiveSpecified
        {
            get
            {
                return this.inclusiveFieldSpecified;
            }
            set
            {
                this.inclusiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RequestedIndicator
        {
            get
            {
                return this.requestedIndicatorField;
            }
            set
            {
                this.requestedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequestedIndicatorSpecified
        {
            get
            {
                return this.requestedIndicatorFieldSpecified;
            }
            set
            {
                this.requestedIndicatorFieldSpecified = value;
            }
        }
    }
}