namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfSpecialReqDetailsTypeSeatRequestSeatRequest : SeatRequestType
    {

        private string[] travelerRefNumberRPHListField;

        private string[] flightRefNumberRPHListField;

        private bool partialSeatingIndField;

        private bool partialSeatingIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] TravelerRefNumberRPHList
        {
            get
            {
                return this.travelerRefNumberRPHListField;
            }
            set
            {
                this.travelerRefNumberRPHListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] FlightRefNumberRPHList
        {
            get
            {
                return this.flightRefNumberRPHListField;
            }
            set
            {
                this.flightRefNumberRPHListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PartialSeatingInd
        {
            get
            {
                return this.partialSeatingIndField;
            }
            set
            {
                this.partialSeatingIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PartialSeatingIndSpecified
        {
            get
            {
                return this.partialSeatingIndFieldSpecified;
            }
            set
            {
                this.partialSeatingIndFieldSpecified = value;
            }
        }
    }
}