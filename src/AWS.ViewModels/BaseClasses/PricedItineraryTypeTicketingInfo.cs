namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PricedItineraryTypeTicketingInfo : TicketingInfoRS_Type
    {

        private PricedItineraryTypeTicketingInfoDeliveryInfo[] deliveryInfoField;

        private string[] paymentTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryInfo", Order = 0)]
        public PricedItineraryTypeTicketingInfoDeliveryInfo[] DeliveryInfo
        {
            get
            {
                return this.deliveryInfoField;
            }
            set
            {
                this.deliveryInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] PaymentType
        {
            get
            {
                return this.paymentTypeField;
            }
            set
            {
                this.paymentTypeField = value;
            }
        }
    }
}