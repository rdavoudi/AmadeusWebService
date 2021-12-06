namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfBookingRulesTypeBookingRuleBookingRuleCheckoutCharge
    {

        private decimal amountField;

        private bool amountFieldSpecified;

        private decimal percentField;

        private bool percentFieldSpecified;

        private ArrayOfBookingRulesTypeBookingRuleBookingRuleCheckoutChargeType typeField;

        private bool typeFieldSpecified;

        private string codeDetailField;

        private string nmbrOfNightsField;

        private string existsCodeField;

        private bool balanceOfStayIndField;

        private bool balanceOfStayIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified
        {
            get
            {
                return this.amountFieldSpecified;
            }
            set
            {
                this.amountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentSpecified
        {
            get
            {
                return this.percentFieldSpecified;
            }
            set
            {
                this.percentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ArrayOfBookingRulesTypeBookingRuleBookingRuleCheckoutChargeType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeDetail
        {
            get
            {
                return this.codeDetailField;
            }
            set
            {
                this.codeDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string NmbrOfNights
        {
            get
            {
                return this.nmbrOfNightsField;
            }
            set
            {
                this.nmbrOfNightsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExistsCode
        {
            get
            {
                return this.existsCodeField;
            }
            set
            {
                this.existsCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BalanceOfStayInd
        {
            get
            {
                return this.balanceOfStayIndField;
            }
            set
            {
                this.balanceOfStayIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BalanceOfStayIndSpecified
        {
            get
            {
                return this.balanceOfStayIndFieldSpecified;
            }
            set
            {
                this.balanceOfStayIndFieldSpecified = value;
            }
        }
    }
}