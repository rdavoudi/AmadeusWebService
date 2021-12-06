namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehRateRuleRSRateRulesCancelPenaltyInfo
    {

        private OTA_VehRateRuleRSRateRulesCancelPenaltyInfoDeadline[] deadlineField;

        private OTA_VehRateRuleRSRateRulesCancelPenaltyInfoPenaltyFee penaltyFeeField;

        private FormattedTextTextType descriptionField;

        private bool guaranteeRequiredIndField;

        private bool guaranteeRequiredIndFieldSpecified;

        private bool modifyPenaltyIndField;

        private bool modifyPenaltyIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Deadline", Order = 0)]
        public OTA_VehRateRuleRSRateRulesCancelPenaltyInfoDeadline[] Deadline
        {
            get
            {
                return this.deadlineField;
            }
            set
            {
                this.deadlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_VehRateRuleRSRateRulesCancelPenaltyInfoPenaltyFee PenaltyFee
        {
            get
            {
                return this.penaltyFeeField;
            }
            set
            {
                this.penaltyFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public FormattedTextTextType Description
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuaranteeRequiredInd
        {
            get
            {
                return this.guaranteeRequiredIndField;
            }
            set
            {
                this.guaranteeRequiredIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GuaranteeRequiredIndSpecified
        {
            get
            {
                return this.guaranteeRequiredIndFieldSpecified;
            }
            set
            {
                this.guaranteeRequiredIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ModifyPenaltyInd
        {
            get
            {
                return this.modifyPenaltyIndField;
            }
            set
            {
                this.modifyPenaltyIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifyPenaltyIndSpecified
        {
            get
            {
                return this.modifyPenaltyIndFieldSpecified;
            }
            set
            {
                this.modifyPenaltyIndFieldSpecified = value;
            }
        }
    }
}