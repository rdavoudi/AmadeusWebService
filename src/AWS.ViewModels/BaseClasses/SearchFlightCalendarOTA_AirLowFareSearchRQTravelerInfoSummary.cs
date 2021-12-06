namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightCalendarOTA_AirLowFareSearchRQTravelerInfoSummary : TravelerInfoSummaryType
    {

        private bool forcePTCField;

        private bool forcePTCFieldSpecified;

        private bool familyCardField;

        private bool familyCardFieldSpecified;

        private bool familyTypeField;

        private bool familyTypeFieldSpecified;

        private bool familyDiscountField;

        private bool familyDiscountFieldSpecified;

        private string ticketingCountryCodeField;

        private bool specificPTC_IndicatorField;

        private bool specificPTC_IndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ForcePTC
        {
            get
            {
                return this.forcePTCField;
            }
            set
            {
                this.forcePTCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ForcePTCSpecified
        {
            get
            {
                return this.forcePTCFieldSpecified;
            }
            set
            {
                this.forcePTCFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FamilyCard
        {
            get
            {
                return this.familyCardField;
            }
            set
            {
                this.familyCardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FamilyCardSpecified
        {
            get
            {
                return this.familyCardFieldSpecified;
            }
            set
            {
                this.familyCardFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FamilyType
        {
            get
            {
                return this.familyTypeField;
            }
            set
            {
                this.familyTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FamilyTypeSpecified
        {
            get
            {
                return this.familyTypeFieldSpecified;
            }
            set
            {
                this.familyTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FamilyDiscount
        {
            get
            {
                return this.familyDiscountField;
            }
            set
            {
                this.familyDiscountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FamilyDiscountSpecified
        {
            get
            {
                return this.familyDiscountFieldSpecified;
            }
            set
            {
                this.familyDiscountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketingCountryCode
        {
            get
            {
                return this.ticketingCountryCodeField;
            }
            set
            {
                this.ticketingCountryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SpecificPTC_Indicator
        {
            get
            {
                return this.specificPTC_IndicatorField;
            }
            set
            {
                this.specificPTC_IndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SpecificPTC_IndicatorSpecified
        {
            get
            {
                return this.specificPTC_IndicatorFieldSpecified;
            }
            set
            {
                this.specificPTC_IndicatorFieldSpecified = value;
            }
        }
    }
}