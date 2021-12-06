namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class IndCoverageReqsType
    {

        private IndCoverageReqsTypeIndTripCost indTripCostField;

        private IndCoverageReqsTypeFlightAccidentAmount flightAccidentAmountField;

        private IndCoverageReqsTypeLuggageItem[] coveredLuggageField;

        private IndCoverageReqsTypePreexistingCondition[] preexistingConditionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public IndCoverageReqsTypeIndTripCost IndTripCost
        {
            get
            {
                return this.indTripCostField;
            }
            set
            {
                this.indTripCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public IndCoverageReqsTypeFlightAccidentAmount FlightAccidentAmount
        {
            get
            {
                return this.flightAccidentAmountField;
            }
            set
            {
                this.flightAccidentAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("LuggageItem", IsNullable = false)]
        public IndCoverageReqsTypeLuggageItem[] CoveredLuggage
        {
            get
            {
                return this.coveredLuggageField;
            }
            set
            {
                this.coveredLuggageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PreexistingCondition", IsNullable = false)]
        public IndCoverageReqsTypePreexistingCondition[] PreexistingConditions
        {
            get
            {
                return this.preexistingConditionsField;
            }
            set
            {
                this.preexistingConditionsField = value;
            }
        }
    }
}