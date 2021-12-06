namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehResRQVehResRQCore : VehicleReservationRQCoreType
    {

        private bool optionChangeIndicatorField;

        private bool optionChangeIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OptionChangeIndicator
        {
            get
            {
                return this.optionChangeIndicatorField;
            }
            set
            {
                this.optionChangeIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OptionChangeIndicatorSpecified
        {
            get
            {
                return this.optionChangeIndicatorFieldSpecified;
            }
            set
            {
                this.optionChangeIndicatorFieldSpecified = value;
            }
        }
    }
}