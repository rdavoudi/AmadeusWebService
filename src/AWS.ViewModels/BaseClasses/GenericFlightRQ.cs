namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FareFamilyInfoRQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_InsurancePlanSearchRQSearchFlightInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_AirSeatMapRQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_AirRulesRQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_AirCheckETicketRQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FlightOptionRQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceFeeInfoRQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PriceInfoRQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaggageInfoRQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AncillaryInfoRQ))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GenericFlightRQ
    {

        private int recommendationIDField;

        private int combinationIDField;

        private bool isOneWayCombinableField;

        private bool isOneWayCombinableFieldSpecified;

        private int fareFamilyPackageIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int RecommendationID
        {
            get
            {
                return this.recommendationIDField;
            }
            set
            {
                this.recommendationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int CombinationID
        {
            get
            {
                return this.combinationIDField;
            }
            set
            {
                this.combinationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsOneWayCombinable
        {
            get
            {
                return this.isOneWayCombinableField;
            }
            set
            {
                this.isOneWayCombinableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsOneWayCombinableSpecified
        {
            get
            {
                return this.isOneWayCombinableFieldSpecified;
            }
            set
            {
                this.isOneWayCombinableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int FareFamilyPackageID
        {
            get
            {
                return this.fareFamilyPackageIDField;
            }
            set
            {
                this.fareFamilyPackageIDField = value;
            }
        }
    }
}