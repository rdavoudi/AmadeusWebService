namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleAvailCoreTypeTotalCharge
    {

        private decimal rateTotalAmountField;

        private bool rateTotalAmountFieldSpecified;

        private decimal estimatedTotalAmountField;

        private bool estimatedTotalAmountFieldSpecified;

        private bool rateConvertIndField;

        private bool rateConvertIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal RateTotalAmount
        {
            get
            {
                return this.rateTotalAmountField;
            }
            set
            {
                this.rateTotalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateTotalAmountSpecified
        {
            get
            {
                return this.rateTotalAmountFieldSpecified;
            }
            set
            {
                this.rateTotalAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal EstimatedTotalAmount
        {
            get
            {
                return this.estimatedTotalAmountField;
            }
            set
            {
                this.estimatedTotalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EstimatedTotalAmountSpecified
        {
            get
            {
                return this.estimatedTotalAmountFieldSpecified;
            }
            set
            {
                this.estimatedTotalAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RateConvertInd
        {
            get
            {
                return this.rateConvertIndField;
            }
            set
            {
                this.rateConvertIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateConvertIndSpecified
        {
            get
            {
                return this.rateConvertIndFieldSpecified;
            }
            set
            {
                this.rateConvertIndFieldSpecified = value;
            }
        }
    }
}