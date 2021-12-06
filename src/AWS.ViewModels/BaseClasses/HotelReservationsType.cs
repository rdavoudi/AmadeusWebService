namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class HotelReservationsType
    {

        private HotelReservationType[] hotelReservationField;

        private ArrayOfRoutingHopTypeRoutingHopRoutingHop[] routingHopsField;

        private WrittenConfInstType writtenConfInstField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HotelReservation", Order = 0)]
        public HotelReservationType[] HotelReservation
        {
            get
            {
                return this.hotelReservationField;
            }
            set
            {
                this.hotelReservationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public WrittenConfInstType WrittenConfInst
        {
            get
            {
                return this.writtenConfInstField;
            }
            set
            {
                this.writtenConfInstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }
    }
}