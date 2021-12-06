namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PreferencesTypePrefCollection
    {

        private CommonPrefType[] commonPrefField;

        private VehicleProfileRentalPrefType[] vehicleRentalPrefField;

        private AirlinePrefType[] airlinePrefField;

        private HotelPrefType[] hotelPrefField;

        private OtherSrvcPrefType[] otherSrvcPrefField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private PreferencesTypePrefCollectionShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private PreferencesTypePrefCollectionShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private string travelPurposeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommonPref", Order = 0)]
        public CommonPrefType[] CommonPref
        {
            get
            {
                return this.commonPrefField;
            }
            set
            {
                this.commonPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VehicleRentalPref", Order = 1)]
        public VehicleProfileRentalPrefType[] VehicleRentalPref
        {
            get
            {
                return this.vehicleRentalPrefField;
            }
            set
            {
                this.vehicleRentalPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AirlinePref", Order = 2)]
        public AirlinePrefType[] AirlinePref
        {
            get
            {
                return this.airlinePrefField;
            }
            set
            {
                this.airlinePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HotelPref", Order = 3)]
        public HotelPrefType[] HotelPref
        {
            get
            {
                return this.hotelPrefField;
            }
            set
            {
                this.hotelPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherSrvcPref", Order = 4)]
        public OtherSrvcPrefType[] OtherSrvcPref
        {
            get
            {
                return this.otherSrvcPrefField;
            }
            set
            {
                this.otherSrvcPrefField = value;
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
        public PreferencesTypePrefCollectionShareSynchInd ShareSynchInd
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
        public PreferencesTypePrefCollectionShareMarketInd ShareMarketInd
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