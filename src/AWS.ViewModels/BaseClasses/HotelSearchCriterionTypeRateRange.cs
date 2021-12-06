namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class HotelSearchCriterionTypeRateRange
    {

        private string roomStayCandidateRPHField;

        private decimal minRateField;

        private bool minRateFieldSpecified;

        private decimal maxRateField;

        private bool maxRateFieldSpecified;

        private decimal fixedRateField;

        private bool fixedRateFieldSpecified;

        private TimeUnitType rateTimeUnitField;

        private bool rateTimeUnitFieldSpecified;

        private string rateModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomStayCandidateRPH
        {
            get
            {
                return this.roomStayCandidateRPHField;
            }
            set
            {
                this.roomStayCandidateRPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MinRate
        {
            get
            {
                return this.minRateField;
            }
            set
            {
                this.minRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinRateSpecified
        {
            get
            {
                return this.minRateFieldSpecified;
            }
            set
            {
                this.minRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MaxRate
        {
            get
            {
                return this.maxRateField;
            }
            set
            {
                this.maxRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxRateSpecified
        {
            get
            {
                return this.maxRateFieldSpecified;
            }
            set
            {
                this.maxRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal FixedRate
        {
            get
            {
                return this.fixedRateField;
            }
            set
            {
                this.fixedRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FixedRateSpecified
        {
            get
            {
                return this.fixedRateFieldSpecified;
            }
            set
            {
                this.fixedRateFieldSpecified = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateMode
        {
            get
            {
                return this.rateModeField;
            }
            set
            {
                this.rateModeField = value;
            }
        }
    }
}