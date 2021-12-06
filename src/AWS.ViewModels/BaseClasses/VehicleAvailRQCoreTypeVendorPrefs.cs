namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleAvailRQCoreTypeVendorPrefs
    {

        private VehicleAvailRQCoreTypeVendorPrefsVendorPref[] vendorPrefField;

        private string participationLevelCodeField;

        private string locationCategoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VendorPref", Order = 0)]
        public VehicleAvailRQCoreTypeVendorPrefsVendorPref[] VendorPref
        {
            get
            {
                return this.vendorPrefField;
            }
            set
            {
                this.vendorPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParticipationLevelCode
        {
            get
            {
                return this.participationLevelCodeField;
            }
            set
            {
                this.participationLevelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCategory
        {
            get
            {
                return this.locationCategoryField;
            }
            set
            {
                this.locationCategoryField = value;
            }
        }
    }
}