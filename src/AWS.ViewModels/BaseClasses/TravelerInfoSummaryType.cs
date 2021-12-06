namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class TravelerInfoSummaryType
    {

        private string[] seatsRequestedField;

        private TravelerInformationType[] airTravelerAvailField;

        private PriceRequestInformationType priceRequestInformationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SeatsRequested", DataType = "nonNegativeInteger", Order = 0)]
        public string[] SeatsRequested
        {
            get
            {
                return this.seatsRequestedField;
            }
            set
            {
                this.seatsRequestedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AirTravelerAvail", Order = 1)]
        public TravelerInformationType[] AirTravelerAvail
        {
            get
            {
                return this.airTravelerAvailField;
            }
            set
            {
                this.airTravelerAvailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public PriceRequestInformationType PriceRequestInformation
        {
            get
            {
                return this.priceRequestInformationField;
            }
            set
            {
                this.priceRequestInformationField = value;
            }
        }
    }
}