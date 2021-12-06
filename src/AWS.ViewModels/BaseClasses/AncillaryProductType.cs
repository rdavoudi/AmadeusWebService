namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AncillaryProductType : AncillaryProductTypeBase
    {

        private System.Nullable<decimal> amountField;

        private System.Nullable<decimal> pricedAmountField;

        private decimal pricedAmountInTicketCurrencyField;

        private System.Nullable<decimal> taxField;

        private string currencyField;

        private string confirmationNumberField;

        private AncillaryEticketInfoType eticketInfoField;

        private System.Nullable<int> ancillaryProductLineNumberField;

        private string airlineCodeField;

        private string uniqueReferenceField;

        private System.Nullable<int> pNRPassengerOrderIDField;

        private System.Nullable<int> pNRSegmentOrderIDField;

        private System.DateTime ticketTimeLimitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<decimal> Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<decimal> PricedAmount
        {
            get
            {
                return this.pricedAmountField;
            }
            set
            {
                this.pricedAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public decimal PricedAmountInTicketCurrency
        {
            get
            {
                return this.pricedAmountInTicketCurrencyField;
            }
            set
            {
                this.pricedAmountInTicketCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<decimal> Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string ConfirmationNumber
        {
            get
            {
                return this.confirmationNumberField;
            }
            set
            {
                this.confirmationNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public AncillaryEticketInfoType EticketInfo
        {
            get
            {
                return this.eticketInfoField;
            }
            set
            {
                this.eticketInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<int> AncillaryProductLineNumber
        {
            get
            {
                return this.ancillaryProductLineNumberField;
            }
            set
            {
                this.ancillaryProductLineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string AirlineCode
        {
            get
            {
                return this.airlineCodeField;
            }
            set
            {
                this.airlineCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string UniqueReference
        {
            get
            {
                return this.uniqueReferenceField;
            }
            set
            {
                this.uniqueReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<int> PNRPassengerOrderID
        {
            get
            {
                return this.pNRPassengerOrderIDField;
            }
            set
            {
                this.pNRPassengerOrderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<int> PNRSegmentOrderID
        {
            get
            {
                return this.pNRSegmentOrderIDField;
            }
            set
            {
                this.pNRSegmentOrderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime TicketTimeLimit
        {
            get
            {
                return this.ticketTimeLimitField;
            }
            set
            {
                this.ticketTimeLimitField = value;
            }
        }
    }
}