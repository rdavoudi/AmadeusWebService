namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FareType
    {

        private FareTypeBaseFare baseFareField;

        private FareTypeMarkupFare markupFareField;

        private FareTypeEquivFare equivFareField;

        private AirTaxType[] taxesField;

        private AirFeeType[] feesField;

        private FareTypeTotalFare totalFareField;

        private FareTypeTotalAmountInTicketingCurrency totalAmountInTicketingCurrencyField;

        private FareTypeFareConstruction fareConstructionField;

        private FareTypeUnstructuredFareCalc unstructuredFareCalcField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private bool negotiatedFareField;

        private string negotiatedFareCodeField;

        private string ticketDesignatorCodeField;

        private string totalNbrTripsField;

        private string totalNbrPTCField;

        public FareType()
        {
            this.negotiatedFareField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public FareTypeBaseFare BaseFare
        {
            get
            {
                return this.baseFareField;
            }
            set
            {
                this.baseFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public FareTypeMarkupFare MarkupFare
        {
            get
            {
                return this.markupFareField;
            }
            set
            {
                this.markupFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public FareTypeEquivFare EquivFare
        {
            get
            {
                return this.equivFareField;
            }
            set
            {
                this.equivFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Tax", IsNullable = false)]
        public AirTaxType[] Taxes
        {
            get
            {
                return this.taxesField;
            }
            set
            {
                this.taxesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable = false)]
        public AirFeeType[] Fees
        {
            get
            {
                return this.feesField;
            }
            set
            {
                this.feesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public FareTypeTotalFare TotalFare
        {
            get
            {
                return this.totalFareField;
            }
            set
            {
                this.totalFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public FareTypeTotalAmountInTicketingCurrency TotalAmountInTicketingCurrency
        {
            get
            {
                return this.totalAmountInTicketingCurrencyField;
            }
            set
            {
                this.totalAmountInTicketingCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public FareTypeFareConstruction FareConstruction
        {
            get
            {
                return this.fareConstructionField;
            }
            set
            {
                this.fareConstructionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public FareTypeUnstructuredFareCalc UnstructuredFareCalc
        {
            get
            {
                return this.unstructuredFareCalcField;
            }
            set
            {
                this.unstructuredFareCalcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
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
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool NegotiatedFare
        {
            get
            {
                return this.negotiatedFareField;
            }
            set
            {
                this.negotiatedFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NegotiatedFareCode
        {
            get
            {
                return this.negotiatedFareCodeField;
            }
            set
            {
                this.negotiatedFareCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDesignatorCode
        {
            get
            {
                return this.ticketDesignatorCodeField;
            }
            set
            {
                this.ticketDesignatorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string TotalNbrTrips
        {
            get
            {
                return this.totalNbrTripsField;
            }
            set
            {
                this.totalNbrTripsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string TotalNbrPTC
        {
            get
            {
                return this.totalNbrPTCField;
            }
            set
            {
                this.totalNbrPTCField = value;
            }
        }
    }
}