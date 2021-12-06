namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirReservationTypeFulfillment
    {

        private PaymentDetailType[] paymentDetailsField;

        private AddressType deliveryAddressField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PaymentDetail", IsNullable = false)]
        public PaymentDetailType[] PaymentDetails
        {
            get
            {
                return this.paymentDetailsField;
            }
            set
            {
                this.paymentDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AddressType DeliveryAddress
        {
            get
            {
                return this.deliveryAddressField;
            }
            set
            {
                this.deliveryAddressField = value;
            }
        }
    }
}