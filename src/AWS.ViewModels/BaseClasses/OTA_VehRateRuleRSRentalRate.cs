namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehRateRuleRSRentalRate : VehicleRentalRateType
    {

        private bool writtenConfIndField;

        private bool writtenConfIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool WrittenConfInd
        {
            get
            {
                return this.writtenConfIndField;
            }
            set
            {
                this.writtenConfIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WrittenConfIndSpecified
        {
            get
            {
                return this.writtenConfIndFieldSpecified;
            }
            set
            {
                this.writtenConfIndFieldSpecified = value;
            }
        }
    }
}