namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightOTA_AirLowFareSearchRQTravelPreferences : AirSearchPrefsType
    {

        private SearchFlightOTA_AirLowFareSearchRQTravelPreferencesFlexDatePref flexDatePrefField;

        private bool flexDatePrefFieldSpecified;

        private bool flexWeekendIndicatorField;

        private bool flexWeekendIndicatorFieldSpecified;

        private bool flexLevelIndicatorField;

        private bool flexLevelIndicatorFieldSpecified;

        private bool noFareBreakIndicatorField;

        private bool noFareBreakIndicatorFieldSpecified;

        private string[] originDestinationRPHsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SearchFlightOTA_AirLowFareSearchRQTravelPreferencesFlexDatePref FlexDatePref
        {
            get
            {
                return this.flexDatePrefField;
            }
            set
            {
                this.flexDatePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FlexDatePrefSpecified
        {
            get
            {
                return this.flexDatePrefFieldSpecified;
            }
            set
            {
                this.flexDatePrefFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FlexWeekendIndicator
        {
            get
            {
                return this.flexWeekendIndicatorField;
            }
            set
            {
                this.flexWeekendIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FlexWeekendIndicatorSpecified
        {
            get
            {
                return this.flexWeekendIndicatorFieldSpecified;
            }
            set
            {
                this.flexWeekendIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FlexLevelIndicator
        {
            get
            {
                return this.flexLevelIndicatorField;
            }
            set
            {
                this.flexLevelIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FlexLevelIndicatorSpecified
        {
            get
            {
                return this.flexLevelIndicatorFieldSpecified;
            }
            set
            {
                this.flexLevelIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NoFareBreakIndicator
        {
            get
            {
                return this.noFareBreakIndicatorField;
            }
            set
            {
                this.noFareBreakIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NoFareBreakIndicatorSpecified
        {
            get
            {
                return this.noFareBreakIndicatorFieldSpecified;
            }
            set
            {
                this.noFareBreakIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] OriginDestinationRPHs
        {
            get
            {
                return this.originDestinationRPHsField;
            }
            set
            {
                this.originDestinationRPHsField = value;
            }
        }
    }
}