using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS.ViewModels.BaseClasses
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", IsNullable = false)]
    public partial class SignOutResponse
    {

        private bool signOutResultField;

        /// <remarks/>
        public bool SignOutResult
        {
            get
            {
                return this.signOutResultField;
            }
            set
            {
                this.signOutResultField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", IsNullable = false)]
    public partial class SearchFlightResponse
    {

        private SearchFlightResponseOTA_AirLowFareSearchRS oTA_AirLowFareSearchRSField;

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRS OTA_AirLowFareSearchRS
        {
            get
            {
                return this.oTA_AirLowFareSearchRSField;
            }
            set
            {
                this.oTA_AirLowFareSearchRSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRS
    {

        private bool hasMoreResultField;

        private object successField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItineraries pricedItinerariesField;

        private byte versionField;

        /// <remarks/>
        public bool HasMoreResult
        {
            get
            {
                return this.hasMoreResultField;
            }
            set
            {
                this.hasMoreResultField = value;
            }
        }

        /// <remarks/>
        public object Success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItineraries PricedItineraries
        {
            get
            {
                return this.pricedItinerariesField;
            }
            set
            {
                this.pricedItinerariesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItineraries
    {

        private List<SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItinerary> pricedItineraryField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWC pricedItineraryForOWCField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesBaggage[] freeBaggagesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PricedItinerary")]
        public List<SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItinerary> PricedItinerary
        {
            get
            {
                return this.pricedItineraryField;
            }
            set
            {
                this.pricedItineraryField = value;
            }
        }

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWC PricedItineraryForOWC
        {
            get
            {
                return this.pricedItineraryForOWCField;
            }
            set
            {
                this.pricedItineraryForOWCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Baggage", IsNullable = false)]
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesBaggage[] FreeBaggages
        {
            get
            {
                return this.freeBaggagesField;
            }
            set
            {
                this.freeBaggagesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItinerary
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItinerary airItineraryField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfo airItineraryPricingInfoField;

        private string currencyField;

        private string providerTypeField;

        private byte sequenceNumberField;

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItinerary AirItinerary
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
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfo AirItineraryPricingInfo
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte SequenceNumber
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItinerary
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOption[] originDestinationOptionsField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationCombination[] originDestinationCombinationsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OriginDestinationOption", IsNullable = false)]
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOption[] OriginDestinationOptions
        {
            get
            {
                return this.originDestinationOptionsField;
            }
            set
            {
                this.originDestinationOptionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OriginDestinationCombination", IsNullable = false)]
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationCombination[] OriginDestinationCombinations
        {
            get
            {
                return this.originDestinationCombinationsField;
            }
            set
            {
                this.originDestinationCombinationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOption
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegment[] flightSegmentField;

        private byte refNumberField;

        private byte directionIdField;

        private ushort elapsedTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FlightSegment")]
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegment[] FlightSegment
        {
            get
            {
                return this.flightSegmentField;
            }
            set
            {
                this.flightSegmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte RefNumber
        {
            get
            {
                return this.refNumberField;
            }
            set
            {
                this.refNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DirectionId
        {
            get
            {
                return this.directionIdField;
            }
            set
            {
                this.directionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ElapsedTime
        {
            get
            {
                return this.elapsedTimeField;
            }
            set
            {
                this.elapsedTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegment
    {

        private System.DateTime flightDurationField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentDepartureAirport departureAirportField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentArrivalAirport arrivalAirportField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentOperatingAirline operatingAirlineField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentEquipment equipmentField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentMarketingAirline marketingAirlineField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentBaggages baggagesField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentBookingClassAvail[] bookingClassAvailsField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentStopLocation stopLocationField;

        private System.DateTime departureDateTimeField;

        private System.DateTime arrivalDateTimeField;

        private ushort flightNumberField;

        private string resBookDesigCodeField;

        /// <remarks/>
        public System.DateTime FlightDuration
        {
            get
            {
                return this.flightDurationField;
            }
            set
            {
                this.flightDurationField = value;
            }
        }

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentDepartureAirport DepartureAirport
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
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentArrivalAirport ArrivalAirport
        {
            get
            {
                return this.arrivalAirportField;
            }
            set
            {
                this.arrivalAirportField = value;
            }
        }

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentOperatingAirline OperatingAirline
        {
            get
            {
                return this.operatingAirlineField;
            }
            set
            {
                this.operatingAirlineField = value;
            }
        }

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentEquipment Equipment
        {
            get
            {
                return this.equipmentField;
            }
            set
            {
                this.equipmentField = value;
            }
        }

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentMarketingAirline MarketingAirline
        {
            get
            {
                return this.marketingAirlineField;
            }
            set
            {
                this.marketingAirlineField = value;
            }
        }

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentBaggages Baggages
        {
            get
            {
                return this.baggagesField;
            }
            set
            {
                this.baggagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("BookingClassAvail", IsNullable = false)]
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentBookingClassAvail[] BookingClassAvails
        {
            get
            {
                return this.bookingClassAvailsField;
            }
            set
            {
                this.bookingClassAvailsField = value;
            }
        }

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentStopLocation StopLocation
        {
            get
            {
                return this.stopLocationField;
            }
            set
            {
                this.stopLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DepartureDateTime
        {
            get
            {
                return this.departureDateTimeField;
            }
            set
            {
                this.departureDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ArrivalDateTime
        {
            get
            {
                return this.arrivalDateTimeField;
            }
            set
            {
                this.arrivalDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort FlightNumber
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this.resBookDesigCodeField;
            }
            set
            {
                this.resBookDesigCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentDepartureAirport
    {

        private string locationCodeField;

        private string terminalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Terminal
        {
            get
            {
                return this.terminalField;
            }
            set
            {
                this.terminalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentArrivalAirport
    {

        private string locationCodeField;

        private string terminalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Terminal
        {
            get
            {
                return this.terminalField;
            }
            set
            {
                this.terminalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentOperatingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentEquipment
    {

        private string airEquipTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirEquipType
        {
            get
            {
                return this.airEquipTypeField;
            }
            set
            {
                this.airEquipTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentMarketingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentBaggages
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentBaggagesBaggage baggageField;

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentBaggagesBaggage Baggage
        {
            get
            {
                return this.baggageField;
            }
            set
            {
                this.baggageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentBaggagesBaggage
    {

        private byte indexField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentBookingClassAvail
    {

        private string resBookDesigCodeField;

        private byte resBookDesigQuantityField;

        private string rPHField;

        private string availablePTCField;

        private string resBookDesigCabinCodeField;

        private string fareBasisField;

        private string fareTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this.resBookDesigCodeField;
            }
            set
            {
                this.resBookDesigCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ResBookDesigQuantity
        {
            get
            {
                return this.resBookDesigQuantityField;
            }
            set
            {
                this.resBookDesigQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AvailablePTC
        {
            get
            {
                return this.availablePTCField;
            }
            set
            {
                this.availablePTCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCabinCode
        {
            get
            {
                return this.resBookDesigCabinCodeField;
            }
            set
            {
                this.resBookDesigCabinCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareBasis
        {
            get
            {
                return this.fareBasisField;
            }
            set
            {
                this.fareBasisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareType
        {
            get
            {
                return this.fareTypeField;
            }
            set
            {
                this.fareTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationOptionFlightSegmentStopLocation
    {

        private string locationCodeField;

        private System.DateTime departureDateTimeField;

        private System.DateTime arrivalDateTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DepartureDateTime
        {
            get
            {
                return this.departureDateTimeField;
            }
            set
            {
                this.departureDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ArrivalDateTime
        {
            get
            {
                return this.arrivalDateTimeField;
            }
            set
            {
                this.arrivalDateTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryOriginDestinationCombination
    {

        private string validatingAirlineCodeField;

        private bool forceETicketField;

        private string indexListField;

        private byte combinationIDField;

        private string e_TicketEligibilityField;

        private byte serviceFeeAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ValidatingAirlineCode
        {
            get
            {
                return this.validatingAirlineCodeField;
            }
            set
            {
                this.validatingAirlineCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ForceETicket
        {
            get
            {
                return this.forceETicketField;
            }
            set
            {
                this.forceETicketField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IndexList
        {
            get
            {
                return this.indexListField;
            }
            set
            {
                this.indexListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte CombinationID
        {
            get
            {
                return this.combinationIDField;
            }
            set
            {
                this.combinationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string E_TicketEligibility
        {
            get
            {
                return this.e_TicketEligibilityField;
            }
            set
            {
                this.e_TicketEligibilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ServiceFeeAmount
        {
            get
            {
                return this.serviceFeeAmountField;
            }
            set
            {
                this.serviceFeeAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfo
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoItinTotalFare itinTotalFareField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdown[] pTC_FareBreakdownsField;

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoItinTotalFare ItinTotalFare
        {
            get
            {
                return this.itinTotalFareField;
            }
            set
            {
                this.itinTotalFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PTC_FareBreakdown", IsNullable = false)]
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdown[] PTC_FareBreakdowns
        {
            get
            {
                return this.pTC_FareBreakdownsField;
            }
            set
            {
                this.pTC_FareBreakdownsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoItinTotalFare
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoItinTotalFareBaseFare baseFareField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoItinTotalFareMarkupFare markupFareField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoItinTotalFareTotalFare totalFareField;

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoItinTotalFareBaseFare BaseFare
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
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoItinTotalFareMarkupFare MarkupFare
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
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoItinTotalFareTotalFare TotalFare
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoItinTotalFareBaseFare
    {

        private decimal amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoItinTotalFareMarkupFare
    {

        private byte amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoItinTotalFareTotalFare
    {

        private decimal amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdown
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerTypeQuantity passengerTypeQuantityField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFare passengerFareField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownTicketDesignator[] ticketDesignatorsField;

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerTypeQuantity PassengerTypeQuantity
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
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFare PassengerFare
        {
            get
            {
                return this.passengerFareField;
            }
            set
            {
                this.passengerFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TicketDesignator", IsNullable = false)]
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownTicketDesignator[] TicketDesignators
        {
            get
            {
                return this.ticketDesignatorsField;
            }
            set
            {
                this.ticketDesignatorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerTypeQuantity
    {

        private string codeField;

        private byte quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Quantity
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFare
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareBaseFare baseFareField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareMarkupFare markupFareField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTaxes taxesField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTotalFare totalFareField;

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareBaseFare BaseFare
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
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareMarkupFare MarkupFare
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
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTaxes Taxes
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
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTotalFare TotalFare
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareBaseFare
    {

        private decimal amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareMarkupFare
    {

        private byte amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTaxes
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTaxesTax taxField;

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTaxesTax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTaxesTax
    {

        private decimal amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTotalFare
    {

        private decimal amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownTicketDesignator
    {

        private string ticketDesignatorCodeField;

        private string ticketDesignatorExtensionField;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDesignatorExtension
        {
            get
            {
                return this.ticketDesignatorExtensionField;
            }
            set
            {
                this.ticketDesignatorExtensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWC
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItinerary airItineraryField;

        private bool isOneWayCombinableField;

        private string currencyField;

        private byte sequenceNumberField;

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItinerary AirItinerary
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
        public byte SequenceNumber
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItinerary
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOption[] originDestinationOptionsField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationCombination[] originDestinationCombinationsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OriginDestinationOption", IsNullable = false)]
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOption[] OriginDestinationOptions
        {
            get
            {
                return this.originDestinationOptionsField;
            }
            set
            {
                this.originDestinationOptionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OriginDestinationCombination", IsNullable = false)]
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationCombination[] OriginDestinationCombinations
        {
            get
            {
                return this.originDestinationCombinationsField;
            }
            set
            {
                this.originDestinationCombinationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOption
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegment[] flightSegmentField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfo optionPricingInfoField;

        private byte refNumberField;

        private byte directionIdField;

        private ushort elapsedTimeField;

        private string providerTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FlightSegment")]
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegment[] FlightSegment
        {
            get
            {
                return this.flightSegmentField;
            }
            set
            {
                this.flightSegmentField = value;
            }
        }

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfo OptionPricingInfo
        {
            get
            {
                return this.optionPricingInfoField;
            }
            set
            {
                this.optionPricingInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte RefNumber
        {
            get
            {
                return this.refNumberField;
            }
            set
            {
                this.refNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DirectionId
        {
            get
            {
                return this.directionIdField;
            }
            set
            {
                this.directionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ElapsedTime
        {
            get
            {
                return this.elapsedTimeField;
            }
            set
            {
                this.elapsedTimeField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegment
    {

        private System.DateTime flightDurationField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentDepartureAirport departureAirportField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentArrivalAirport arrivalAirportField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentOperatingAirline operatingAirlineField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentEquipment equipmentField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentMarketingAirline marketingAirlineField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentBaggages baggagesField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentBookingClassAvail[] bookingClassAvailsField;

        private System.DateTime departureDateTimeField;

        private System.DateTime arrivalDateTimeField;

        private ushort flightNumberField;

        private string resBookDesigCodeField;

        /// <remarks/>
        public System.DateTime FlightDuration
        {
            get
            {
                return this.flightDurationField;
            }
            set
            {
                this.flightDurationField = value;
            }
        }

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentDepartureAirport DepartureAirport
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
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentArrivalAirport ArrivalAirport
        {
            get
            {
                return this.arrivalAirportField;
            }
            set
            {
                this.arrivalAirportField = value;
            }
        }

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentOperatingAirline OperatingAirline
        {
            get
            {
                return this.operatingAirlineField;
            }
            set
            {
                this.operatingAirlineField = value;
            }
        }

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentEquipment Equipment
        {
            get
            {
                return this.equipmentField;
            }
            set
            {
                this.equipmentField = value;
            }
        }

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentMarketingAirline MarketingAirline
        {
            get
            {
                return this.marketingAirlineField;
            }
            set
            {
                this.marketingAirlineField = value;
            }
        }

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentBaggages Baggages
        {
            get
            {
                return this.baggagesField;
            }
            set
            {
                this.baggagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("BookingClassAvail", IsNullable = false)]
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentBookingClassAvail[] BookingClassAvails
        {
            get
            {
                return this.bookingClassAvailsField;
            }
            set
            {
                this.bookingClassAvailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DepartureDateTime
        {
            get
            {
                return this.departureDateTimeField;
            }
            set
            {
                this.departureDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ArrivalDateTime
        {
            get
            {
                return this.arrivalDateTimeField;
            }
            set
            {
                this.arrivalDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort FlightNumber
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this.resBookDesigCodeField;
            }
            set
            {
                this.resBookDesigCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentDepartureAirport
    {

        private string locationCodeField;

        private string terminalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Terminal
        {
            get
            {
                return this.terminalField;
            }
            set
            {
                this.terminalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentArrivalAirport
    {

        private string locationCodeField;

        private string terminalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Terminal
        {
            get
            {
                return this.terminalField;
            }
            set
            {
                this.terminalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentOperatingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentEquipment
    {

        private string airEquipTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirEquipType
        {
            get
            {
                return this.airEquipTypeField;
            }
            set
            {
                this.airEquipTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentMarketingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentBaggages
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentBaggagesBaggage baggageField;

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentBaggagesBaggage Baggage
        {
            get
            {
                return this.baggageField;
            }
            set
            {
                this.baggageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentBaggagesBaggage
    {

        private byte indexField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionFlightSegmentBookingClassAvail
    {

        private string resBookDesigCodeField;

        private byte resBookDesigQuantityField;

        private string rPHField;

        private string availablePTCField;

        private string resBookDesigCabinCodeField;

        private string fareBasisField;

        private string fareTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this.resBookDesigCodeField;
            }
            set
            {
                this.resBookDesigCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ResBookDesigQuantity
        {
            get
            {
                return this.resBookDesigQuantityField;
            }
            set
            {
                this.resBookDesigQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AvailablePTC
        {
            get
            {
                return this.availablePTCField;
            }
            set
            {
                this.availablePTCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCabinCode
        {
            get
            {
                return this.resBookDesigCabinCodeField;
            }
            set
            {
                this.resBookDesigCabinCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareBasis
        {
            get
            {
                return this.fareBasisField;
            }
            set
            {
                this.fareBasisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareType
        {
            get
            {
                return this.fareTypeField;
            }
            set
            {
                this.fareTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfo
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoItinTotalFare itinTotalFareField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdown[] pTC_FareBreakdownsField;

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoItinTotalFare ItinTotalFare
        {
            get
            {
                return this.itinTotalFareField;
            }
            set
            {
                this.itinTotalFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PTC_FareBreakdown", IsNullable = false)]
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdown[] PTC_FareBreakdowns
        {
            get
            {
                return this.pTC_FareBreakdownsField;
            }
            set
            {
                this.pTC_FareBreakdownsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoItinTotalFare
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoItinTotalFareBaseFare baseFareField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoItinTotalFareMarkupFare markupFareField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoItinTotalFareTotalFare totalFareField;

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoItinTotalFareBaseFare BaseFare
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
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoItinTotalFareMarkupFare MarkupFare
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
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoItinTotalFareTotalFare TotalFare
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoItinTotalFareBaseFare
    {

        private decimal amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoItinTotalFareMarkupFare
    {

        private byte amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoItinTotalFareTotalFare
    {

        private decimal amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdown
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerTypeQuantity passengerTypeQuantityField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFare passengerFareField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownTicketDesignator[] ticketDesignatorsField;

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerTypeQuantity PassengerTypeQuantity
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
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFare PassengerFare
        {
            get
            {
                return this.passengerFareField;
            }
            set
            {
                this.passengerFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TicketDesignator", IsNullable = false)]
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownTicketDesignator[] TicketDesignators
        {
            get
            {
                return this.ticketDesignatorsField;
            }
            set
            {
                this.ticketDesignatorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerTypeQuantity
    {

        private string codeField;

        private byte quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Quantity
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFare
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFareBaseFare baseFareField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFareMarkupFare markupFareField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFareTaxes taxesField;

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFareTotalFare totalFareField;

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFareBaseFare BaseFare
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
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFareMarkupFare MarkupFare
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
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFareTaxes Taxes
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
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFareTotalFare TotalFare
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFareBaseFare
    {

        private decimal amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFareMarkupFare
    {

        private byte amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFareTaxes
    {

        private SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFareTaxesTax taxField;

        /// <remarks/>
        public SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFareTaxesTax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFareTaxesTax
    {

        private decimal amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownPassengerFareTotalFare
    {

        private decimal amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationOptionOptionPricingInfoPTC_FareBreakdownTicketDesignator
    {

        private string ticketDesignatorCodeField;

        private string ticketDesignatorExtensionField;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDesignatorExtension
        {
            get
            {
                return this.ticketDesignatorExtensionField;
            }
            set
            {
                this.ticketDesignatorExtensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesPricedItineraryForOWCAirItineraryOriginDestinationCombination
    {

        private string validatingAirlineCodeField;

        private bool forceETicketField;

        private string indexListField;

        private byte combinationIDField;

        private string e_TicketEligibilityField;

        private byte serviceFeeAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ValidatingAirlineCode
        {
            get
            {
                return this.validatingAirlineCodeField;
            }
            set
            {
                this.validatingAirlineCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ForceETicket
        {
            get
            {
                return this.forceETicketField;
            }
            set
            {
                this.forceETicketField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IndexList
        {
            get
            {
                return this.indexListField;
            }
            set
            {
                this.indexListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte CombinationID
        {
            get
            {
                return this.combinationIDField;
            }
            set
            {
                this.combinationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string E_TicketEligibility
        {
            get
            {
                return this.e_TicketEligibilityField;
            }
            set
            {
                this.e_TicketEligibilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ServiceFeeAmount
        {
            get
            {
                return this.serviceFeeAmountField;
            }
            set
            {
                this.serviceFeeAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightResponseOTA_AirLowFareSearchRSPricedItinerariesBaggage
    {

        private byte indexField;

        private byte quantityField;

        private string unitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Quantity
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
        public string Unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", IsNullable = false)]
    public partial class GetFlightRulesResponse
    {

        private GetFlightRulesResponseOTA_AirRulesRS oTA_AirRulesRSField;

        /// <remarks/>
        public GetFlightRulesResponseOTA_AirRulesRS OTA_AirRulesRS
        {
            get
            {
                return this.oTA_AirRulesRSField;
            }
            set
            {
                this.oTA_AirRulesRSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetFlightRulesResponseOTA_AirRulesRS
    {

        private object successField;

        private GetFlightRulesResponseOTA_AirRulesRSFareRuleInfo[] fareRuleResponseInfoField;

        private GetFlightRulesResponseOTA_AirRulesRSPriceMessageInfoType priceMessageInfoTypeField;

        private byte versionField;

        /// <remarks/>
        public object Success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FareRuleInfo", IsNullable = false)]
        public GetFlightRulesResponseOTA_AirRulesRSFareRuleInfo[] FareRuleResponseInfo
        {
            get
            {
                return this.fareRuleResponseInfoField;
            }
            set
            {
                this.fareRuleResponseInfoField = value;
            }
        }

        /// <remarks/>
        public GetFlightRulesResponseOTA_AirRulesRSPriceMessageInfoType PriceMessageInfoType
        {
            get
            {
                return this.priceMessageInfoTypeField;
            }
            set
            {
                this.priceMessageInfoTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetFlightRulesResponseOTA_AirRulesRSFareRuleInfo
    {

        private string fareReferenceField;

        private GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoFilingAirline filingAirlineField;

        private GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoMarketingAirline marketingAirlineField;

        private GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoDepartureAirport departureAirportField;

        private GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoArrivalAirport arrivalAirportField;

        private GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoSubSection[] fareRulesField;

        /// <remarks/>
        public string FareReference
        {
            get
            {
                return this.fareReferenceField;
            }
            set
            {
                this.fareReferenceField = value;
            }
        }

        /// <remarks/>
        public GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoFilingAirline FilingAirline
        {
            get
            {
                return this.filingAirlineField;
            }
            set
            {
                this.filingAirlineField = value;
            }
        }

        /// <remarks/>
        public GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoMarketingAirline MarketingAirline
        {
            get
            {
                return this.marketingAirlineField;
            }
            set
            {
                this.marketingAirlineField = value;
            }
        }

        /// <remarks/>
        public GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoDepartureAirport DepartureAirport
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
        public GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoArrivalAirport ArrivalAirport
        {
            get
            {
                return this.arrivalAirportField;
            }
            set
            {
                this.arrivalAirportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SubSection", IsNullable = false)]
        public GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoSubSection[] FareRules
        {
            get
            {
                return this.fareRulesField;
            }
            set
            {
                this.fareRulesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoFilingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoMarketingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoDepartureAirport
    {

        private string locationCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoArrivalAirport
    {

        private string locationCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoSubSection
    {

        private GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoSubSectionParagraph paragraphField;

        private string subTitleField;

        private string subCodeField;

        /// <remarks/>
        public GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoSubSectionParagraph Paragraph
        {
            get
            {
                return this.paragraphField;
            }
            set
            {
                this.paragraphField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubTitle
        {
            get
            {
                return this.subTitleField;
            }
            set
            {
                this.subTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubCode
        {
            get
            {
                return this.subCodeField;
            }
            set
            {
                this.subCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetFlightRulesResponseOTA_AirRulesRSFareRuleInfoSubSectionParagraph
    {

        private string textField;

        /// <remarks/>
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetFlightRulesResponseOTA_AirRulesRSPriceMessageInfoType
    {

        private GetFlightRulesResponseOTA_AirRulesRSPriceMessageInfoTypePriceMessageInfo priceMessageInfoField;

        /// <remarks/>
        public GetFlightRulesResponseOTA_AirRulesRSPriceMessageInfoTypePriceMessageInfo PriceMessageInfo
        {
            get
            {
                return this.priceMessageInfoField;
            }
            set
            {
                this.priceMessageInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetFlightRulesResponseOTA_AirRulesRSPriceMessageInfoTypePriceMessageInfo
    {

        private GetFlightRulesResponseOTA_AirRulesRSPriceMessageInfoTypePriceMessageInfoMiniRulesPriceMessages miniRulesPriceMessagesField;

        /// <remarks/>
        public GetFlightRulesResponseOTA_AirRulesRSPriceMessageInfoTypePriceMessageInfoMiniRulesPriceMessages MiniRulesPriceMessages
        {
            get
            {
                return this.miniRulesPriceMessagesField;
            }
            set
            {
                this.miniRulesPriceMessagesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetFlightRulesResponseOTA_AirRulesRSPriceMessageInfoTypePriceMessageInfoMiniRulesPriceMessages
    {

        private GetFlightRulesResponseOTA_AirRulesRSPriceMessageInfoTypePriceMessageInfoMiniRulesPriceMessagesMiniRulesPriceText[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("MiniRulesPriceText", IsNullable = false)]
        public GetFlightRulesResponseOTA_AirRulesRSPriceMessageInfoTypePriceMessageInfoMiniRulesPriceMessagesMiniRulesPriceText[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetFlightRulesResponseOTA_AirRulesRSPriceMessageInfoTypePriceMessageInfoMiniRulesPriceMessagesMiniRulesPriceText
    {

        private string priceMessageValueField;

        private string priceDataListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PriceMessageValue
        {
            get
            {
                return this.priceMessageValueField;
            }
            set
            {
                this.priceMessageValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PriceDataList
        {
            get
            {
                return this.priceDataListField;
            }
            set
            {
                this.priceDataListField = value;
            }
        }
    }

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", IsNullable = false)]
    public partial class Errors
    {

        private ErrorsError errorField;

        /// <remarks/>
        public ErrorsError Error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ErrorsError
    {

        private string typeField;

        private string errorCodeField;

        private string shortTextField;

        private string codeField;

        private string nodeListField;

        private bool breakFlowField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ShortText
        {
            get
            {
                return this.shortTextField;
            }
            set
            {
                this.shortTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NodeList
        {
            get
            {
                return this.nodeListField;
            }
            set
            {
                this.nodeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BreakFlow
        {
            get
            {
                return this.breakFlowField;
            }
            set
            {
                this.breakFlowField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", IsNullable = false)]
    public partial class CreateTicketResponse
    {

        private CreateTicketResponseOTA_AirBookRS oTA_AirBookRSField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRS OTA_AirBookRS
        {
            get
            {
                return this.oTA_AirBookRSField;
            }
            set
            {
                this.oTA_AirBookRSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRS
    {

        private CreateTicketResponseOTA_AirBookRSAirReservation airReservationField;

        private object successField;

        private byte versionField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservation AirReservation
        {
            get
            {
                return this.airReservationField;
            }
            set
            {
                this.airReservationField = value;
            }
        }

        /// <remarks/>
        public object Success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservation
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationAirItinerary airItineraryField;

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfo priceInfoField;

        private CreateTicketResponseOTA_AirBookRSAirReservationAirTraveler[] travelerInfoField;

        private CreateTicketResponseOTA_AirBookRSAirReservationFulfillment fulfillmentField;

        private CreateTicketResponseOTA_AirBookRSAirReservationTicketing ticketingField;

        private CreateTicketResponseOTA_AirBookRSAirReservationBookingReferenceID bookingReferenceIDField;

        private CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfo[] flightRulePenaltiesField;

        private object flightMiniRulesField;

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceMessageInfo priceMessageInfoField;

        private CreateTicketResponseOTA_AirBookRSAirReservationPNRRemark[] pNRRemarksField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationAirItinerary AirItinerary
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
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfo PriceInfo
        {
            get
            {
                return this.priceInfoField;
            }
            set
            {
                this.priceInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("AirTraveler", IsNullable = false)]
        public CreateTicketResponseOTA_AirBookRSAirReservationAirTraveler[] TravelerInfo
        {
            get
            {
                return this.travelerInfoField;
            }
            set
            {
                this.travelerInfoField = value;
            }
        }

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationFulfillment Fulfillment
        {
            get
            {
                return this.fulfillmentField;
            }
            set
            {
                this.fulfillmentField = value;
            }
        }

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationTicketing Ticketing
        {
            get
            {
                return this.ticketingField;
            }
            set
            {
                this.ticketingField = value;
            }
        }

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationBookingReferenceID BookingReferenceID
        {
            get
            {
                return this.bookingReferenceIDField;
            }
            set
            {
                this.bookingReferenceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FareRuleInfo", IsNullable = false)]
        public CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfo[] FlightRulePenalties
        {
            get
            {
                return this.flightRulePenaltiesField;
            }
            set
            {
                this.flightRulePenaltiesField = value;
            }
        }

        /// <remarks/>
        public object FlightMiniRules
        {
            get
            {
                return this.flightMiniRulesField;
            }
            set
            {
                this.flightMiniRulesField = value;
            }
        }

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceMessageInfo PriceMessageInfo
        {
            get
            {
                return this.priceMessageInfoField;
            }
            set
            {
                this.priceMessageInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PNRRemark", IsNullable = false)]
        public CreateTicketResponseOTA_AirBookRSAirReservationPNRRemark[] PNRRemarks
        {
            get
            {
                return this.pNRRemarksField;
            }
            set
            {
                this.pNRRemarksField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirItinerary
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOption[] originDestinationOptionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OriginDestinationOption", IsNullable = false)]
        public CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOption[] OriginDestinationOptions
        {
            get
            {
                return this.originDestinationOptionsField;
            }
            set
            {
                this.originDestinationOptionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOption
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegment[] flightSegmentField;

        private byte refNumberField;

        private byte directionIdField;

        private ushort elapsedTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FlightSegment")]
        public CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegment[] FlightSegment
        {
            get
            {
                return this.flightSegmentField;
            }
            set
            {
                this.flightSegmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte RefNumber
        {
            get
            {
                return this.refNumberField;
            }
            set
            {
                this.refNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DirectionId
        {
            get
            {
                return this.directionIdField;
            }
            set
            {
                this.directionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ElapsedTime
        {
            get
            {
                return this.elapsedTimeField;
            }
            set
            {
                this.elapsedTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegment
    {

        private System.DateTime flightDurationField;

        private CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentDepartureAirport departureAirportField;

        private CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentArrivalAirport arrivalAirportField;

        private CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentOperatingAirline operatingAirlineField;

        private CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentEquipment equipmentField;

        private CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentMarketingAirline marketingAirlineField;

        private CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentBookingClassAvails bookingClassAvailsField;

        private System.DateTime departureDateTimeField;

        private System.DateTime arrivalDateTimeField;

        private ushort flightNumberField;

        private string resBookDesigCodeField;

        private string statusField;

        /// <remarks/>
        public System.DateTime FlightDuration
        {
            get
            {
                return this.flightDurationField;
            }
            set
            {
                this.flightDurationField = value;
            }
        }

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentDepartureAirport DepartureAirport
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
        public CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentArrivalAirport ArrivalAirport
        {
            get
            {
                return this.arrivalAirportField;
            }
            set
            {
                this.arrivalAirportField = value;
            }
        }

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentOperatingAirline OperatingAirline
        {
            get
            {
                return this.operatingAirlineField;
            }
            set
            {
                this.operatingAirlineField = value;
            }
        }

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentEquipment Equipment
        {
            get
            {
                return this.equipmentField;
            }
            set
            {
                this.equipmentField = value;
            }
        }

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentMarketingAirline MarketingAirline
        {
            get
            {
                return this.marketingAirlineField;
            }
            set
            {
                this.marketingAirlineField = value;
            }
        }

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentBookingClassAvails BookingClassAvails
        {
            get
            {
                return this.bookingClassAvailsField;
            }
            set
            {
                this.bookingClassAvailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DepartureDateTime
        {
            get
            {
                return this.departureDateTimeField;
            }
            set
            {
                this.departureDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ArrivalDateTime
        {
            get
            {
                return this.arrivalDateTimeField;
            }
            set
            {
                this.arrivalDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort FlightNumber
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this.resBookDesigCodeField;
            }
            set
            {
                this.resBookDesigCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentDepartureAirport
    {

        private string locationCodeField;

        private string terminalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Terminal
        {
            get
            {
                return this.terminalField;
            }
            set
            {
                this.terminalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentArrivalAirport
    {

        private string locationCodeField;

        private string terminalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Terminal
        {
            get
            {
                return this.terminalField;
            }
            set
            {
                this.terminalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentOperatingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentEquipment
    {

        private string airEquipTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirEquipType
        {
            get
            {
                return this.airEquipTypeField;
            }
            set
            {
                this.airEquipTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentMarketingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentBookingClassAvails
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentBookingClassAvailsBookingClassAvail bookingClassAvailField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentBookingClassAvailsBookingClassAvail BookingClassAvail
        {
            get
            {
                return this.bookingClassAvailField;
            }
            set
            {
                this.bookingClassAvailField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionFlightSegmentBookingClassAvailsBookingClassAvail
    {

        private string resBookDesigCodeField;

        private byte resBookDesigQuantityField;

        private string rPHField;

        private string availablePTCField;

        private string resBookDesigCabinCodeField;

        private string fareBasisField;

        private string fareTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this.resBookDesigCodeField;
            }
            set
            {
                this.resBookDesigCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ResBookDesigQuantity
        {
            get
            {
                return this.resBookDesigQuantityField;
            }
            set
            {
                this.resBookDesigQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AvailablePTC
        {
            get
            {
                return this.availablePTCField;
            }
            set
            {
                this.availablePTCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCabinCode
        {
            get
            {
                return this.resBookDesigCabinCodeField;
            }
            set
            {
                this.resBookDesigCabinCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareBasis
        {
            get
            {
                return this.fareBasisField;
            }
            set
            {
                this.fareBasisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareType
        {
            get
            {
                return this.fareTypeField;
            }
            set
            {
                this.fareTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfo
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFare itinTotalFareField;

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdown[] pTC_FareBreakdownsField;

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoServiceFees serviceFeesField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFare ItinTotalFare
        {
            get
            {
                return this.itinTotalFareField;
            }
            set
            {
                this.itinTotalFareField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("PTC_FareBreakdown", IsNullable = false)]
        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdown[] PTC_FareBreakdowns
        {
            get
            {
                return this.pTC_FareBreakdownsField;
            }
            set
            {
                this.pTC_FareBreakdownsField = value;
            }
        }

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoServiceFees ServiceFees
        {
            get
            {
                return this.serviceFeesField;
            }
            set
            {
                this.serviceFeesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFare
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareBaseFare baseFareField;

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareMarkupFare markupFareField;

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareTotalFare totalFareField;

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareTotalAmountInTicketingCurrency totalAmountInTicketingCurrencyField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareBaseFare BaseFare
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
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareMarkupFare MarkupFare
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
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareTotalFare TotalFare
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
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareTotalAmountInTicketingCurrency TotalAmountInTicketingCurrency
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareBaseFare
    {

        private string currencyField;

        private uint amountField;

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
        public uint Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareMarkupFare
    {

        private byte amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareTotalFare
    {

        private uint amountField;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareTotalAmountInTicketingCurrency
    {

        private decimal amountField;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdowns
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdown pTC_FareBreakdownField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdown PTC_FareBreakdown
        {
            get
            {
                return this.pTC_FareBreakdownField;
            }
            set
            {
                this.pTC_FareBreakdownField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdown
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerTypeQuantity passengerTypeQuantityField;

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFare passengerFareField;

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownTicketDesignator[] ticketDesignatorsField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerTypeQuantity PassengerTypeQuantity
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
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFare PassengerFare
        {
            get
            {
                return this.passengerFareField;
            }
            set
            {
                this.passengerFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TicketDesignator", IsNullable = false)]
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownTicketDesignator[] TicketDesignators
        {
            get
            {
                return this.ticketDesignatorsField;
            }
            set
            {
                this.ticketDesignatorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerTypeQuantity
    {

        private string codeField;

        private byte quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Quantity
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFare
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareBaseFare baseFareField;

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareMarkupFare markupFareField;

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTaxes taxesField;

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTotalFare totalFareField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareBaseFare BaseFare
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
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareMarkupFare MarkupFare
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
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTaxes Taxes
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
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTotalFare TotalFare
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareBaseFare
    {

        private uint amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareMarkupFare
    {

        private byte amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTaxes
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTaxesTax taxField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTaxesTax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTaxesTax
    {

        private uint amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownPassengerFareTotalFare
    {

        private uint amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownsPTC_FareBreakdownTicketDesignator
    {

        private string ticketDesignatorCodeField;

        private string ticketDesignatorExtensionField;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDesignatorExtension
        {
            get
            {
                return this.ticketDesignatorExtensionField;
            }
            set
            {
                this.ticketDesignatorExtensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoServiceFees
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoServiceFeesServiceFee serviceFeeField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoServiceFeesServiceFee ServiceFee
        {
            get
            {
                return this.serviceFeeField;
            }
            set
            {
                this.serviceFeeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoServiceFeesServiceFee
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoServiceFeesServiceFeePassengerTypeQuantity passengerTypeQuantityField;

        private byte amountField;

        private byte markupFeeAmountField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoServiceFeesServiceFeePassengerTypeQuantity PassengerTypeQuantity
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte MarkupFeeAmount
        {
            get
            {
                return this.markupFeeAmountField;
            }
            set
            {
                this.markupFeeAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceInfoServiceFeesServiceFeePassengerTypeQuantity
    {

        private string codeField;

        private byte quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Quantity
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirTraveler
    {

        private byte numberOfBaggagesField;

        private byte numberOfBaggages1Field;

        private byte handLuggagesField;

        private byte handLuggages1Field;

        private CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerPersonName personNameField;

        private CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerTelephone telephoneField;

        private string emailField;

        private CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerDocument[] documentField;

        private System.DateTime birthDateField;

        private CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocuments eTicketDocumentsField;

        private string passengerTypeCodeField;

        private string eTicketNumberField;

        private string gender;

        public string Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                this.gender = value;
            }
        }

        /// <remarks/>
        public byte NumberOfBaggages
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
        public byte NumberOfBaggages1
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
        public byte HandLuggages
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
        public byte HandLuggages1
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
        public CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerPersonName PersonName
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
        public CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerTelephone Telephone
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
        public string Email
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
        [System.Xml.Serialization.XmlElementAttribute("Document")]
        public CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerDocument[] Document
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
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
        public CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocuments eTicketDocuments
        {
            get
            {
                return this.eTicketDocumentsField;
            }
            set
            {
                this.eTicketDocumentsField = value;
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
        public string eTicketNumber
        {
            get
            {
                return this.eTicketNumberField;
            }
            set
            {
                this.eTicketNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerPersonName
    {

        private string namePrefixField;

        private string givenNameField;

        private string surnameField;

        /// <remarks/>
        public string NamePrefix
        {
            get
            {
                return this.namePrefixField;
            }
            set
            {
                this.namePrefixField = value;
            }
        }

        /// <remarks/>
        public string GivenName
        {
            get
            {
                return this.givenNameField;
            }
            set
            {
                this.givenNameField = value;
            }
        }

        /// <remarks/>
        public string Surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerTelephone
    {

        private string phoneTypeField;

        private string locationCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PhoneType
        {
            get
            {
                return this.phoneTypeField;
            }
            set
            {
                this.phoneTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerDocument
    {

        private string docIDField;

        private string docTypeField;

        private string innerDocTypeField;

        private System.DateTime expireDateField;

        private bool expireDateFieldSpecified;

        private string docIssueCountryField;

        private string docIssueLocationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocID
        {
            get
            {
                return this.docIDField;
            }
            set
            {
                this.docIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocType
        {
            get
            {
                return this.docTypeField;
            }
            set
            {
                this.docTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InnerDocType
        {
            get
            {
                return this.innerDocTypeField;
            }
            set
            {
                this.innerDocTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpireDateSpecified
        {
            get
            {
                return this.expireDateFieldSpecified;
            }
            set
            {
                this.expireDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocIssueCountry
        {
            get
            {
                return this.docIssueCountryField;
            }
            set
            {
                this.docIssueCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocIssueLocation
        {
            get
            {
                return this.docIssueLocationField;
            }
            set
            {
                this.docIssueLocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocuments
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocumentsETicketInfo eTicketInfoField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocumentsETicketInfo ETicketInfo
        {
            get
            {
                return this.eTicketInfoField;
            }
            set
            {
                this.eTicketInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocumentsETicketInfo
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocumentsETicketInfoAgencyAddress agencyAddressField;

        private string agencyTelNoField;

        private System.DateTime ticketingDateField;

        private string passengerName_SurnameField;

        private string issuingAirlineField;

        private string bookingRefField;

        private string fareCalculationField;

        private string endorsementsField;

        private decimal exchangeRateField;

        private string paymentTypeField;

        private string airFareCurrencyField;

        private decimal equivalentFareField;

        private string equivalentFareCurrencyField;

        private decimal totalFareField;

        private string totalFareCurrencyField;

        private CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocumentsETicketInfoTaxInfo[] taxesField;

        private string controlNumbersField;

        private CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocumentsETicketInfoETicketItineraryInfo[] itinerariesField;

        private string ticketNumberField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocumentsETicketInfoAgencyAddress AgencyAddress
        {
            get
            {
                return this.agencyAddressField;
            }
            set
            {
                this.agencyAddressField = value;
            }
        }

        /// <remarks/>
        public string AgencyTelNo
        {
            get
            {
                return this.agencyTelNoField;
            }
            set
            {
                this.agencyTelNoField = value;
            }
        }

        /// <remarks/>
        public System.DateTime TicketingDate
        {
            get
            {
                return this.ticketingDateField;
            }
            set
            {
                this.ticketingDateField = value;
            }
        }

        /// <remarks/>
        public string PassengerName_Surname
        {
            get
            {
                return this.passengerName_SurnameField;
            }
            set
            {
                this.passengerName_SurnameField = value;
            }
        }

        /// <remarks/>
        public string IssuingAirline
        {
            get
            {
                return this.issuingAirlineField;
            }
            set
            {
                this.issuingAirlineField = value;
            }
        }

        /// <remarks/>
        public string BookingRef
        {
            get
            {
                return this.bookingRefField;
            }
            set
            {
                this.bookingRefField = value;
            }
        }

        /// <remarks/>
        public string FareCalculation
        {
            get
            {
                return this.fareCalculationField;
            }
            set
            {
                this.fareCalculationField = value;
            }
        }

        /// <remarks/>
        public string Endorsements
        {
            get
            {
                return this.endorsementsField;
            }
            set
            {
                this.endorsementsField = value;
            }
        }

        /// <remarks/>
        public decimal ExchangeRate
        {
            get
            {
                return this.exchangeRateField;
            }
            set
            {
                this.exchangeRateField = value;
            }
        }

        /// <remarks/>
        public string PaymentType
        {
            get
            {
                return this.paymentTypeField;
            }
            set
            {
                this.paymentTypeField = value;
            }
        }

        /// <remarks/>
        public string AirFareCurrency
        {
            get
            {
                return this.airFareCurrencyField;
            }
            set
            {
                this.airFareCurrencyField = value;
            }
        }

        /// <remarks/>
        public decimal EquivalentFare
        {
            get
            {
                return this.equivalentFareField;
            }
            set
            {
                this.equivalentFareField = value;
            }
        }

        /// <remarks/>
        public string EquivalentFareCurrency
        {
            get
            {
                return this.equivalentFareCurrencyField;
            }
            set
            {
                this.equivalentFareCurrencyField = value;
            }
        }

        /// <remarks/>
        public decimal TotalFare
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
        public string TotalFareCurrency
        {
            get
            {
                return this.totalFareCurrencyField;
            }
            set
            {
                this.totalFareCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TaxInfo", IsNullable = false)]
        public CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocumentsETicketInfoTaxInfo[] Taxes
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
        public string ControlNumbers
        {
            get
            {
                return this.controlNumbersField;
            }
            set
            {
                this.controlNumbersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ETicketItineraryInfo", IsNullable = false)]
        public CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocumentsETicketInfoETicketItineraryInfo[] Itineraries
        {
            get
            {
                return this.itinerariesField;
            }
            set
            {
                this.itinerariesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketNumber
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocumentsETicketInfoAgencyAddress
    {

        private string addressLineField;

        private string cityNameField;

        private CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocumentsETicketInfoAgencyAddressCountryName countryNameField;

        /// <remarks/>
        public string AddressLine
        {
            get
            {
                return this.addressLineField;
            }
            set
            {
                this.addressLineField = value;
            }
        }

        /// <remarks/>
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
        public CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocumentsETicketInfoAgencyAddressCountryName CountryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocumentsETicketInfoAgencyAddressCountryName
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocumentsETicketInfoTaxInfo
    {

        private string taxTypeField;

        private string countryCodeField;

        private decimal amountField;

        private string currencyField;

        private string taxNatureField;

        /// <remarks/>
        public string TaxType
        {
            get
            {
                return this.taxTypeField;
            }
            set
            {
                this.taxTypeField = value;
            }
        }

        /// <remarks/>
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }

        /// <remarks/>
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
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
        public string TaxNature
        {
            get
            {
                return this.taxNatureField;
            }
            set
            {
                this.taxNatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationAirTravelerETicketDocumentsETicketInfoETicketItineraryInfo
    {

        private string fromField;

        private string fromTerminalField;

        private string toField;

        private string toTerminalField;

        private string carrierField;

        private ushort flightNoField;

        private string operatingAirlineCodeField;

        private string marketingAirlineCodeField;

        private string classField;

        private System.DateTime departureDateField;

        private System.DateTime arrivalDateField;

        private string fareBasisField;

        private System.DateTime notValidBeforeField;

        private System.DateTime notValidAfterField;

        private string baggageWeightMeasureUnitField;

        private byte baggageQuantityField;

        private string statusField;

        /// <remarks/>
        public string From
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }

        /// <remarks/>
        public string FromTerminal
        {
            get
            {
                return this.fromTerminalField;
            }
            set
            {
                this.fromTerminalField = value;
            }
        }

        /// <remarks/>
        public string To
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }

        /// <remarks/>
        public string ToTerminal
        {
            get
            {
                return this.toTerminalField;
            }
            set
            {
                this.toTerminalField = value;
            }
        }

        /// <remarks/>
        public string Carrier
        {
            get
            {
                return this.carrierField;
            }
            set
            {
                this.carrierField = value;
            }
        }

        /// <remarks/>
        public ushort FlightNo
        {
            get
            {
                return this.flightNoField;
            }
            set
            {
                this.flightNoField = value;
            }
        }

        /// <remarks/>
        public string OperatingAirlineCode
        {
            get
            {
                return this.operatingAirlineCodeField;
            }
            set
            {
                this.operatingAirlineCodeField = value;
            }
        }

        /// <remarks/>
        public string MarketingAirlineCode
        {
            get
            {
                return this.marketingAirlineCodeField;
            }
            set
            {
                this.marketingAirlineCodeField = value;
            }
        }

        /// <remarks/>
        public string Class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        /// <remarks/>
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
        public System.DateTime ArrivalDate
        {
            get
            {
                return this.arrivalDateField;
            }
            set
            {
                this.arrivalDateField = value;
            }
        }

        /// <remarks/>
        public string FareBasis
        {
            get
            {
                return this.fareBasisField;
            }
            set
            {
                this.fareBasisField = value;
            }
        }

        /// <remarks/>
        public System.DateTime NotValidBefore
        {
            get
            {
                return this.notValidBeforeField;
            }
            set
            {
                this.notValidBeforeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime NotValidAfter
        {
            get
            {
                return this.notValidAfterField;
            }
            set
            {
                this.notValidAfterField = value;
            }
        }

        /// <remarks/>
        public string BaggageWeightMeasureUnit
        {
            get
            {
                return this.baggageWeightMeasureUnitField;
            }
            set
            {
                this.baggageWeightMeasureUnitField = value;
            }
        }

        /// <remarks/>
        public byte BaggageQuantity
        {
            get
            {
                return this.baggageQuantityField;
            }
            set
            {
                this.baggageQuantityField = value;
            }
        }

        /// <remarks/>
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationFulfillment
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationFulfillmentPaymentDetails paymentDetailsField;

        private CreateTicketResponseOTA_AirBookRSAirReservationFulfillmentDeliveryAddress deliveryAddressField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationFulfillmentPaymentDetails PaymentDetails
        {
            get
            {
                return this.paymentDetailsField;
            }
            set
            {
                this.paymentDetailsField = value;
            }
        }

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationFulfillmentDeliveryAddress DeliveryAddress
        {
            get
            {
                return this.deliveryAddressField;
            }
            set
            {
                this.deliveryAddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationFulfillmentPaymentDetails
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationFulfillmentPaymentDetailsPaymentDetail paymentDetailField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationFulfillmentPaymentDetailsPaymentDetail PaymentDetail
        {
            get
            {
                return this.paymentDetailField;
            }
            set
            {
                this.paymentDetailField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationFulfillmentPaymentDetailsPaymentDetail
    {

        private string paymentTypeField;

        private string paymentFPTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentType
        {
            get
            {
                return this.paymentTypeField;
            }
            set
            {
                this.paymentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentFPType
        {
            get
            {
                return this.paymentFPTypeField;
            }
            set
            {
                this.paymentFPTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationFulfillmentDeliveryAddress
    {

        private object countryNameField;

        /// <remarks/>
        public object CountryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationTicketing
    {

        private string ticketTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketType
        {
            get
            {
                return this.ticketTypeField;
            }
            set
            {
                this.ticketTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationBookingReferenceID
    {

        private string typeField;

        private string iD_ContextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID_Context
        {
            get
            {
                return this.iD_ContextField;
            }
            set
            {
                this.iD_ContextField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfo
    {

        private string fareReferenceField;

        private CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoFilingAirline filingAirlineField;

        private CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoMarketingAirline marketingAirlineField;

        private CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoDepartureAirport departureAirportField;

        private CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoArrivalAirport arrivalAirportField;

        private CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoFareRules fareRulesField;

        /// <remarks/>
        public string FareReference
        {
            get
            {
                return this.fareReferenceField;
            }
            set
            {
                this.fareReferenceField = value;
            }
        }

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoFilingAirline FilingAirline
        {
            get
            {
                return this.filingAirlineField;
            }
            set
            {
                this.filingAirlineField = value;
            }
        }

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoMarketingAirline MarketingAirline
        {
            get
            {
                return this.marketingAirlineField;
            }
            set
            {
                this.marketingAirlineField = value;
            }
        }

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoDepartureAirport DepartureAirport
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
        public CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoArrivalAirport ArrivalAirport
        {
            get
            {
                return this.arrivalAirportField;
            }
            set
            {
                this.arrivalAirportField = value;
            }
        }

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoFareRules FareRules
        {
            get
            {
                return this.fareRulesField;
            }
            set
            {
                this.fareRulesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoFilingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoMarketingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoDepartureAirport
    {

        private string locationCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoArrivalAirport
    {

        private string locationCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoFareRules
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoFareRulesSubSection subSectionField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoFareRulesSubSection SubSection
        {
            get
            {
                return this.subSectionField;
            }
            set
            {
                this.subSectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoFareRulesSubSection
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoFareRulesSubSectionParagraph paragraphField;

        private string subTitleField;

        private string subCodeField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoFareRulesSubSectionParagraph Paragraph
        {
            get
            {
                return this.paragraphField;
            }
            set
            {
                this.paragraphField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubTitle
        {
            get
            {
                return this.subTitleField;
            }
            set
            {
                this.subTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubCode
        {
            get
            {
                return this.subCodeField;
            }
            set
            {
                this.subCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationFareRuleInfoFareRulesSubSectionParagraph
    {

        private string textField;

        /// <remarks/>
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceMessageInfo
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceMessageInfoPriceMessageInfo priceMessageInfoField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceMessageInfoPriceMessageInfo PriceMessageInfo
        {
            get
            {
                return this.priceMessageInfoField;
            }
            set
            {
                this.priceMessageInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceMessageInfoPriceMessageInfo
    {

        private CreateTicketResponseOTA_AirBookRSAirReservationPriceMessageInfoPriceMessageInfoMiniRulesPriceMessages miniRulesPriceMessagesField;

        /// <remarks/>
        public CreateTicketResponseOTA_AirBookRSAirReservationPriceMessageInfoPriceMessageInfoMiniRulesPriceMessages MiniRulesPriceMessages
        {
            get
            {
                return this.miniRulesPriceMessagesField;
            }
            set
            {
                this.miniRulesPriceMessagesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPriceMessageInfoPriceMessageInfoMiniRulesPriceMessages
    {

        private object textField;

        /// <remarks/>
        public object Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketResponseOTA_AirBookRSAirReservationPNRRemark
    {

        private string remarkTypeField;

        private string remarkCategoryField;

        private string noteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RemarkType
        {
            get
            {
                return this.remarkTypeField;
            }
            set
            {
                this.remarkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RemarkCategory
        {
            get
            {
                return this.remarkCategoryField;
            }
            set
            {
                this.remarkCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", IsNullable = false)]
    public partial class BookFlightResponse
    {

        private BookFlightResponseOTA_AirBookRS oTA_AirBookRSField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRS OTA_AirBookRS
        {
            get
            {
                return this.oTA_AirBookRSField;
            }
            set
            {
                this.oTA_AirBookRSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRS
    {

        private BookFlightResponseOTA_AirBookRSAirReservation airReservationField;

        private object successField;

        private byte versionField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservation AirReservation
        {
            get
            {
                return this.airReservationField;
            }
            set
            {
                this.airReservationField = value;
            }
        }

        /// <remarks/>
        public object Success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservation
    {

        private BookFlightResponseOTA_AirBookRSAirReservationAirItinerary airItineraryField;

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfo priceInfoField;

        private BookFlightResponseOTA_AirBookRSAirReservationAirTraveler[] travelerInfoField;

        private BookFlightResponseOTA_AirBookRSAirReservationFulfillment fulfillmentField;

        private BookFlightResponseOTA_AirBookRSAirReservationTicketing ticketingField;

        private BookFlightResponseOTA_AirBookRSAirReservationBookingReferenceID bookingReferenceIDField;

        private BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenalties[] flightRulePenaltiesField;

        private object flightMiniRulesField;

        private BookFlightResponseOTA_AirBookRSAirReservationPriceMessageInfo priceMessageInfoField;

        private BookFlightResponseOTA_AirBookRSAirReservationPNRRemark[] pNRRemarksField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationAirItinerary AirItinerary
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
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfo PriceInfo
        {
            get
            {
                return this.priceInfoField;
            }
            set
            {
                this.priceInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("AirTraveler", IsNullable = false)]
        public BookFlightResponseOTA_AirBookRSAirReservationAirTraveler[] TravelerInfo
        {
            get
            {
                return this.travelerInfoField;
            }
            set
            {
                this.travelerInfoField = value;
            }
        }

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationFulfillment Fulfillment
        {
            get
            {
                return this.fulfillmentField;
            }
            set
            {
                this.fulfillmentField = value;
            }
        }

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationTicketing Ticketing
        {
            get
            {
                return this.ticketingField;
            }
            set
            {
                this.ticketingField = value;
            }
        }

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationBookingReferenceID BookingReferenceID
        {
            get
            {
                return this.bookingReferenceIDField;
            }
            set
            {
                this.bookingReferenceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FlightRulePenalties")]
        public BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenalties[] FlightRulePenalties
        {
            get
            {
                return this.flightRulePenaltiesField;
            }
            set
            {
                this.flightRulePenaltiesField = value;
            }
        }

        /// <remarks/>
        public object FlightMiniRules
        {
            get
            {
                return this.flightMiniRulesField;
            }
            set
            {
                this.flightMiniRulesField = value;
            }
        }

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationPriceMessageInfo PriceMessageInfo
        {
            get
            {
                return this.priceMessageInfoField;
            }
            set
            {
                this.priceMessageInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PNRRemark", IsNullable = false)]
        public BookFlightResponseOTA_AirBookRSAirReservationPNRRemark[] PNRRemarks
        {
            get
            {
                return this.pNRRemarksField;
            }
            set
            {
                this.pNRRemarksField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationAirItinerary
    {

        private BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptions originDestinationOptionsField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptions OriginDestinationOptions
        {
            get
            {
                return this.originDestinationOptionsField;
            }
            set
            {
                this.originDestinationOptionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptions
    {

        private BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOption originDestinationOptionField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOption OriginDestinationOption
        {
            get
            {
                return this.originDestinationOptionField;
            }
            set
            {
                this.originDestinationOptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOption
    {

        private BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegment[] flightSegmentField;

        private byte refNumberField;

        private byte directionIdField;

        private ushort elapsedTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FlightSegment")]
        public BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegment[] FlightSegment
        {
            get
            {
                return this.flightSegmentField;
            }
            set
            {
                this.flightSegmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte RefNumber
        {
            get
            {
                return this.refNumberField;
            }
            set
            {
                this.refNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DirectionId
        {
            get
            {
                return this.directionIdField;
            }
            set
            {
                this.directionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ElapsedTime
        {
            get
            {
                return this.elapsedTimeField;
            }
            set
            {
                this.elapsedTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegment
    {

        private System.DateTime flightDurationField;

        private BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentDepartureAirport departureAirportField;

        private BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentArrivalAirport arrivalAirportField;

        private BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentOperatingAirline operatingAirlineField;

        private BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentEquipment equipmentField;

        private BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentMarketingAirline marketingAirlineField;

        private BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentBookingClassAvail[] bookingClassAvailsField;

        private System.DateTime departureDateTimeField;

        private System.DateTime arrivalDateTimeField;

        private ushort flightNumberField;

        private string resBookDesigCodeField;

        private string statusField;

        /// <remarks/>
        public System.DateTime FlightDuration
        {
            get
            {
                return this.flightDurationField;
            }
            set
            {
                this.flightDurationField = value;
            }
        }

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentDepartureAirport DepartureAirport
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
        public BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentArrivalAirport ArrivalAirport
        {
            get
            {
                return this.arrivalAirportField;
            }
            set
            {
                this.arrivalAirportField = value;
            }
        }

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentOperatingAirline OperatingAirline
        {
            get
            {
                return this.operatingAirlineField;
            }
            set
            {
                this.operatingAirlineField = value;
            }
        }

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentEquipment Equipment
        {
            get
            {
                return this.equipmentField;
            }
            set
            {
                this.equipmentField = value;
            }
        }

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentMarketingAirline MarketingAirline
        {
            get
            {
                return this.marketingAirlineField;
            }
            set
            {
                this.marketingAirlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("BookingClassAvail", IsNullable = false)]
        public BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentBookingClassAvail[] BookingClassAvails
        {
            get
            {
                return this.bookingClassAvailsField;
            }
            set
            {
                this.bookingClassAvailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DepartureDateTime
        {
            get
            {
                return this.departureDateTimeField;
            }
            set
            {
                this.departureDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ArrivalDateTime
        {
            get
            {
                return this.arrivalDateTimeField;
            }
            set
            {
                this.arrivalDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort FlightNumber
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this.resBookDesigCodeField;
            }
            set
            {
                this.resBookDesigCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentDepartureAirport
    {

        private string locationCodeField;

        private string terminalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Terminal
        {
            get
            {
                return this.terminalField;
            }
            set
            {
                this.terminalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentArrivalAirport
    {

        private string locationCodeField;

        private string terminalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Terminal
        {
            get
            {
                return this.terminalField;
            }
            set
            {
                this.terminalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentOperatingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentEquipment
    {

        private string airEquipTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirEquipType
        {
            get
            {
                return this.airEquipTypeField;
            }
            set
            {
                this.airEquipTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentMarketingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationAirItineraryOriginDestinationOptionsOriginDestinationOptionFlightSegmentBookingClassAvail
    {

        private string resBookDesigCodeField;

        private byte resBookDesigQuantityField;

        private string rPHField;

        private string availablePTCField;

        private string resBookDesigCabinCodeField;

        private string fareBasisField;

        private string fareTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this.resBookDesigCodeField;
            }
            set
            {
                this.resBookDesigCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ResBookDesigQuantity
        {
            get
            {
                return this.resBookDesigQuantityField;
            }
            set
            {
                this.resBookDesigQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AvailablePTC
        {
            get
            {
                return this.availablePTCField;
            }
            set
            {
                this.availablePTCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCabinCode
        {
            get
            {
                return this.resBookDesigCabinCodeField;
            }
            set
            {
                this.resBookDesigCabinCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareBasis
        {
            get
            {
                return this.fareBasisField;
            }
            set
            {
                this.fareBasisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareType
        {
            get
            {
                return this.fareTypeField;
            }
            set
            {
                this.fareTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfo
    {

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFare itinTotalFareField;

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdown[] pTC_FareBreakdownsField;

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoServiceFee[] serviceFeesField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFare ItinTotalFare
        {
            get
            {
                return this.itinTotalFareField;
            }
            set
            {
                this.itinTotalFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PTC_FareBreakdown", IsNullable = false)]
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdown[] PTC_FareBreakdowns
        {
            get
            {
                return this.pTC_FareBreakdownsField;
            }
            set
            {
                this.pTC_FareBreakdownsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ServiceFee", IsNullable = false)]
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoServiceFee[] ServiceFees
        {
            get
            {
                return this.serviceFeesField;
            }
            set
            {
                this.serviceFeesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFare
    {

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareBaseFare baseFareField;

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareMarkupFare markupFareField;

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareTotalFare totalFareField;

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareTotalAmountInTicketingCurrency totalAmountInTicketingCurrencyField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareBaseFare BaseFare
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
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareMarkupFare MarkupFare
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
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareTotalFare TotalFare
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
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareTotalAmountInTicketingCurrency TotalAmountInTicketingCurrency
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareBaseFare
    {

        private string currencyField;

        private uint amountField;

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
        public uint Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareMarkupFare
    {

        private byte amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareTotalFare
    {

        private uint amountField;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoItinTotalFareTotalAmountInTicketingCurrency
    {

        private decimal amountField;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdown
    {

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerTypeQuantity passengerTypeQuantityField;

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFare passengerFareField;

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownTicketDesignator[] ticketDesignatorsField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerTypeQuantity PassengerTypeQuantity
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
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFare PassengerFare
        {
            get
            {
                return this.passengerFareField;
            }
            set
            {
                this.passengerFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TicketDesignator", IsNullable = false)]
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownTicketDesignator[] TicketDesignators
        {
            get
            {
                return this.ticketDesignatorsField;
            }
            set
            {
                this.ticketDesignatorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerTypeQuantity
    {

        private string codeField;

        private byte quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Quantity
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFare
    {

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFareBaseFare baseFareField;

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFareMarkupFare markupFareField;

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFareTaxes taxesField;

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFareTotalFare totalFareField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFareBaseFare BaseFare
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
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFareMarkupFare MarkupFare
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
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFareTaxes Taxes
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
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFareTotalFare TotalFare
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFareBaseFare
    {

        private uint amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFareMarkupFare
    {

        private byte amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFareTaxes
    {

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFareTaxesTax taxField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFareTaxesTax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFareTaxesTax
    {

        private uint amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownPassengerFareTotalFare
    {

        private uint amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoPTC_FareBreakdownTicketDesignator
    {

        private string ticketDesignatorCodeField;

        private string ticketDesignatorExtensionField;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDesignatorExtension
        {
            get
            {
                return this.ticketDesignatorExtensionField;
            }
            set
            {
                this.ticketDesignatorExtensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoServiceFee
    {

        private BookFlightResponseOTA_AirBookRSAirReservationPriceInfoServiceFeePassengerTypeQuantity passengerTypeQuantityField;

        private byte amountField;

        private byte markupFeeAmountField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationPriceInfoServiceFeePassengerTypeQuantity PassengerTypeQuantity
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte MarkupFeeAmount
        {
            get
            {
                return this.markupFeeAmountField;
            }
            set
            {
                this.markupFeeAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceInfoServiceFeePassengerTypeQuantity
    {

        private string codeField;

        private byte quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Quantity
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationAirTraveler
    {

        private byte numberOfBaggagesField;

        private byte numberOfBaggages1Field;

        private byte handLuggagesField;

        private byte handLuggages1Field;

        private BookFlightResponseOTA_AirBookRSAirReservationAirTravelerPersonName personNameField;

        private BookFlightResponseOTA_AirBookRSAirReservationAirTravelerTelephone telephoneField;

        private string emailField;

        private BookFlightResponseOTA_AirBookRSAirReservationAirTravelerDocument[] documentField;

        private System.DateTime birthDateField;

        private string passengerTypeCodeField;

        private string gender;

        public string Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                this.gender = value;
            }
        }

        /// <remarks/>
        public byte NumberOfBaggages
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
        public byte NumberOfBaggages1
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
        public byte HandLuggages
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
        public byte HandLuggages1
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
        public BookFlightResponseOTA_AirBookRSAirReservationAirTravelerPersonName PersonName
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
        public BookFlightResponseOTA_AirBookRSAirReservationAirTravelerTelephone Telephone
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
        public string Email
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
        [System.Xml.Serialization.XmlElementAttribute("Document")]
        public BookFlightResponseOTA_AirBookRSAirReservationAirTravelerDocument[] Document
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationAirTravelerPersonName
    {

        private string namePrefixField;

        private string givenNameField;

        private string surnameField;

        /// <remarks/>
        public string NamePrefix
        {
            get
            {
                return this.namePrefixField;
            }
            set
            {
                this.namePrefixField = value;
            }
        }

        /// <remarks/>
        public string GivenName
        {
            get
            {
                return this.givenNameField;
            }
            set
            {
                this.givenNameField = value;
            }
        }

        /// <remarks/>
        public string Surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationAirTravelerTelephone
    {

        private string phoneTypeField;

        private string locationCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PhoneType
        {
            get
            {
                return this.phoneTypeField;
            }
            set
            {
                this.phoneTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationAirTravelerDocument
    {

        private string docIDField;

        private string docTypeField;

        private string innerDocTypeField;

        private System.DateTime expireDateField;

        private bool expireDateFieldSpecified;

        private string docIssueCountryField;

        private string docIssueLocationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocID
        {
            get
            {
                return this.docIDField;
            }
            set
            {
                this.docIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocType
        {
            get
            {
                return this.docTypeField;
            }
            set
            {
                this.docTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InnerDocType
        {
            get
            {
                return this.innerDocTypeField;
            }
            set
            {
                this.innerDocTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpireDateSpecified
        {
            get
            {
                return this.expireDateFieldSpecified;
            }
            set
            {
                this.expireDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocIssueCountry
        {
            get
            {
                return this.docIssueCountryField;
            }
            set
            {
                this.docIssueCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocIssueLocation
        {
            get
            {
                return this.docIssueLocationField;
            }
            set
            {
                this.docIssueLocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationFulfillment
    {

        private BookFlightResponseOTA_AirBookRSAirReservationFulfillmentPaymentDetails paymentDetailsField;

        private BookFlightResponseOTA_AirBookRSAirReservationFulfillmentDeliveryAddress deliveryAddressField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationFulfillmentPaymentDetails PaymentDetails
        {
            get
            {
                return this.paymentDetailsField;
            }
            set
            {
                this.paymentDetailsField = value;
            }
        }

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationFulfillmentDeliveryAddress DeliveryAddress
        {
            get
            {
                return this.deliveryAddressField;
            }
            set
            {
                this.deliveryAddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationFulfillmentPaymentDetails
    {

        private BookFlightResponseOTA_AirBookRSAirReservationFulfillmentPaymentDetailsPaymentDetail paymentDetailField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationFulfillmentPaymentDetailsPaymentDetail PaymentDetail
        {
            get
            {
                return this.paymentDetailField;
            }
            set
            {
                this.paymentDetailField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationFulfillmentPaymentDetailsPaymentDetail
    {

        private string paymentTypeField;

        private string paymentFPTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentType
        {
            get
            {
                return this.paymentTypeField;
            }
            set
            {
                this.paymentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaymentFPType
        {
            get
            {
                return this.paymentFPTypeField;
            }
            set
            {
                this.paymentFPTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationFulfillmentDeliveryAddress
    {

        private object countryNameField;

        /// <remarks/>
        public object CountryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationTicketing
    {

        private System.DateTime ticketTimeLimitField;

        private string ticketTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime TicketTimeLimit
        {
            get
            {
                return this.ticketTimeLimitField;
            }
            set
            {
                this.ticketTimeLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketType
        {
            get
            {
                return this.ticketTypeField;
            }
            set
            {
                this.ticketTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationBookingReferenceID
    {

        private string typeField;

        private string iD_ContextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID_Context
        {
            get
            {
                return this.iD_ContextField;
            }
            set
            {
                this.iD_ContextField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenalties
    {

        private BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfo fareRuleInfoField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfo FareRuleInfo
        {
            get
            {
                return this.fareRuleInfoField;
            }
            set
            {
                this.fareRuleInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfo
    {

        private string fareReferenceField;

        private BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoFilingAirline filingAirlineField;

        private BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoMarketingAirline marketingAirlineField;

        private BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoDepartureAirport departureAirportField;

        private BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoArrivalAirport arrivalAirportField;

        private BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoFareRules fareRulesField;

        /// <remarks/>
        public string FareReference
        {
            get
            {
                return this.fareReferenceField;
            }
            set
            {
                this.fareReferenceField = value;
            }
        }

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoFilingAirline FilingAirline
        {
            get
            {
                return this.filingAirlineField;
            }
            set
            {
                this.filingAirlineField = value;
            }
        }

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoMarketingAirline MarketingAirline
        {
            get
            {
                return this.marketingAirlineField;
            }
            set
            {
                this.marketingAirlineField = value;
            }
        }

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoDepartureAirport DepartureAirport
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
        public BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoArrivalAirport ArrivalAirport
        {
            get
            {
                return this.arrivalAirportField;
            }
            set
            {
                this.arrivalAirportField = value;
            }
        }

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoFareRules FareRules
        {
            get
            {
                return this.fareRulesField;
            }
            set
            {
                this.fareRulesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoFilingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoMarketingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoDepartureAirport
    {

        private string locationCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoArrivalAirport
    {

        private string locationCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoFareRules
    {

        private BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoFareRulesSubSection subSectionField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoFareRulesSubSection SubSection
        {
            get
            {
                return this.subSectionField;
            }
            set
            {
                this.subSectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoFareRulesSubSection
    {

        private BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoFareRulesSubSectionParagraph paragraphField;

        private string subTitleField;

        private string subCodeField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoFareRulesSubSectionParagraph Paragraph
        {
            get
            {
                return this.paragraphField;
            }
            set
            {
                this.paragraphField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubTitle
        {
            get
            {
                return this.subTitleField;
            }
            set
            {
                this.subTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubCode
        {
            get
            {
                return this.subCodeField;
            }
            set
            {
                this.subCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationFlightRulePenaltiesFareRuleInfoFareRulesSubSectionParagraph
    {

        private string textField;

        /// <remarks/>
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceMessageInfo
    {

        private BookFlightResponseOTA_AirBookRSAirReservationPriceMessageInfoPriceMessageInfo priceMessageInfoField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationPriceMessageInfoPriceMessageInfo PriceMessageInfo
        {
            get
            {
                return this.priceMessageInfoField;
            }
            set
            {
                this.priceMessageInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceMessageInfoPriceMessageInfo
    {

        private BookFlightResponseOTA_AirBookRSAirReservationPriceMessageInfoPriceMessageInfoMiniRulesPriceMessages miniRulesPriceMessagesField;

        /// <remarks/>
        public BookFlightResponseOTA_AirBookRSAirReservationPriceMessageInfoPriceMessageInfoMiniRulesPriceMessages MiniRulesPriceMessages
        {
            get
            {
                return this.miniRulesPriceMessagesField;
            }
            set
            {
                this.miniRulesPriceMessagesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPriceMessageInfoPriceMessageInfoMiniRulesPriceMessages
    {

        private object textField;

        /// <remarks/>
        public object Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightResponseOTA_AirBookRSAirReservationPNRRemark
    {

        private string remarkTypeField;

        private string remarkCategoryField;

        private string noteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RemarkType
        {
            get
            {
                return this.remarkTypeField;
            }
            set
            {
                this.remarkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RemarkCategory
        {
            get
            {
                return this.remarkCategoryField;
            }
            set
            {
                this.remarkCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }
    }



}
