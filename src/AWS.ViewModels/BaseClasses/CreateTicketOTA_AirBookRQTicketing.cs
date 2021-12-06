namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketOTA_AirBookRQTicketing : TicketingInfoType
    {

        private CreateTicketOTA_AirBookRQTicketingTicketingVendor ticketingVendorField;

        private CreateTicketOTA_AirBookRQTicketingPricingSystem pricingSystemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CreateTicketOTA_AirBookRQTicketingTicketingVendor TicketingVendor
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
        public CreateTicketOTA_AirBookRQTicketingPricingSystem PricingSystem
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