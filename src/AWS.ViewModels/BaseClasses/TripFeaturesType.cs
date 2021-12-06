namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsCoverageDetailTypeCoveredTrip))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_InsurancePlanSearchRQSearchTripInfoCoveredTrip))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class TripFeaturesType
    {

        private TripFeaturesTypeDestination[] destinationsField;

        private string[] activitiesField;

        private CompanyNameType[] operatorsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Destination", IsNullable = false)]
        public TripFeaturesTypeDestination[] Destinations
        {
            get
            {
                return this.destinationsField;
            }
            set
            {
                this.destinationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Activity", IsNullable = false)]
        public string[] Activities
        {
            get
            {
                return this.activitiesField;
            }
            set
            {
                this.activitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Operator", IsNullable = false)]
        public CompanyNameType[] Operators
        {
            get
            {
                return this.operatorsField;
            }
            set
            {
                this.operatorsField = value;
            }
        }
    }
}