namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightOTA_AirBookRQFulfillment
    {

        private PaymentDetailType[] paymentDetailsField;

        private AddressType deliveryAddressField;

        private PersonNameType nameField;

        private BookFlightOTA_AirBookRQFulfillmentReceipt receiptField;

        private BookFlightOTA_AirBookRQFulfillmentPaymentText[] paymentTextField;

        private BookFlightOTA_AirBookRQFulfillmentLCCUserLogin lCCUserLoginField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public PersonNameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public BookFlightOTA_AirBookRQFulfillmentReceipt Receipt
        {
            get
            {
                return this.receiptField;
            }
            set
            {
                this.receiptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentText", Order = 4)]
        public BookFlightOTA_AirBookRQFulfillmentPaymentText[] PaymentText
        {
            get
            {
                return this.paymentTextField;
            }
            set
            {
                this.paymentTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public BookFlightOTA_AirBookRQFulfillmentLCCUserLogin LCCUserLogin
        {
            get
            {
                return this.lCCUserLoginField;
            }
            set
            {
                this.lCCUserLoginField = value;
            }
        }
    }
}