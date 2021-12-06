namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CommissionType
    {

        private UniqueID_Type uniqueIDField;

        private CommissionTypeCommissionableAmount commissionableAmountField;

        private CommissionTypePrepaidAmount prepaidAmountField;

        private CommissionTypeFlatCommission flatCommissionField;

        private CommissionTypeCommissionPayableAmount commissionPayableAmountField;

        private ParagraphType commentField;

        private CommissionTypeStatusType statusTypeField;

        private bool statusTypeFieldSpecified;

        private decimal percentField;

        private bool percentFieldSpecified;

        private string currencyCodeField;

        private string decimalPlacesField;

        private string reasonCodeField;

        private string billToIDField;

        private string frequencyField;

        private string maxCommissionUnitAppliesField;

        private decimal capAmountField;

        private bool capAmountFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public UniqueID_Type UniqueID
        {
            get
            {
                return this.uniqueIDField;
            }
            set
            {
                this.uniqueIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CommissionTypeCommissionableAmount CommissionableAmount
        {
            get
            {
                return this.commissionableAmountField;
            }
            set
            {
                this.commissionableAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CommissionTypePrepaidAmount PrepaidAmount
        {
            get
            {
                return this.prepaidAmountField;
            }
            set
            {
                this.prepaidAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CommissionTypeFlatCommission FlatCommission
        {
            get
            {
                return this.flatCommissionField;
            }
            set
            {
                this.flatCommissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public CommissionTypeCommissionPayableAmount CommissionPayableAmount
        {
            get
            {
                return this.commissionPayableAmountField;
            }
            set
            {
                this.commissionPayableAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public ParagraphType Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CommissionTypeStatusType StatusType
        {
            get
            {
                return this.statusTypeField;
            }
            set
            {
                this.statusTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusTypeSpecified
        {
            get
            {
                return this.statusTypeFieldSpecified;
            }
            set
            {
                this.statusTypeFieldSpecified = value;
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
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReasonCode
        {
            get
            {
                return this.reasonCodeField;
            }
            set
            {
                this.reasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BillToID
        {
            get
            {
                return this.billToIDField;
            }
            set
            {
                this.billToIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Frequency
        {
            get
            {
                return this.frequencyField;
            }
            set
            {
                this.frequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string MaxCommissionUnitApplies
        {
            get
            {
                return this.maxCommissionUnitAppliesField;
            }
            set
            {
                this.maxCommissionUnitAppliesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal CapAmount
        {
            get
            {
                return this.capAmountField;
            }
            set
            {
                this.capAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CapAmountSpecified
        {
            get
            {
                return this.capAmountFieldSpecified;
            }
            set
            {
                this.capAmountFieldSpecified = value;
            }
        }
    }
}