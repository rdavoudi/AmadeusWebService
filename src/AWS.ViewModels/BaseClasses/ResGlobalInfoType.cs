namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ResGlobalInfoType : ResCommonDetailType
    {

        private ArrayOfHotelReservationIDsTypeHotelReservationIDHotelReservationID[] hotelReservationIDsField;

        private ArrayOfRoutingHopTypeRoutingHopRoutingHop[] routingHopsField;

        private ArrayOfProfilesTypeProfileInfoProfileInfo[] profilesField;

        private ArrayOfBookingRulesTypeBookingRuleBookingRule[] bookingRulesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("HotelReservationID", IsNullable = false)]
        public ArrayOfHotelReservationIDsTypeHotelReservationIDHotelReservationID[] HotelReservationIDs
        {
            get
            {
                return this.hotelReservationIDsField;
            }
            set
            {
                this.hotelReservationIDsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RoutingHop", IsNullable = false)]
        public ArrayOfRoutingHopTypeRoutingHopRoutingHop[] RoutingHops
        {
            get
            {
                return this.routingHopsField;
            }
            set
            {
                this.routingHopsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileInfo", IsNullable = false)]
        public ArrayOfProfilesTypeProfileInfoProfileInfo[] Profiles
        {
            get
            {
                return this.profilesField;
            }
            set
            {
                this.profilesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("BookingRule", IsNullable = false)]
        public ArrayOfBookingRulesTypeBookingRuleBookingRule[] BookingRules
        {
            get
            {
                return this.bookingRulesField;
            }
            set
            {
                this.bookingRulesField = value;
            }
        }
    }
}