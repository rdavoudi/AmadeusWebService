namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RatePlanType
    {

        private GuaranteeType[] guaranteeField;

        private CancelPenaltiesType cancelPenaltiesField;

        private ParagraphType ratePlanDescriptionField;

        private RatePlanTypeRatePlanInclusion[] ratePlanInclusionField;

        private CommissionType commissionField;

        private RatePlanTypeMealsIncluded mealsIncludedField;

        private RatePlanTypeRestrictionStatus restrictionStatusField;

        private AdditionalDetailType[] additionalDetailsField;

        private string bookingCodeField;

        private string ratePlanCodeField;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private System.DateTime expireDateField;

        private bool expireDateFieldSpecified;

        private RateIndicatorType rateIndicatorField;

        private bool rateIndicatorFieldSpecified;

        private string ratePlanType1Field;

        private string ratePlanIDField;

        private string ratePlanNameField;

        private string marketCodeField;

        private RateIndicatorType availabilityStatusField;

        private bool availabilityStatusFieldSpecified;

        private bool iD_RequiredIndField;

        private bool iD_RequiredIndFieldSpecified;

        private bool priceViewableIndField;

        private bool priceViewableIndFieldSpecified;

        private string qualificationTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Guarantee", Order = 0)]
        public GuaranteeType[] Guarantee
        {
            get
            {
                return this.guaranteeField;
            }
            set
            {
                this.guaranteeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ParagraphType RatePlanDescription
        {
            get
            {
                return this.ratePlanDescriptionField;
            }
            set
            {
                this.ratePlanDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RatePlanInclusion", Order = 3)]
        public RatePlanTypeRatePlanInclusion[] RatePlanInclusion
        {
            get
            {
                return this.ratePlanInclusionField;
            }
            set
            {
                this.ratePlanInclusionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public CommissionType Commission
        {
            get
            {
                return this.commissionField;
            }
            set
            {
                this.commissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public RatePlanTypeMealsIncluded MealsIncluded
        {
            get
            {
                return this.mealsIncludedField;
            }
            set
            {
                this.mealsIncludedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public RatePlanTypeRestrictionStatus RestrictionStatus
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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AdditionalDetail", IsNullable = false)]
        public AdditionalDetailType[] AdditionalDetails
        {
            get
            {
                return this.additionalDetailsField;
            }
            set
            {
                this.additionalDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BookingCode
        {
            get
            {
                return this.bookingCodeField;
            }
            set
            {
                this.bookingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanCode
        {
            get
            {
                return this.ratePlanCodeField;
            }
            set
            {
                this.ratePlanCodeField = value;
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
        public RateIndicatorType RateIndicator
        {
            get
            {
                return this.rateIndicatorField;
            }
            set
            {
                this.rateIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateIndicatorSpecified
        {
            get
            {
                return this.rateIndicatorFieldSpecified;
            }
            set
            {
                this.rateIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("RatePlanType")]
        public string RatePlanType1
        {
            get
            {
                return this.ratePlanType1Field;
            }
            set
            {
                this.ratePlanType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanID
        {
            get
            {
                return this.ratePlanIDField;
            }
            set
            {
                this.ratePlanIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanName
        {
            get
            {
                return this.ratePlanNameField;
            }
            set
            {
                this.ratePlanNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MarketCode
        {
            get
            {
                return this.marketCodeField;
            }
            set
            {
                this.marketCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RateIndicatorType AvailabilityStatus
        {
            get
            {
                return this.availabilityStatusField;
            }
            set
            {
                this.availabilityStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AvailabilityStatusSpecified
        {
            get
            {
                return this.availabilityStatusFieldSpecified;
            }
            set
            {
                this.availabilityStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ID_RequiredInd
        {
            get
            {
                return this.iD_RequiredIndField;
            }
            set
            {
                this.iD_RequiredIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ID_RequiredIndSpecified
        {
            get
            {
                return this.iD_RequiredIndFieldSpecified;
            }
            set
            {
                this.iD_RequiredIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PriceViewableInd
        {
            get
            {
                return this.priceViewableIndField;
            }
            set
            {
                this.priceViewableIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceViewableIndSpecified
        {
            get
            {
                return this.priceViewableIndFieldSpecified;
            }
            set
            {
                this.priceViewableIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string QualificationType
        {
            get
            {
                return this.qualificationTypeField;
            }
            set
            {
                this.qualificationTypeField = value;
            }
        }
    }
}