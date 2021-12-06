namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_AirSeatMapRQSeatMapRequestSeatDetailsCabinClass
    {

        private CabinType cabinTypeField;

        private bool cabinTypeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CabinType CabinType
        {
            get
            {
                return this.cabinTypeField;
            }
            set
            {
                this.cabinTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CabinTypeSpecified
        {
            get
            {
                return this.cabinTypeFieldSpecified;
            }
            set
            {
                this.cabinTypeFieldSpecified = value;
            }
        }
    }
}