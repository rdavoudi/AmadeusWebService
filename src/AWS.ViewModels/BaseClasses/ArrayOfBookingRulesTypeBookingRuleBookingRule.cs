namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfBookingRulesTypeBookingRuleBookingRule
    {

        private ArrayOfBookingRulesTypeBookingRuleAcceptableGuaranteeAcceptableGuarantee[] acceptableGuaranteesField;

        private CancelPenaltiesType cancelPenaltiesField;

        private ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePayment[] requiredPaymtsField;

        private LengthsOfStayType lengthsOfStayField;

        private DOW_RestrictionsType dOW_RestrictionsField;

        private ArrayOfBookingRulesTypeBookingRuleBookingRuleRestrictionStatus restrictionStatusField;

        private ArrayOfViewershipsTypeViewershipViewership[] viewershipsField;

        private ArrayOfBookingRulesTypeBookingRuleAdditionalRuleAdditionalRule[] addtionalRulesField;

        private ParagraphType[] descriptionField;

        private UniqueID_Type uniqueIDField;

        private ArrayOfBookingRulesTypeBookingRuleBookingRuleCheckoutCharge[] checkoutChargeField;

        private string uRIField;

        private string startField;

        private string durationField;

        private string endField;

        private string maxAdvancedBookingOffsetField;

        private string minAdvancedBookingOffsetField;

        private string forceGuaranteeOffsetField;

        private string depositWaiverOffsetField;

        private string minTotalOccupancyField;

        private string maxTotalOccupancyField;

        private string absoluteDropTimeField;

        private bool generallyBookableField;

        private bool generallyBookableFieldSpecified;

        private bool priceViewableField;

        private bool priceViewableFieldSpecified;

        private bool qualifiedRateYNField;

        private bool qualifiedRateYNFieldSpecified;

        private bool addressRequiredField;

        private bool addressRequiredFieldSpecified;

        private string absoluteCutoffField;

        private string offsetDurationField;

        private ArrayOfBookingRulesTypeBookingRuleBookingRuleOffsetCalculationMode offsetCalculationModeField;

        private bool offsetCalculationModeFieldSpecified;

        private string maxContiguousBookingsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AcceptableGuarantee", IsNullable = false)]
        public ArrayOfBookingRulesTypeBookingRuleAcceptableGuaranteeAcceptableGuarantee[] AcceptableGuarantees
        {
            get
            {
                return this.acceptableGuaranteesField;
            }
            set
            {
                this.acceptableGuaranteesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CancelPenaltiesType CancelPenalties
        {
            get
            {
                return this.cancelPenaltiesField;
            }
            set
            {
                this.cancelPenaltiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("GuaranteePayment", IsNullable = false)]
        public ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePayment[] RequiredPaymts
        {
            get
            {
                return this.requiredPaymtsField;
            }
            set
            {
                this.requiredPaymtsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public LengthsOfStayType LengthsOfStay
        {
            get
            {
                return this.lengthsOfStayField;
            }
            set
            {
                this.lengthsOfStayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public DOW_RestrictionsType DOW_Restrictions
        {
            get
            {
                return this.dOW_RestrictionsField;
            }
            set
            {
                this.dOW_RestrictionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public ArrayOfBookingRulesTypeBookingRuleBookingRuleRestrictionStatus RestrictionStatus
        {
            get
            {
                return this.restrictionStatusField;
            }
            set
            {
                this.restrictionStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 6)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Viewership", IsNullable = false)]
        public ArrayOfViewershipsTypeViewershipViewership[] Viewerships
        {
            get
            {
                return this.viewershipsField;
            }
            set
            {
                this.viewershipsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AdditionalRule", IsNullable = false)]
        public ArrayOfBookingRulesTypeBookingRuleAdditionalRuleAdditionalRule[] AddtionalRules
        {
            get
            {
                return this.addtionalRulesField;
            }
            set
            {
                this.addtionalRulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Order = 8)]
        public ParagraphType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
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
        [System.Xml.Serialization.XmlElementAttribute("CheckoutCharge", Order = 10)]
        public ArrayOfBookingRulesTypeBookingRuleBookingRuleCheckoutCharge[] CheckoutCharge
        {
            get
            {
                return this.checkoutChargeField;
            }
            set
            {
                this.checkoutChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public string MaxAdvancedBookingOffset
        {
            get
            {
                return this.maxAdvancedBookingOffsetField;
            }
            set
            {
                this.maxAdvancedBookingOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public string MinAdvancedBookingOffset
        {
            get
            {
                return this.minAdvancedBookingOffsetField;
            }
            set
            {
                this.minAdvancedBookingOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public string ForceGuaranteeOffset
        {
            get
            {
                return this.forceGuaranteeOffsetField;
            }
            set
            {
                this.forceGuaranteeOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public string DepositWaiverOffset
        {
            get
            {
                return this.depositWaiverOffsetField;
            }
            set
            {
                this.depositWaiverOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string MinTotalOccupancy
        {
            get
            {
                return this.minTotalOccupancyField;
            }
            set
            {
                this.minTotalOccupancyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string MaxTotalOccupancy
        {
            get
            {
                return this.maxTotalOccupancyField;
            }
            set
            {
                this.maxTotalOccupancyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AbsoluteDropTime
        {
            get
            {
                return this.absoluteDropTimeField;
            }
            set
            {
                this.absoluteDropTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GenerallyBookable
        {
            get
            {
                return this.generallyBookableField;
            }
            set
            {
                this.generallyBookableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GenerallyBookableSpecified
        {
            get
            {
                return this.generallyBookableFieldSpecified;
            }
            set
            {
                this.generallyBookableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PriceViewable
        {
            get
            {
                return this.priceViewableField;
            }
            set
            {
                this.priceViewableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceViewableSpecified
        {
            get
            {
                return this.priceViewableFieldSpecified;
            }
            set
            {
                this.priceViewableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool QualifiedRateYN
        {
            get
            {
                return this.qualifiedRateYNField;
            }
            set
            {
                this.qualifiedRateYNField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QualifiedRateYNSpecified
        {
            get
            {
                return this.qualifiedRateYNFieldSpecified;
            }
            set
            {
                this.qualifiedRateYNFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AddressRequired
        {
            get
            {
                return this.addressRequiredField;
            }
            set
            {
                this.addressRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddressRequiredSpecified
        {
            get
            {
                return this.addressRequiredFieldSpecified;
            }
            set
            {
                this.addressRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AbsoluteCutoff
        {
            get
            {
                return this.absoluteCutoffField;
            }
            set
            {
                this.absoluteCutoffField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public string OffsetDuration
        {
            get
            {
                return this.offsetDurationField;
            }
            set
            {
                this.offsetDurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ArrayOfBookingRulesTypeBookingRuleBookingRuleOffsetCalculationMode OffsetCalculationMode
        {
            get
            {
                return this.offsetCalculationModeField;
            }
            set
            {
                this.offsetCalculationModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OffsetCalculationModeSpecified
        {
            get
            {
                return this.offsetCalculationModeFieldSpecified;
            }
            set
            {
                this.offsetCalculationModeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string MaxContiguousBookings
        {
            get
            {
                return this.maxContiguousBookingsField;
            }
            set
            {
                this.maxContiguousBookingsField = value;
            }
        }
    }
}