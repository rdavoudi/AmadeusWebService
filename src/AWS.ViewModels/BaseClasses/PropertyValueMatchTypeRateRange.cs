namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PropertyValueMatchTypeRateRange
    {

        private decimal minRateField;

        private bool minRateFieldSpecified;

        private decimal maxRateField;

        private bool maxRateFieldSpecified;

        private decimal fixedRateField;

        private bool fixedRateFieldSpecified;

        private TimeUnitType rateTimeUnitField;

        private bool rateTimeUnitFieldSpecified;

        private string infoSourceField;

        private decimal taxRateField;

        private bool taxRateFieldSpecified;

        private bool rateInfoNotAvailableIndField;

        private bool rateInfoNotAvailableIndFieldSpecified;

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
        public string InfoSource
        {
            get
            {
                return this.infoSourceField;
            }
            set
            {
                this.infoSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TaxRate
        {
            get
            {
                return this.taxRateField;
            }
            set
            {
                this.taxRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxRateSpecified
        {
            get
            {
                return this.taxRateFieldSpecified;
            }
            set
            {
                this.taxRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RateInfoNotAvailableInd
        {
            get
            {
                return this.rateInfoNotAvailableIndField;
            }
            set
            {
                this.rateInfoNotAvailableIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateInfoNotAvailableIndSpecified
        {
            get
            {
                return this.rateInfoNotAvailableIndFieldSpecified;
            }
            set
            {
                this.rateInfoNotAvailableIndFieldSpecified = value;
            }
        }
    }
}