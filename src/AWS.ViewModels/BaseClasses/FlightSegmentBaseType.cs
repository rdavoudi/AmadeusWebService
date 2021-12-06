namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FlightSegmentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_AirScheduleRSOriginDestinationOptionsOriginDestinationOptionFlightSegment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_AirSeatMapRSSeatMapResponsesSeatMapResponseFlightSegmentInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BookFlightSegmentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FlightSegmentBaseType
    {

        private System.Nullable<System.DateTime> flightDurationField;

        private FlightSegmentBaseTypeDepartureAirport departureAirportField;

        private FlightSegmentBaseTypeArrivalAirport arrivalAirportField;

        private OperatingAirlineType operatingAirlineField;

        private EquipmentType[] equipmentField;

        private System.DateTime departureDateTimeField;

        private bool departureDateTimeFieldSpecified;

        private System.DateTime arrivalDateTimeField;

        private bool arrivalDateTimeFieldSpecified;

        private string stopQuantityField;

        private string rPHField;

        private string infoSourceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<System.DateTime> FlightDuration
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public FlightSegmentBaseTypeDepartureAirport DepartureAirport
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public FlightSegmentBaseTypeArrivalAirport ArrivalAirport
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public OperatingAirlineType OperatingAirline
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
        [System.Xml.Serialization.XmlElementAttribute("Equipment", Order = 4)]
        public EquipmentType[] Equipment
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepartureDateTimeSpecified
        {
            get
            {
                return this.departureDateTimeFieldSpecified;
            }
            set
            {
                this.departureDateTimeFieldSpecified = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArrivalDateTimeSpecified
        {
            get
            {
                return this.arrivalDateTimeFieldSpecified;
            }
            set
            {
                this.arrivalDateTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string StopQuantity
        {
            get
            {
                return this.stopQuantityField;
            }
            set
            {
                this.stopQuantityField = value;
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
        public string InfoSource
        {
            get
            {
                return this.infoSourceField;
            }
            set
            {
                this.infoSourceField = value;
            }
        }
    }
}