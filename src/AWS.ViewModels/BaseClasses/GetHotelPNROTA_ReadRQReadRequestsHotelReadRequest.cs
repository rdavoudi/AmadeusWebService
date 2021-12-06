namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetHotelPNROTA_ReadRQReadRequestsHotelReadRequest
    {

        private string cityNameField;

        private GetHotelPNROTA_ReadRQReadRequestsHotelReadRequestAirport airportField;

        private GetHotelPNROTA_ReadRQReadRequestsHotelReadRequestUserID userIDField;

        private VerificationType verificationField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private string chainCodeField;

        private string brandCodeField;

        private string hotelCodeField;

        private string hotelCityCodeField;

        private string hotelNameField;

        private string hotelCodeContextField;

        private string chainNameField;

        private string brandNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string CityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public GetHotelPNROTA_ReadRQReadRequestsHotelReadRequestAirport Airport
        {
            get
            {
                return this.airportField;
            }
            set
            {
                this.airportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public GetHotelPNROTA_ReadRQReadRequestsHotelReadRequestUserID UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public VerificationType Verification
        {
            get
            {
                return this.verificationField;
            }
            set
            {
                this.verificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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
        public string ChainCode
        {
            get
            {
                return this.chainCodeField;
            }
            set
            {
                this.chainCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandCode
        {
            get
            {
                return this.brandCodeField;
            }
            set
            {
                this.brandCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCode
        {
            get
            {
                return this.hotelCodeField;
            }
            set
            {
                this.hotelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCityCode
        {
            get
            {
                return this.hotelCityCodeField;
            }
            set
            {
                this.hotelCityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelName
        {
            get
            {
                return this.hotelNameField;
            }
            set
            {
                this.hotelNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCodeContext
        {
            get
            {
                return this.hotelCodeContextField;
            }
            set
            {
                this.hotelCodeContextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChainName
        {
            get
            {
                return this.chainNameField;
            }
            set
            {
                this.chainNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrandName
        {
            get
            {
                return this.brandNameField;
            }
            set
            {
                this.brandNameField = value;
            }
        }
    }
}