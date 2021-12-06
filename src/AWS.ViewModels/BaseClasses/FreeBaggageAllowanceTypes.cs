namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FreeBaggageAllowanceTypes
    {

        private int itineraryReferenceField;

        private int segmentReferenceField;

        private string passengerTypeField;

        private string unitField;

        private int quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ItineraryReference
        {
            get
            {
                return this.itineraryReferenceField;
            }
            set
            {
                this.itineraryReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int SegmentReference
        {
            get
            {
                return this.segmentReferenceField;
            }
            set
            {
                this.segmentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PassengerType
        {
            get
            {
                return this.passengerTypeField;
            }
            set
            {
                this.passengerTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }
}