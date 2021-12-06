namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class TravelerInfoType
    {

        private TravelerInfoTypeAirTraveler[] airTravelerField;

        private SpecialReqDetailsType[] specialReqDetailsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AirTraveler", Order = 0)]
        public TravelerInfoTypeAirTraveler[] AirTraveler
        {
            get
            {
                return this.airTravelerField;
            }
            set
            {
                this.airTravelerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialReqDetails", Order = 1)]
        public SpecialReqDetailsType[] SpecialReqDetails
        {
            get
            {
                return this.specialReqDetailsField;
            }
            set
            {
                this.specialReqDetailsField = value;
            }
        }
    }
}