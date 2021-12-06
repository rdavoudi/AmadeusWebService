namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehRateRuleRSLocationDetails : VehicleLocationDetailsType
    {

        private bool dropOffIndicatorField;

        private bool dropOffIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DropOffIndicator
        {
            get
            {
                return this.dropOffIndicatorField;
            }
            set
            {
                this.dropOffIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DropOffIndicatorSpecified
        {
            get
            {
                return this.dropOffIndicatorFieldSpecified;
            }
            set
            {
                this.dropOffIndicatorFieldSpecified = value;
            }
        }
    }
}