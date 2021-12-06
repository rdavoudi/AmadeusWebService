namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SourceType
    {

        private SourceTypeRequestorID requestorIDField;

        private SourceTypePosition positionField;

        private SourceTypeBookingChannel bookingChannelField;

        private string agentSineField;

        private string pseudoCityCodeField;

        private string iSOCountryField;

        private string iSOCurrencyField;

        private string agentDutyCodeField;

        private string airlineVendorIDField;

        private string airportCodeField;

        private string firstDepartPointField;

        private string eRSP_UserIDField;

        private string terminalIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public SourceTypeRequestorID RequestorID
        {
            get
            {
                return this.requestorIDField;
            }
            set
            {
                this.requestorIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public SourceTypePosition Position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public SourceTypeBookingChannel BookingChannel
        {
            get
            {
                return this.bookingChannelField;
            }
            set
            {
                this.bookingChannelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgentSine
        {
            get
            {
                return this.agentSineField;
            }
            set
            {
                this.agentSineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PseudoCityCode
        {
            get
            {
                return this.pseudoCityCodeField;
            }
            set
            {
                this.pseudoCityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ISOCountry
        {
            get
            {
                return this.iSOCountryField;
            }
            set
            {
                this.iSOCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ISOCurrency
        {
            get
            {
                return this.iSOCurrencyField;
            }
            set
            {
                this.iSOCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgentDutyCode
        {
            get
            {
                return this.agentDutyCodeField;
            }
            set
            {
                this.agentDutyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirlineVendorID
        {
            get
            {
                return this.airlineVendorIDField;
            }
            set
            {
                this.airlineVendorIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirportCode
        {
            get
            {
                return this.airportCodeField;
            }
            set
            {
                this.airportCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FirstDepartPoint
        {
            get
            {
                return this.firstDepartPointField;
            }
            set
            {
                this.firstDepartPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ERSP_UserID
        {
            get
            {
                return this.eRSP_UserIDField;
            }
            set
            {
                this.eRSP_UserIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TerminalID
        {
            get
            {
                return this.terminalIDField;
            }
            set
            {
                this.terminalIDField = value;
            }
        }
    }
}