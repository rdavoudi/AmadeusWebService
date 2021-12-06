namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AncillaryTicketCouponType
    {

        private string cpnNumberField;

        private string issuanceSubCodeField;

        private string operatingAirlineField;

        private string originDestinationField;

        private string statusCodeField;

        private string statusField;

        private string connectionWithEticketNumberField;

        private string connectionWithEticketTypeField;

        private string connectionWithEticketField;

        private string couponAmountField;

        private string couponCurrencyField;

        private string couponValueField;

        private AncillaryTicketCouponDetailType couponDetailField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string CpnNumber
        {
            get
            {
                return this.cpnNumberField;
            }
            set
            {
                this.cpnNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string IssuanceSubCode
        {
            get
            {
                return this.issuanceSubCodeField;
            }
            set
            {
                this.issuanceSubCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string OperatingAirline
        {
            get
            {
                return this.operatingAirlineField;
            }
            set
            {
                this.operatingAirlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string OriginDestination
        {
            get
            {
                return this.originDestinationField;
            }
            set
            {
                this.originDestinationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string StatusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string ConnectionWithEticketNumber
        {
            get
            {
                return this.connectionWithEticketNumberField;
            }
            set
            {
                this.connectionWithEticketNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string ConnectionWithEticketType
        {
            get
            {
                return this.connectionWithEticketTypeField;
            }
            set
            {
                this.connectionWithEticketTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string ConnectionWithEticket
        {
            get
            {
                return this.connectionWithEticketField;
            }
            set
            {
                this.connectionWithEticketField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string CouponAmount
        {
            get
            {
                return this.couponAmountField;
            }
            set
            {
                this.couponAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string CouponCurrency
        {
            get
            {
                return this.couponCurrencyField;
            }
            set
            {
                this.couponCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string CouponValue
        {
            get
            {
                return this.couponValueField;
            }
            set
            {
                this.couponValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public AncillaryTicketCouponDetailType CouponDetail
        {
            get
            {
                return this.couponDetailField;
            }
            set
            {
                this.couponDetailField = value;
            }
        }
    }
}