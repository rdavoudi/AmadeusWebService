namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightOTA_AirBookRQTicketing : TicketingInfoType
    {

        private BookFlightOTA_AirBookRQTicketingTicketingVendor ticketingVendorField;

        private BookFlightOTA_AirBookRQTicketingPricingSystem pricingSystemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public BookFlightOTA_AirBookRQTicketingTicketingVendor TicketingVendor
        {
            get
            {
                return this.ticketingVendorField;
            }
            set
            {
                this.ticketingVendorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public BookFlightOTA_AirBookRQTicketingPricingSystem PricingSystem
        {
            get
            {
                return this.pricingSystemField;
            }
            set
            {
                this.pricingSystemField = value;
            }
        }
    }
}