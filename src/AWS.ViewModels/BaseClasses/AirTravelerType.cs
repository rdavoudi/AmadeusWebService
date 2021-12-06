namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirTravelerType
    {

        private int numberOfBaggagesField;

        private int numberOfBaggages1Field;

        private int handLuggagesField;

        private int handLuggages1Field;

        private AirTravelerTypeLCCParameters lCCParametersField;

        private AirTravelerTypeProfileRef profileRefField;

        private PersonNameType personNameField;

        private AirTravelerTypeTelephone[] telephoneField;

        private AirTravelerTypeEmail[] emailField;

        private AirTravelerTypeAddress[] addressField;

        private AirTravelerTypeCustLoyalty[] custLoyaltyField;

        private AirTravelerTypeDocument[] documentField;

        private PassengerTypeQuantityType passengerTypeQuantityField;

        private AirTravelerTypeTravelerRefNumber travelerRefNumberField;

        private string[] flightSegmentRPHsField;

        private System.DateTime birthDateField;

        private bool birthDateFieldSpecified;

        private AirTravelerTypeGender genderField;

        private bool genderFieldSpecified;

        private AirTravelerTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private AirTravelerTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private string currencyCodeField;

        private string passengerTypeCodeField;

        private bool accompaniedByInfantField;

        private bool accompaniedByInfantFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int NumberOfBaggages
        {
            get
            {
                return this.numberOfBaggagesField;
            }
            set
            {
                this.numberOfBaggagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int NumberOfBaggages1
        {
            get
            {
                return this.numberOfBaggages1Field;
            }
            set
            {
                this.numberOfBaggages1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public int HandLuggages
        {
            get
            {
                return this.handLuggagesField;
            }
            set
            {
                this.handLuggagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public int HandLuggages1
        {
            get
            {
                return this.handLuggages1Field;
            }
            set
            {
                this.handLuggages1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public AirTravelerTypeLCCParameters LCCParameters
        {
            get
            {
                return this.lCCParametersField;
            }
            set
            {
                this.lCCParametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public AirTravelerTypeProfileRef ProfileRef
        {
            get
            {
                return this.profileRefField;
            }
            set
            {
                this.profileRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
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
        [System.Xml.Serialization.XmlElementAttribute("Telephone", Order = 7)]
        public AirTravelerTypeTelephone[] Telephone
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
        [System.Xml.Serialization.XmlElementAttribute("Email", Order = 8)]
        public AirTravelerTypeEmail[] Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Address", Order = 9)]
        public AirTravelerTypeAddress[] Address
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
        [System.Xml.Serialization.XmlElementAttribute("CustLoyalty", Order = 10)]
        public AirTravelerTypeCustLoyalty[] CustLoyalty
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
        [System.Xml.Serialization.XmlElementAttribute("Document", Order = 11)]
        public AirTravelerTypeDocument[] Document
        {
            get
            {
                return this.documentField;
            }
            set
            {
                this.documentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public AirTravelerTypeTravelerRefNumber TravelerRefNumber
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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 14)]
        [System.Xml.Serialization.XmlArrayItemAttribute("FlightSegmentRPH", IsNullable = false)]
        public string[] FlightSegmentRPHs
        {
            get
            {
                return this.flightSegmentRPHsField;
            }
            set
            {
                this.flightSegmentRPHsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 15)]
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
        public AirTravelerTypeGender Gender
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
        public AirTravelerTypeShareSynchInd ShareSynchInd
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
        public AirTravelerTypeShareMarketInd ShareMarketInd
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