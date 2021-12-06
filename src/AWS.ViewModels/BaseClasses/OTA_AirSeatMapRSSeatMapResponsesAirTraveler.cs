namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_AirSeatMapRSSeatMapResponsesAirTraveler
    {

        private PersonNameType personNameField;

        private OTA_AirSeatMapRSSeatMapResponsesAirTravelerCustLoyalty[] custLoyaltyField;

        private PassengerTypeQuantityType passengerTypeQuantityField;

        private OTA_AirSeatMapRSSeatMapResponsesAirTravelerTravelerRefNumber travelerRefNumberField;

        private OTA_AirSeatMapRSSeatMapResponsesAirTravelerGender genderField;

        private bool genderFieldSpecified;

        private OTA_AirSeatMapRSSeatMapResponsesAirTravelerShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private OTA_AirSeatMapRSSeatMapResponsesAirTravelerShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private System.DateTime birthDateField;

        private bool birthDateFieldSpecified;

        private string currencyCodeField;

        private string passengerTypeCodeField;

        private bool accompaniedByInfantField;

        private bool accompaniedByInfantFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PersonNameType PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustLoyalty", Order = 1)]
        public OTA_AirSeatMapRSSeatMapResponsesAirTravelerCustLoyalty[] CustLoyalty
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public PassengerTypeQuantityType PassengerTypeQuantity
        {
            get
            {
                return this.passengerTypeQuantityField;
            }
            set
            {
                this.passengerTypeQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public OTA_AirSeatMapRSSeatMapResponsesAirTravelerTravelerRefNumber TravelerRefNumber
        {
            get
            {
                return this.travelerRefNumberField;
            }
            set
            {
                this.travelerRefNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_AirSeatMapRSSeatMapResponsesAirTravelerGender Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GenderSpecified
        {
            get
            {
                return this.genderFieldSpecified;
            }
            set
            {
                this.genderFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_AirSeatMapRSSeatMapResponsesAirTravelerShareSynchInd ShareSynchInd
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
        public OTA_AirSeatMapRSSeatMapResponsesAirTravelerShareMarketInd ShareMarketInd
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime BirthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BirthDateSpecified
        {
            get
            {
                return this.birthDateFieldSpecified;
            }
            set
            {
                this.birthDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PassengerTypeCode
        {
            get
            {
                return this.passengerTypeCodeField;
            }
            set
            {
                this.passengerTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AccompaniedByInfant
        {
            get
            {
                return this.accompaniedByInfantField;
            }
            set
            {
                this.accompaniedByInfantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccompaniedByInfantSpecified
        {
            get
            {
                return this.accompaniedByInfantFieldSpecified;
            }
            set
            {
                this.accompaniedByInfantFieldSpecified = value;
            }
        }
    }
}