namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleChargeTypeMinMax
    {

        private decimal maxChargeField;

        private bool maxChargeFieldSpecified;

        private decimal minChargeField;

        private bool minChargeFieldSpecified;

        private string maxChargeDaysField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MaxCharge
        {
            get
            {
                return this.maxChargeField;
            }
            set
            {
                this.maxChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxChargeSpecified
        {
            get
            {
                return this.maxChargeFieldSpecified;
            }
            set
            {
                this.maxChargeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MinCharge
        {
            get
            {
                return this.minChargeField;
            }
            set
            {
                this.minChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinChargeSpecified
        {
            get
            {
                return this.minChargeFieldSpecified;
            }
            set
            {
                this.minChargeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaxChargeDays
        {
            get
            {
                return this.maxChargeDaysField;
            }
            set
            {
                this.maxChargeDaysField = value;
            }
        }
    }
}