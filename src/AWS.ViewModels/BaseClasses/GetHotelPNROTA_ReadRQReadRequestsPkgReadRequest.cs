namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetHotelPNROTA_ReadRQReadRequestsPkgReadRequest
    {

        private PersonNameType nameField;

        private LocationType arrivalLocationField;

        private LocationType departureLocationField;

        private string travelCodeField;

        private string tourCodeField;

        private string packageIDField;

        private string startField;

        private string durationField;

        private string endField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PersonNameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public LocationType ArrivalLocation
        {
            get
            {
                return this.arrivalLocationField;
            }
            set
            {
                this.arrivalLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public LocationType DepartureLocation
        {
            get
            {
                return this.departureLocationField;
            }
            set
            {
                this.departureLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelCode
        {
            get
            {
                return this.travelCodeField;
            }
            set
            {
                this.travelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TourCode
        {
            get
            {
                return this.tourCodeField;
            }
            set
            {
                this.tourCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PackageID
        {
            get
            {
                return this.packageIDField;
            }
            set
            {
                this.packageIDField = value;
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