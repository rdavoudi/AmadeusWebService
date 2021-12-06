namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfOTA_HotelAvailRSHotelStaysHotelStayOTA_HotelAvailRSHotelStaysHotelStayAvailability
    {

        private ArrayOfOTA_HotelAvailRSHotelStaysHotelStayOTA_HotelAvailRSHotelStaysHotelStayAvailabilityRestriction[] restrictionField;

        private AvailabilityStatusType statusField;

        private string startField;

        private string durationField;

        private string endField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Restriction", Order = 0)]
        public ArrayOfOTA_HotelAvailRSHotelStaysHotelStayOTA_HotelAvailRSHotelStaysHotelStayAvailabilityRestriction[] Restriction
        {
            get
            {
                return this.restrictionField;
            }
            set
            {
                this.restrictionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AvailabilityStatusType Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
    }
}