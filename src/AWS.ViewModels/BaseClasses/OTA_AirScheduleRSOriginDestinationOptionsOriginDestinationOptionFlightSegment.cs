namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_AirScheduleRSOriginDestinationOptionsOriginDestinationOptionFlightSegment : FlightSegmentType
    {

        private FreeTextType[] commentField;

        private MarketingCabinType[] marketingCabinField;

        private OperationSchedulesType daysOfOperationField;

        private OTA_AirScheduleRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentBookingClass[] bookingClassField;

        private OTA_AirScheduleRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentTrafficRestrictionInfo[] trafficRestrictionInfoField;

        private string journeyDurationField;

        private bool smokingAllowedField;

        private decimal onTimeRateField;

        private bool onTimeRateFieldSpecified;

        private System.DateTime scheduleValidStartDateField;

        private bool scheduleValidStartDateFieldSpecified;

        private System.DateTime scheduleValidEndDateField;

        private bool scheduleValidEndDateFieldSpecified;

        private string participationLevelCodeField;

        private string dateChangeNbrField;

        private bool fLIFO_IndField;

        private bool fLIFO_IndFieldSpecified;

        public OTA_AirScheduleRSOriginDestinationOptionsOriginDestinationOptionFlightSegment()
        {
            this.smokingAllowedField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comment", Order = 0)]
        public FreeTextType[] Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MarketingCabin", Order = 1)]
        public MarketingCabinType[] MarketingCabin
        {
            get
            {
                return this.marketingCabinField;
            }
            set
            {
                this.marketingCabinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public OperationSchedulesType DaysOfOperation
        {
            get
            {
                return this.daysOfOperationField;
            }
            set
            {
                this.daysOfOperationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BookingClass", Order = 3)]
        public OTA_AirScheduleRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentBookingClass[] BookingClass
        {
            get
            {
                return this.bookingClassField;
            }
            set
            {
                this.bookingClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TrafficRestrictionInfo", Order = 4)]
        public OTA_AirScheduleRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentTrafficRestrictionInfo[] TrafficRestrictionInfo
        {
            get
            {
                return this.trafficRestrictionInfoField;
            }
            set
            {
                this.trafficRestrictionInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public string JourneyDuration
        {
            get
            {
                return this.journeyDurationField;
            }
            set
            {
                this.journeyDurationField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ScheduleValidStartDate
        {
            get
            {
                return this.scheduleValidStartDateField;
            }
            set
            {
                this.scheduleValidStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScheduleValidStartDateSpecified
        {
            get
            {
                return this.scheduleValidStartDateFieldSpecified;
            }
            set
            {
                this.scheduleValidStartDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ScheduleValidEndDate
        {
            get
            {
                return this.scheduleValidEndDateField;
            }
            set
            {
                this.scheduleValidEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScheduleValidEndDateSpecified
        {
            get
            {
                return this.scheduleValidEndDateFieldSpecified;
            }
            set
            {
                this.scheduleValidEndDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParticipationLevelCode
        {
            get
            {
                return this.participationLevelCodeField;
            }
            set
            {
                this.participationLevelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DateChangeNbr
        {
            get
            {
                return this.dateChangeNbrField;
            }
            set
            {
                this.dateChangeNbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FLIFO_Ind
        {
            get
            {
                return this.fLIFO_IndField;
            }
            set
            {
                this.fLIFO_IndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FLIFO_IndSpecified
        {
            get
            {
                return this.fLIFO_IndFieldSpecified;
            }
            set
            {
                this.fLIFO_IndFieldSpecified = value;
            }
        }
    }
}