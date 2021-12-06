namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleReservationRQAdditionalInfoTypeRentalPaymentPref))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PaymentDetailType : PaymentFormType
    {

        private PaymentDetailTypePaymentAmount paymentAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PaymentDetailTypePaymentAmount PaymentAmount
        {
            get
            {
                return this.paymentAmountField;
            }
            set
            {
                this.paymentAmountField = value;
            }
        }
    }
}