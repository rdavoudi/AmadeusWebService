namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleReservationTypeVehSegmentCore : VehicleSegmentCoreType
    {

        private bool optionChangeAllowedIndicatorField;

        private bool optionChangeAllowedIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OptionChangeAllowedIndicator
        {
            get
            {
                return this.optionChangeAllowedIndicatorField;
            }
            set
            {
                this.optionChangeAllowedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OptionChangeAllowedIndicatorSpecified
        {
            get
            {
                return this.optionChangeAllowedIndicatorFieldSpecified;
            }
            set
            {
                this.optionChangeAllowedIndicatorFieldSpecified = value;
            }
        }
    }
}