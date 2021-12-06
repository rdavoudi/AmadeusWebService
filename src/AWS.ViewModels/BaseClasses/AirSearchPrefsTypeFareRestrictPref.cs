namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirSearchPrefsTypeFareRestrictPref
    {

        private AdvResTicketingType advResTicketingField;

        private StayRestrictionsType stayRestrictionsField;

        private VoluntaryChangesType voluntaryChangesField;

        private string fareRestrictionField;

        private string dateField;

        private string fareDisplayCurrencyField;

        private string currencyOverrideField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AdvResTicketingType AdvResTicketing
        {
            get
            {
                return this.advResTicketingField;
            }
            set
            {
                this.advResTicketingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public StayRestrictionsType StayRestrictions
        {
            get
            {
                return this.stayRestrictionsField;
            }
            set
            {
                this.stayRestrictionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public VoluntaryChangesType VoluntaryChanges
        {
            get
            {
                return this.voluntaryChangesField;
            }
            set
            {
                this.voluntaryChangesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareRestriction
        {
            get
            {
                return this.fareRestrictionField;
            }
            set
            {
                this.fareRestrictionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareDisplayCurrency
        {
            get
            {
                return this.fareDisplayCurrencyField;
            }
            set
            {
                this.fareDisplayCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyOverride
        {
            get
            {
                return this.currencyOverrideField;
            }
            set
            {
                this.currencyOverrideField = value;
            }
        }
    }
}