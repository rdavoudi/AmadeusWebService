namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleChargePurposeType : VehicleChargeType
    {

        private string purposeField;

        private bool rateConvertIndField;

        private bool rateConvertIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Purpose
        {
            get
            {
                return this.purposeField;
            }
            set
            {
                this.purposeField = value;
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