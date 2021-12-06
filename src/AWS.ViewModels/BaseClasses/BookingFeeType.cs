namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HotelExtraFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CarExtraFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsuranceExtraFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeliveryFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AirlineOBFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AncillaryFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CCOBFeeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherExtraCostType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CouponFeeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookingFeeType : ServiceFeeType
    {

        private decimal discountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Discount
        {
            get
            {
                return this.discountField;
            }
            set
            {
                this.discountField = value;
            }
        }
    }
}