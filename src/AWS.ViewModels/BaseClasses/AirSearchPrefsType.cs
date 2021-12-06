namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirSearchPrefsType
    {

        private AirSearchPrefsTypeVendorPref[] vendorPrefField;

        private AirSearchPrefsTypeFlightTypePref[] flightTypePrefField;

        private AirSearchPrefsTypeFareRestrictPref[] fareRestrictPrefField;

        private EquipmentTypePref[] equipPrefField;

        private AirSearchPrefsTypeCabinPref[] cabinPrefField;

        private AirSearchPrefsTypeTicketDistribPref[] ticketDistribPrefField;

        private bool smokingAllowedField;

        private decimal onTimeRateField;

        private bool onTimeRateFieldSpecified;

        private bool eTicketDesiredField;

        private string maxStopsQuantityField;

        private string startField;

        private string durationField;

        private string endField;

        public AirSearchPrefsType()
        {
            this.smokingAllowedField = false;
            this.eTicketDesiredField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VendorPref", Order = 0)]
        public AirSearchPrefsTypeVendorPref[] VendorPref
        {
            get
            {
                return this.vendorPrefField;
            }
            set
            {
                this.vendorPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FlightTypePref", Order = 1)]
        public AirSearchPrefsTypeFlightTypePref[] FlightTypePref
        {
            get
            {
                return this.flightTypePrefField;
            }
            set
            {
                this.flightTypePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FareRestrictPref", Order = 2)]
        public AirSearchPrefsTypeFareRestrictPref[] FareRestrictPref
        {
            get
            {
                return this.fareRestrictPrefField;
            }
            set
            {
                this.fareRestrictPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipPref", Order = 3)]
        public EquipmentTypePref[] EquipPref
        {
            get
            {
                return this.equipPrefField;
            }
            set
            {
                this.equipPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CabinPref", Order = 4)]
        public AirSearchPrefsTypeCabinPref[] CabinPref
        {
            get
            {
                return this.cabinPrefField;
            }
            set
            {
                this.cabinPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TicketDistribPref", Order = 5)]
        public AirSearchPrefsTypeTicketDistribPref[] TicketDistribPref
        {
            get
            {
                return this.ticketDistribPrefField;
            }
            set
            {
                this.ticketDistribPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SmokingAllowed
        {
            get
            {
                return this.smokingAllowedField;
            }
            set
            {
                this.smokingAllowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal OnTimeRate
        {
            get
            {
                return this.onTimeRateField;
            }
            set
            {
                this.onTimeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OnTimeRateSpecified
        {
            get
            {
                return this.onTimeRateFieldSpecified;
            }
            set
            {
                this.onTimeRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ETicketDesired
        {
            get
            {
                return this.eTicketDesiredField;
            }
            set
            {
                this.eTicketDesiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaxStopsQuantity
        {
            get
            {
                return this.maxStopsQuantityField;
            }
            set
            {
                this.maxStopsQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
    }
}