namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AncillaryTicketFOPType
    {

        private string paymentTypeCodeField;

        private string paymentTypeField;

        private string vendorCodeField;

        private string cCNumberField;

        private string paymentDetailField;

        private string paymentAmountField;

        private string paymentCurrencyField;

        private string paymentAmountDetailField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string PaymentTypeCode
        {
            get
            {
                return this.paymentTypeCodeField;
            }
            set
            {
                this.paymentTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string PaymentType
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string VendorCode
        {
            get
            {
                return this.vendorCodeField;
            }
            set
            {
                this.vendorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string CCNumber
        {
            get
            {
                return this.cCNumberField;
            }
            set
            {
                this.cCNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string PaymentDetail
        {
            get
            {
                return this.paymentDetailField;
            }
            set
            {
                this.paymentDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string PaymentAmount
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string PaymentCurrency
        {
            get
            {
                return this.paymentCurrencyField;
            }
            set
            {
                this.paymentCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string PaymentAmountDetail
        {
            get
            {
                return this.paymentAmountDetailField;
            }
            set
            {
                this.paymentAmountDetailField = value;
            }
        }
    }
}