namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleVendorAvailabilityTypeVehAvails
    {

        private VehicleVendorAvailabilityTypeVehAvailsVehAvail[] vehAvailField;

        private string rateCategoryField;

        private RateQualifierTypeRatePeriod ratePeriodField;

        private bool ratePeriodFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VehAvail", Order = 0)]
        public VehicleVendorAvailabilityTypeVehAvailsVehAvail[] VehAvail
        {
            get
            {
                return this.vehAvailField;
            }
            set
            {
                this.vehAvailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateCategory
        {
            get
            {
                return this.rateCategoryField;
            }
            set
            {
                this.rateCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RateQualifierTypeRatePeriod RatePeriod
        {
            get
            {
                return this.ratePeriodField;
            }
            set
            {
                this.ratePeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RatePeriodSpecified
        {
            get
            {
                return this.ratePeriodFieldSpecified;
            }
            set
            {
                this.ratePeriodFieldSpecified = value;
            }
        }
    }
}