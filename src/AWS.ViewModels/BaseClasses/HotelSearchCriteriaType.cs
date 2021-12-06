namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class HotelSearchCriteriaType
    {

        private HotelSearchCriteriaTypeCriterion[] criterionField;

        private bool availableOnlyIndicatorField;

        private bool availableOnlyIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Criterion", Order = 0)]
        public HotelSearchCriteriaTypeCriterion[] Criterion
        {
            get
            {
                return this.criterionField;
            }
            set
            {
                this.criterionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AvailableOnlyIndicator
        {
            get
            {
                return this.availableOnlyIndicatorField;
            }
            set
            {
                this.availableOnlyIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AvailableOnlyIndicatorSpecified
        {
            get
            {
                return this.availableOnlyIndicatorFieldSpecified;
            }
            set
            {
                this.availableOnlyIndicatorFieldSpecified = value;
            }
        }
    }
}