namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RoomRateTypeAvailability
    {

        private RateIndicatorType availabilityStatusField;

        private bool availabilityStatusFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RateIndicatorType AvailabilityStatus
        {
            get
            {
                return this.availabilityStatusField;
            }
            set
            {
                this.availabilityStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AvailabilityStatusSpecified
        {
            get
            {
                return this.availabilityStatusFieldSpecified;
            }
            set
            {
                this.availabilityStatusFieldSpecified = value;
            }
        }
    }
}