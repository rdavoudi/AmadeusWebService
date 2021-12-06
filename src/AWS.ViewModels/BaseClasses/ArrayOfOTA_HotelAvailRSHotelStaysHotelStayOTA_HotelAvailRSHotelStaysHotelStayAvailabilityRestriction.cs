namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfOTA_HotelAvailRSHotelStaysHotelStayOTA_HotelAvailRSHotelStaysHotelStayAvailabilityRestriction
    {

        private ArrayOfOTA_HotelAvailRSHotelStaysHotelStayOTA_HotelAvailRSHotelStaysHotelStayAvailabilityRestrictionRestrictionType restrictionTypeField;

        private bool restrictionTypeFieldSpecified;

        private string timeField;

        private TimeUnitType timeUnitField;

        private bool timeUnitFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ArrayOfOTA_HotelAvailRSHotelStaysHotelStayOTA_HotelAvailRSHotelStaysHotelStayAvailabilityRestrictionRestrictionType RestrictionType
        {
            get
            {
                return this.restrictionTypeField;
            }
            set
            {
                this.restrictionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RestrictionTypeSpecified
        {
            get
            {
                return this.restrictionTypeFieldSpecified;
            }
            set
            {
                this.restrictionTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeUnitType TimeUnit
        {
            get
            {
                return this.timeUnitField;
            }
            set
            {
                this.timeUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeUnitSpecified
        {
            get
            {
                return this.timeUnitFieldSpecified;
            }
            set
            {
                this.timeUnitFieldSpecified = value;
            }
        }
    }
}