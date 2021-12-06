namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightSegmentType : FlightSegmentType
    {

        private string marriageGrpField;

        private ArrayOfBookFlightSegmentTypeBookingClassAvailBookingClassAvail[] bookingClassAvailsField;

        private BookFlightSegmentTypeFlightCharacteristic flightCharacteristicField;

        private FreeTextType[] commentField;

        private BookFlightSegmentTypeStopLocation[] stopLocationField;

        private string resBookDesigCodeField;

        private string numberInPartyField;

        private string statusField;

        private BookFlightSegmentTypeE_TicketEligibility e_TicketEligibilityField;

        private bool e_TicketEligibilityFieldSpecified;

        private string mealCodeField;

        private DayOfWeekType departureDayField;

        private bool departureDayFieldSpecified;

        private bool stopoverIndField;

        private bool stopoverIndFieldSpecified;

        private string lineNumberField;

        private string connectionTypeField;

        private string participationLevelCodeField;

        private string distanceField;

        private string dateChangeNbrField;

        private bool validConnectionIndField;

        private bool validConnectionIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string MarriageGrp
        {
            get
            {
                return this.marriageGrpField;
            }
            set
            {
                this.marriageGrpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("BookingClassAvail", IsNullable = false)]
        public ArrayOfBookFlightSegmentTypeBookingClassAvailBookingClassAvail[] BookingClassAvails
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public BookFlightSegmentTypeFlightCharacteristic FlightCharacteristic
        {
            get
            {
                return this.flightCharacteristicField;
            }
            set
            {
                this.flightCharacteristicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comment", Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute("StopLocation", Order = 4)]
        public BookFlightSegmentTypeStopLocation[] StopLocation
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string NumberInParty
        {
            get
            {
                return this.numberInPartyField;
            }
            set
            {
                this.numberInPartyField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public BookFlightSegmentTypeE_TicketEligibility E_TicketEligibility
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool E_TicketEligibilitySpecified
        {
            get
            {
                return this.e_TicketEligibilityFieldSpecified;
            }
            set
            {
                this.e_TicketEligibilityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MealCode
        {
            get
            {
                return this.mealCodeField;
            }
            set
            {
                this.mealCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DayOfWeekType DepartureDay
        {
            get
            {
                return this.departureDayField;
            }
            set
            {
                this.departureDayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepartureDaySpecified
        {
            get
            {
                return this.departureDayFieldSpecified;
            }
            set
            {
                this.departureDayFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool StopoverInd
        {
            get
            {
                return this.stopoverIndField;
            }
            set
            {
                this.stopoverIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StopoverIndSpecified
        {
            get
            {
                return this.stopoverIndFieldSpecified;
            }
            set
            {
                this.stopoverIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string LineNumber
        {
            get
            {
                return this.lineNumberField;
            }
            set
            {
                this.lineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ConnectionType
        {
            get
            {
                return this.connectionTypeField;
            }
            set
            {
                this.connectionTypeField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string Distance
        {
            get
            {
                return this.distanceField;
            }
            set
            {
                this.distanceField = value;
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
        public bool ValidConnectionInd
        {
            get
            {
                return this.validConnectionIndField;
            }
            set
            {
                this.validConnectionIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidConnectionIndSpecified
        {
            get
            {
                return this.validConnectionIndFieldSpecified;
            }
            set
            {
                this.validConnectionIndFieldSpecified = value;
            }
        }
    }
}