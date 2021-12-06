namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RoomStayTypeRoomRatesRoomRate : RoomRateType
    {

        private RoomStayTypeRoomRatesRoomRateAdvanceBookingRestriction advanceBookingRestrictionField;

        private ArrayOfRoomStayTypeRoomRatesRoomRateRestrictionRestriction[] restrictionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public RoomStayTypeRoomRatesRoomRateAdvanceBookingRestriction AdvanceBookingRestriction
        {
            get
            {
                return this.advanceBookingRestrictionField;
            }
            set
            {
                this.advanceBookingRestrictionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Restriction", IsNullable = false)]
        public ArrayOfRoomStayTypeRoomRatesRoomRateRestrictionRestriction[] Restrictions
        {
            get
            {
                return this.restrictionsField;
            }
            set
            {
                this.restrictionsField = value;
            }
        }
    }
}