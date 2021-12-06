namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class DateTimeSpanTypeEndDateWindow
    {

        private string earliestDateField;

        private string latestDateField;

        private DayOfWeekType dOWField;

        private bool dOWFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EarliestDate
        {
            get
            {
                return this.earliestDateField;
            }
            set
            {
                this.earliestDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LatestDate
        {
            get
            {
                return this.latestDateField;
            }
            set
            {
                this.latestDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DayOfWeekType DOW
        {
            get
            {
                return this.dOWField;
            }
            set
            {
                this.dOWField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DOWSpecified
        {
            get
            {
                return this.dOWFieldSpecified;
            }
            set
            {
                this.dOWFieldSpecified = value;
            }
        }
    }
}