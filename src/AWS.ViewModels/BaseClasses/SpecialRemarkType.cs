namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SpecialRemarkType
    {

        private SpecialRemarkTypeTravelerRefNumber[] travelerRefNumberField;

        private SpecialRemarkTypeFlightRefNumber[] flightRefNumberField;

        private string textField;

        private CompanyNameType[] airlineField;

        private ArrayOfSpecialRemarkTypeAuthorizedViewerAuthorizedViewer[] authorizedViewersField;

        private string remarkTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TravelerRefNumber", Order = 0)]
        public SpecialRemarkTypeTravelerRefNumber[] TravelerRefNumber
        {
            get
            {
                return this.travelerRefNumberField;
            }
            set
            {
                this.travelerRefNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FlightRefNumber", Order = 1)]
        public SpecialRemarkTypeFlightRefNumber[] FlightRefNumber
        {
            get
            {
                return this.flightRefNumberField;
            }
            set
            {
                this.flightRefNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Airline", Order = 3)]
        public CompanyNameType[] Airline
        {
            get
            {
                return this.airlineField;
            }
            set
            {
                this.airlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AuthorizedViewer", IsNullable = false)]
        public ArrayOfSpecialRemarkTypeAuthorizedViewerAuthorizedViewer[] AuthorizedViewers
        {
            get
            {
                return this.authorizedViewersField;
            }
            set
            {
                this.authorizedViewersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RemarkType
        {
            get
            {
                return this.remarkTypeField;
            }
            set
            {
                this.remarkTypeField = value;
            }
        }
    }
}