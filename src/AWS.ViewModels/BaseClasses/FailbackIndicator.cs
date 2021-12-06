namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FailbackIndicator
    {

        private FailbackExceptionErrorType failbackStatusField;

        private FailbackParameter[] failbackParameterField;

        private ScheduleChangeParameter[] scheduleChangeParameterField;

        private SeatTakenParameter[] seatTakenParameterField;

        private FarebasisChangesParameter[] farebasisChangesParameterField;

        private AncillaryChangeParameter[] ancillaryChangeParameterField;

        private FailbackFlightRules failbackFlightRulesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public FailbackExceptionErrorType FailbackStatus
        {
            get
            {
                return this.failbackStatusField;
            }
            set
            {
                this.failbackStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FailbackParameter", Order = 1)]
        public FailbackParameter[] FailbackParameter
        {
            get
            {
                return this.failbackParameterField;
            }
            set
            {
                this.failbackParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScheduleChangeParameter", Order = 2)]
        public ScheduleChangeParameter[] ScheduleChangeParameter
        {
            get
            {
                return this.scheduleChangeParameterField;
            }
            set
            {
                this.scheduleChangeParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SeatTakenParameter", Order = 3)]
        public SeatTakenParameter[] SeatTakenParameter
        {
            get
            {
                return this.seatTakenParameterField;
            }
            set
            {
                this.seatTakenParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FarebasisChangesParameter", Order = 4)]
        public FarebasisChangesParameter[] FarebasisChangesParameter
        {
            get
            {
                return this.farebasisChangesParameterField;
            }
            set
            {
                this.farebasisChangesParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AncillaryChangeParameter", Order = 5)]
        public AncillaryChangeParameter[] AncillaryChangeParameter
        {
            get
            {
                return this.ancillaryChangeParameterField;
            }
            set
            {
                this.ancillaryChangeParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public FailbackFlightRules FailbackFlightRules
        {
            get
            {
                return this.failbackFlightRulesField;
            }
            set
            {
                this.failbackFlightRulesField = value;
            }
        }
    }
}