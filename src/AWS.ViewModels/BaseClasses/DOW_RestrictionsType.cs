namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class DOW_RestrictionsType
    {

        private DOW_RestrictionsTypeAvailableDaysOfWeek availableDaysOfWeekField;

        private DOW_RestrictionsTypeArrivalDaysOfWeek arrivalDaysOfWeekField;

        private DOW_RestrictionsTypeDepartureDaysOfWeek departureDaysOfWeekField;

        private DOW_RestrictionsTypeRequiredDaysOfWeek requiredDaysOfWeekField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public DOW_RestrictionsTypeAvailableDaysOfWeek AvailableDaysOfWeek
        {
            get
            {
                return this.availableDaysOfWeekField;
            }
            set
            {
                this.availableDaysOfWeekField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public DOW_RestrictionsTypeArrivalDaysOfWeek ArrivalDaysOfWeek
        {
            get
            {
                return this.arrivalDaysOfWeekField;
            }
            set
            {
                this.arrivalDaysOfWeekField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public DOW_RestrictionsTypeDepartureDaysOfWeek DepartureDaysOfWeek
        {
            get
            {
                return this.departureDaysOfWeekField;
            }
            set
            {
                this.departureDaysOfWeekField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public DOW_RestrictionsTypeRequiredDaysOfWeek RequiredDaysOfWeek
        {
            get
            {
                return this.requiredDaysOfWeekField;
            }
            set
            {
                this.requiredDaysOfWeekField = value;
            }
        }
    }
}