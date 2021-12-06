namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_InsurancePlanSearchRQSearchTripInfo
    {

        private string[] travelSectorField;

        private OTA_InsurancePlanSearchRQSearchTripInfoTotalTripCost totalTripCostField;

        private TimeDurationType maximumTripLengthField;

        private OTA_InsurancePlanSearchRQSearchTripInfoCoveredTrip[] coveredTripsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TravelSector", Order = 0)]
        public string[] TravelSector
        {
            get
            {
                return this.travelSectorField;
            }
            set
            {
                this.travelSectorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_InsurancePlanSearchRQSearchTripInfoTotalTripCost TotalTripCost
        {
            get
            {
                return this.totalTripCostField;
            }
            set
            {
                this.totalTripCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TimeDurationType MaximumTripLength
        {
            get
            {
                return this.maximumTripLengthField;
            }
            set
            {
                this.maximumTripLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CoveredTrip", IsNullable = false)]
        public OTA_InsurancePlanSearchRQSearchTripInfoCoveredTrip[] CoveredTrips
        {
            get
            {
                return this.coveredTripsField;
            }
            set
            {
                this.coveredTripsField = value;
            }
        }
    }
}