namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class LocationOpeningHour
    {

        private string openingHoursField;

        private string dayOfWeekField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OpeningHours
        {
            get
            {
                return this.openingHoursField;
            }
            set
            {
                this.openingHoursField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DayOfWeek
        {
            get
            {
                return this.dayOfWeekField;
            }
            set
            {
                this.dayOfWeekField = value;
            }
        }
    }
}