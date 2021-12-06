namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetBasketPNROTA_ReadRQReadRequestsAirReadRequest
    {

        private SourceType[] pOSField;

        private CompanyNameType airlineField;

        private string flightNumberField;

        private LocationType departureAirportField;

        private System.DateTime departureDateField;

        private bool departureDateFieldSpecified;

        private PersonNameType nameField;

        private GetBasketPNROTA_ReadRQReadRequestsAirReadRequestTelephone telephoneField;

        private GetBasketPNROTA_ReadRQReadRequestsAirReadRequestCustLoyalty custLoyaltyField;

        private PaymentCardType creditCardInfoField;

        private TicketingInfoRS_Type ticketNumberField;

        private GetBasketPNROTA_ReadRQReadRequestsAirReadRequestQueueInfo queueInfoField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private string seatNumberField;

        private bool includeFF_EquivPartnerLevField;

        private bool includeFF_EquivPartnerLevFieldSpecified;

        private bool returnFF_NumberField;

        private bool returnFF_NumberFieldSpecified;

        private bool returnDownlineSegField;

        private bool returnDownlineSegFieldSpecified;

        private GetBasketPNROTA_ReadRQReadRequestsAirReadRequestInfoToReturn infoToReturnField;

        private bool infoToReturnFieldSpecified;

        private GetBasketPNROTA_ReadRQReadRequestsAirReadRequestFF_RequestCriteria fF_RequestCriteriaField;

        private bool fF_RequestCriteriaFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Source", IsNullable = false)]
        public SourceType[] POS
        {
            get
            {
                return this.pOSField;
            }
            set
            {
                this.pOSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CompanyNameType Airline
        {
            get
            {
                return this.airlineField;
            }
            set
            {
                this.airlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string FlightNumber
        {
            get
            {
                return this.flightNumberField;
            }
            set
            {
                this.flightNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public LocationType DepartureAirport
        {
            get
            {
                return this.departureAirportField;
            }
            set
            {
                this.departureAirportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 4)]
        public System.DateTime DepartureDate
        {
            get
            {
                return this.departureDateField;
            }
            set
            {
                this.departureDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepartureDateSpecified
        {
            get
            {
                return this.departureDateFieldSpecified;
            }
            set
            {
                this.departureDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public PersonNameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public GetBasketPNROTA_ReadRQReadRequestsAirReadRequestTelephone Telephone
        {
            get
            {
                return this.telephoneField;
            }
            set
            {
                this.telephoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public GetBasketPNROTA_ReadRQReadRequestsAirReadRequestCustLoyalty CustLoyalty
        {
            get
            {
                return this.custLoyaltyField;
            }
            set
            {
                this.custLoyaltyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public PaymentCardType CreditCardInfo
        {
            get
            {
                return this.creditCardInfoField;
            }
            set
            {
                this.creditCardInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public TicketingInfoRS_Type TicketNumber
        {
            get
            {
                return this.ticketNumberField;
            }
            set
            {
                this.ticketNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public GetBasketPNROTA_ReadRQReadRequestsAirReadRequestQueueInfo QueueInfo
        {
            get
            {
                return this.queueInfoField;
            }
            set
            {
                this.queueInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
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
        public string SeatNumber
        {
            get
            {
                return this.seatNumberField;
            }
            set
            {
                this.seatNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IncludeFF_EquivPartnerLev
        {
            get
            {
                return this.includeFF_EquivPartnerLevField;
            }
            set
            {
                this.includeFF_EquivPartnerLevField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeFF_EquivPartnerLevSpecified
        {
            get
            {
                return this.includeFF_EquivPartnerLevFieldSpecified;
            }
            set
            {
                this.includeFF_EquivPartnerLevFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReturnFF_Number
        {
            get
            {
                return this.returnFF_NumberField;
            }
            set
            {
                this.returnFF_NumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnFF_NumberSpecified
        {
            get
            {
                return this.returnFF_NumberFieldSpecified;
            }
            set
            {
                this.returnFF_NumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReturnDownlineSeg
        {
            get
            {
                return this.returnDownlineSegField;
            }
            set
            {
                this.returnDownlineSegField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnDownlineSegSpecified
        {
            get
            {
                return this.returnDownlineSegFieldSpecified;
            }
            set
            {
                this.returnDownlineSegFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public GetBasketPNROTA_ReadRQReadRequestsAirReadRequestInfoToReturn InfoToReturn
        {
            get
            {
                return this.infoToReturnField;
            }
            set
            {
                this.infoToReturnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InfoToReturnSpecified
        {
            get
            {
                return this.infoToReturnFieldSpecified;
            }
            set
            {
                this.infoToReturnFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public GetBasketPNROTA_ReadRQReadRequestsAirReadRequestFF_RequestCriteria FF_RequestCriteria
        {
            get
            {
                return this.fF_RequestCriteriaField;
            }
            set
            {
                this.fF_RequestCriteriaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FF_RequestCriteriaSpecified
        {
            get
            {
                return this.fF_RequestCriteriaFieldSpecified;
            }
            set
            {
                this.fF_RequestCriteriaFieldSpecified = value;
            }
        }
    }
}