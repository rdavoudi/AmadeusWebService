namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarketingCabinType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CabinAvailabilityType
    {

        private CabinAvailabilityTypeMeal[] mealField;

        private CabinAvailabilityTypeBaggageAllowance baggageAllowanceField;

        private CabinType cabinTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Meal", Order = 0)]
        public CabinAvailabilityTypeMeal[] Meal
        {
            get
            {
                return this.mealField;
            }
            set
            {
                this.mealField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CabinAvailabilityTypeBaggageAllowance BaggageAllowance
        {
            get
            {
                return this.baggageAllowanceField;
            }
            set
            {
                this.baggageAllowanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CabinType CabinType
        {
            get
            {
                return this.cabinTypeField;
            }
            set
            {
                this.cabinTypeField = value;
            }
        }
    }
}