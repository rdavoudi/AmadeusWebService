namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PricedItineraryType
    {

        private AirItineraryType airItineraryField;

        private AirItineraryPricingInfoType airItineraryPricingInfoField;

        private FreeTextType[] notesField;

        private PricedItineraryTypeTicketingInfo ticketingInfoField;

        private bool isOneWayCombinableField;

        private bool isOneWayCombinableFieldSpecified;

        private string currencyField;

        private string providerTypeField;

        private string sequenceNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AirItineraryType AirItinerary
        {
            get
            {
                return this.airItineraryField;
            }
            set
            {
                this.airItineraryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AirItineraryPricingInfoType AirItineraryPricingInfo
        {
            get
            {
                return this.airItineraryPricingInfoField;
            }
            set
            {
                this.airItineraryPricingInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Notes", Order = 2)]
        public FreeTextType[] Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public PricedItineraryTypeTicketingInfo TicketingInfo
        {
            get
            {
                return this.ticketingInfoField;
            }
            set
            {
                this.ticketingInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsOneWayCombinable
        {
            get
            {
                return this.isOneWayCombinableField;
            }
            set
            {
                this.isOneWayCombinableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsOneWayCombinableSpecified
        {
            get
            {
                return this.isOneWayCombinableFieldSpecified;
            }
            set
            {
                this.isOneWayCombinableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProviderType
        {
            get
            {
                return this.providerTypeField;
            }
            set
            {
                this.providerTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string SequenceNumber
        {
            get
            {
                return this.sequenceNumberField;
            }
            set
            {
                this.sequenceNumberField = value;
            }
        }
    }
}