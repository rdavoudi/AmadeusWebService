namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightOTA_AirLowFareSearchRQAdvanceSearchInfoMaxLayoverPerConnection
    {

        private int hourField;

        private int minuteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Hour
        {
            get
            {
                return this.hourField;
            }
            set
            {
                this.hourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Minute
        {
            get
            {
                return this.minuteField;
            }
            set
            {
                this.minuteField = value;
            }
        }
    }
}