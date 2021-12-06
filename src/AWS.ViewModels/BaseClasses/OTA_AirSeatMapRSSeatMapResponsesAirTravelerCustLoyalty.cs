namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_AirSeatMapRSSeatMapResponsesAirTravelerCustLoyalty
    {

        private string programIDField;

        private string membershipIDField;

        private string travelSectorField;

        private string rPHField;

        private string[] vendorCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProgramID
        {
            get
            {
                return this.programIDField;
            }
            set
            {
                this.programIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MembershipID
        {
            get
            {
                return this.membershipIDField;
            }
            set
            {
                this.membershipIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelSector
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] VendorCode
        {
            get
            {
                return this.vendorCodeField;
            }
            set
            {
                this.vendorCodeField = value;
            }
        }
    }
}