namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehRateRuleRSRateRulesAdvanceBooking
    {

        private string absoluteDeadlineField;

        private TimeUnitType offsetTimeUnitField;

        private bool offsetTimeUnitFieldSpecified;

        private string offsetUnitMultiplierField;

        private VehicleRentalRateTypeRateGuaranteeOffsetDropTime offsetDropTimeField;

        private bool offsetDropTimeFieldSpecified;

        private bool requiredIndField;

        private bool requiredIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AbsoluteDeadline
        {
            get
            {
                return this.absoluteDeadlineField;
            }
            set
            {
                this.absoluteDeadlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeUnitType OffsetTimeUnit
        {
            get
            {
                return this.offsetTimeUnitField;
            }
            set
            {
                this.offsetTimeUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OffsetTimeUnitSpecified
        {
            get
            {
                return this.offsetTimeUnitFieldSpecified;
            }
            set
            {
                this.offsetTimeUnitFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string OffsetUnitMultiplier
        {
            get
            {
                return this.offsetUnitMultiplierField;
            }
            set
            {
                this.offsetUnitMultiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleRentalRateTypeRateGuaranteeOffsetDropTime OffsetDropTime
        {
            get
            {
                return this.offsetDropTimeField;
            }
            set
            {
                this.offsetDropTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OffsetDropTimeSpecified
        {
            get
            {
                return this.offsetDropTimeFieldSpecified;
            }
            set
            {
                this.offsetDropTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RequiredInd
        {
            get
            {
                return this.requiredIndField;
            }
            set
            {
                this.requiredIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequiredIndSpecified
        {
            get
            {
                return this.requiredIndFieldSpecified;
            }
            set
            {
                this.requiredIndFieldSpecified = value;
            }
        }
    }
}