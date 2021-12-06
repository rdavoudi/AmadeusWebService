namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FareInfoTypeRuleInfo : RuleInfoType
    {

        private AirTripType tripTypeField;

        private bool tripTypeFieldSpecified;

        private bool moneySaverIndField;

        private bool moneySaverIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirTripType TripType
        {
            get
            {
                return this.tripTypeField;
            }
            set
            {
                this.tripTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TripTypeSpecified
        {
            get
            {
                return this.tripTypeFieldSpecified;
            }
            set
            {
                this.tripTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MoneySaverInd
        {
            get
            {
                return this.moneySaverIndField;
            }
            set
            {
                this.moneySaverIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MoneySaverIndSpecified
        {
            get
            {
                return this.moneySaverIndFieldSpecified;
            }
            set
            {
                this.moneySaverIndFieldSpecified = value;
            }
        }
    }
}