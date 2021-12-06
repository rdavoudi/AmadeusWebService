namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PTCFareBreakdownTypePricingUnitFareComponent
    {

        private PTCFareBreakdownTypePricingUnitFareComponentFlightLeg[] flightLegField;

        private string numberField;

        private decimal amountField;

        private bool amountFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FlightLeg", Order = 0)]
        public PTCFareBreakdownTypePricingUnitFareComponentFlightLeg[] FlightLeg
        {
            get
            {
                return this.flightLegField;
            }
            set
            {
                this.flightLegField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified
        {
            get
            {
                return this.amountFieldSpecified;
            }
            set
            {
                this.amountFieldSpecified = value;
            }
        }
    }
}