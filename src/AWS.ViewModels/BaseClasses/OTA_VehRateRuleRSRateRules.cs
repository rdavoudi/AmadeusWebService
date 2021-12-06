namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehRateRuleRSRateRules
    {

        private OTA_VehRateRuleRSRateRulesAdvanceBooking advanceBookingField;

        private OTA_VehRateRuleRSRateRulesPickupReturnRules pickupReturnRulesField;

        private OTA_VehRateRuleRSRateRulesRateGuarantee rateGuaranteeField;

        private OTA_VehRateRuleRSRateRulesPaymentRules paymentRulesField;

        private OTA_VehRateRuleRSRateRulesCancelPenaltyInfo[] cancelPenaltyInfoField;

        private OTA_VehRateRuleRSRateRulesRateDeposit rateDepositField;

        private string minimumKeepField;

        private string maximumKeepField;

        private string maximumRentalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_VehRateRuleRSRateRulesAdvanceBooking AdvanceBooking
        {
            get
            {
                return this.advanceBookingField;
            }
            set
            {
                this.advanceBookingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_VehRateRuleRSRateRulesPickupReturnRules PickupReturnRules
        {
            get
            {
                return this.pickupReturnRulesField;
            }
            set
            {
                this.pickupReturnRulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public OTA_VehRateRuleRSRateRulesRateGuarantee RateGuarantee
        {
            get
            {
                return this.rateGuaranteeField;
            }
            set
            {
                this.rateGuaranteeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public OTA_VehRateRuleRSRateRulesPaymentRules PaymentRules
        {
            get
            {
                return this.paymentRulesField;
            }
            set
            {
                this.paymentRulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CancelPenaltyInfo", Order = 4)]
        public OTA_VehRateRuleRSRateRulesCancelPenaltyInfo[] CancelPenaltyInfo
        {
            get
            {
                return this.cancelPenaltyInfoField;
            }
            set
            {
                this.cancelPenaltyInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public OTA_VehRateRuleRSRateRulesRateDeposit RateDeposit
        {
            get
            {
                return this.rateDepositField;
            }
            set
            {
                this.rateDepositField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public string MinimumKeep
        {
            get
            {
                return this.minimumKeepField;
            }
            set
            {
                this.minimumKeepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public string MaximumKeep
        {
            get
            {
                return this.maximumKeepField;
            }
            set
            {
                this.maximumKeepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public string MaximumRental
        {
            get
            {
                return this.maximumRentalField;
            }
            set
            {
                this.maximumRentalField = value;
            }
        }
    }
}