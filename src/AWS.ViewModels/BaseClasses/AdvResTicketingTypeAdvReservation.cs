namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AdvResTicketingTypeAdvReservation
    {

        private string latestTimeOfDayField;

        private string latestPeriodField;

        private StayUnitType latestUnitField;

        private bool latestUnitFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LatestTimeOfDay
        {
            get
            {
                return this.latestTimeOfDayField;
            }
            set
            {
                this.latestTimeOfDayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LatestPeriod
        {
            get
            {
                return this.latestPeriodField;
            }
            set
            {
                this.latestPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StayUnitType LatestUnit
        {
            get
            {
                return this.latestUnitField;
            }
            set
            {
                this.latestUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LatestUnitSpecified
        {
            get
            {
                return this.latestUnitFieldSpecified;
            }
            set
            {
                this.latestUnitFieldSpecified = value;
            }
        }
    }
}