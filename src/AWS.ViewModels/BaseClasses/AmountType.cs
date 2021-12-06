namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AmountType
    {

        private TotalType baseField;

        private AmountTypeAdditionalGuestAmounts additionalGuestAmountsField;

        private FeeType[] feesField;

        private CancelPenaltiesType cancelPoliciesField;

        private ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePayment[] paymentPoliciesField;

        private AmountTypeDiscount[] discountField;

        private TotalType totalField;

        private ParagraphType rateDescriptionField;

        private AmountTypeAdditionalCharges additionalChargesField;

        private AmountTypeAdvanceBookingRestriction advanceBookingRestrictionField;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private System.DateTime expireDateField;

        private bool expireDateFieldSpecified;

        private string ageQualifyingCodeField;

        private string minAgeField;

        private string maxAgeField;

        private TimeUnitType ageTimeUnitField;

        private bool ageTimeUnitFieldSpecified;

        private bool guaranteedIndField;

        private bool guaranteedIndFieldSpecified;

        private string numberOfUnitsField;

        private TimeUnitType rateTimeUnitField;

        private bool rateTimeUnitFieldSpecified;

        private string unitMultiplierField;

        private string minGuestApplicableField;

        private string maxGuestApplicableField;

        private string minLOSField;

        private string maxLOSField;

        private DayOfWeekType stayOverDateField;

        private bool stayOverDateFieldSpecified;

        private bool alternateCurrencyIndField;

        private bool alternateCurrencyIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TotalType Base
        {
            get
            {
                return this.baseField;
            }
            set
            {
                this.baseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AmountTypeAdditionalGuestAmounts AdditionalGuestAmounts
        {
            get
            {
                return this.additionalGuestAmountsField;
            }
            set
            {
                this.additionalGuestAmountsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable = false)]
        public FeeType[] Fees
        {
            get
            {
                return this.feesField;
            }
            set
            {
                this.feesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CancelPenaltiesType CancelPolicies
        {
            get
            {
                return this.cancelPoliciesField;
            }
            set
            {
                this.cancelPoliciesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("GuaranteePayment", IsNullable = false)]
        public ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePayment[] PaymentPolicies
        {
            get
            {
                return this.paymentPoliciesField;
            }
            set
            {
                this.paymentPoliciesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Discount", Order = 5)]
        public AmountTypeDiscount[] Discount
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public TotalType Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public ParagraphType RateDescription
        {
            get
            {
                return this.rateDescriptionField;
            }
            set
            {
                this.rateDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public AmountTypeAdditionalCharges AdditionalCharges
        {
            get
            {
                return this.additionalChargesField;
            }
            set
            {
                this.additionalChargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public AmountTypeAdvanceBookingRestriction AdvanceBookingRestriction
        {
            get
            {
                return this.advanceBookingRestrictionField;
            }
            set
            {
                this.advanceBookingRestrictionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EffectiveDateSpecified
        {
            get
            {
                return this.effectiveDateFieldSpecified;
            }
            set
            {
                this.effectiveDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpireDateSpecified
        {
            get
            {
                return this.expireDateFieldSpecified;
            }
            set
            {
                this.expireDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgeQualifyingCode
        {
            get
            {
                return this.ageQualifyingCodeField;
            }
            set
            {
                this.ageQualifyingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MinAge
        {
            get
            {
                return this.minAgeField;
            }
            set
            {
                this.minAgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaxAge
        {
            get
            {
                return this.maxAgeField;
            }
            set
            {
                this.maxAgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeUnitType AgeTimeUnit
        {
            get
            {
                return this.ageTimeUnitField;
            }
            set
            {
                this.ageTimeUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgeTimeUnitSpecified
        {
            get
            {
                return this.ageTimeUnitFieldSpecified;
            }
            set
            {
                this.ageTimeUnitFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuaranteedInd
        {
            get
            {
                return this.guaranteedIndField;
            }
            set
            {
                this.guaranteedIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GuaranteedIndSpecified
        {
            get
            {
                return this.guaranteedIndFieldSpecified;
            }
            set
            {
                this.guaranteedIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string NumberOfUnits
        {
            get
            {
                return this.numberOfUnitsField;
            }
            set
            {
                this.numberOfUnitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeUnitType RateTimeUnit
        {
            get
            {
                return this.rateTimeUnitField;
            }
            set
            {
                this.rateTimeUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateTimeUnitSpecified
        {
            get
            {
                return this.rateTimeUnitFieldSpecified;
            }
            set
            {
                this.rateTimeUnitFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string UnitMultiplier
        {
            get
            {
                return this.unitMultiplierField;
            }
            set
            {
                this.unitMultiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string MinGuestApplicable
        {
            get
            {
                return this.minGuestApplicableField;
            }
            set
            {
                this.minGuestApplicableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string MaxGuestApplicable
        {
            get
            {
                return this.maxGuestApplicableField;
            }
            set
            {
                this.maxGuestApplicableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string MinLOS
        {
            get
            {
                return this.minLOSField;
            }
            set
            {
                this.minLOSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string MaxLOS
        {
            get
            {
                return this.maxLOSField;
            }
            set
            {
                this.maxLOSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DayOfWeekType StayOverDate
        {
            get
            {
                return this.stayOverDateField;
            }
            set
            {
                this.stayOverDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StayOverDateSpecified
        {
            get
            {
                return this.stayOverDateFieldSpecified;
            }
            set
            {
                this.stayOverDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AlternateCurrencyInd
        {
            get
            {
                return this.alternateCurrencyIndField;
            }
            set
            {
                this.alternateCurrencyIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AlternateCurrencyIndSpecified
        {
            get
            {
                return this.alternateCurrencyIndFieldSpecified;
            }
            set
            {
                this.alternateCurrencyIndFieldSpecified = value;
            }
        }
    }
}