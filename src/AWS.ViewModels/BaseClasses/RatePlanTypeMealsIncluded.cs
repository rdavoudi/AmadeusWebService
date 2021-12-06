namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RatePlanTypeMealsIncluded
    {

        private bool breakfastField;

        private bool breakfastFieldSpecified;

        private bool lunchField;

        private bool lunchFieldSpecified;

        private bool dinnerField;

        private bool dinnerFieldSpecified;

        private bool mealPlanIndicatorField;

        private bool mealPlanIndicatorFieldSpecified;

        private string[] mealPlanCodesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Breakfast
        {
            get
            {
                return this.breakfastField;
            }
            set
            {
                this.breakfastField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BreakfastSpecified
        {
            get
            {
                return this.breakfastFieldSpecified;
            }
            set
            {
                this.breakfastFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Lunch
        {
            get
            {
                return this.lunchField;
            }
            set
            {
                this.lunchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LunchSpecified
        {
            get
            {
                return this.lunchFieldSpecified;
            }
            set
            {
                this.lunchFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Dinner
        {
            get
            {
                return this.dinnerField;
            }
            set
            {
                this.dinnerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DinnerSpecified
        {
            get
            {
                return this.dinnerFieldSpecified;
            }
            set
            {
                this.dinnerFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MealPlanIndicator
        {
            get
            {
                return this.mealPlanIndicatorField;
            }
            set
            {
                this.mealPlanIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MealPlanIndicatorSpecified
        {
            get
            {
                return this.mealPlanIndicatorFieldSpecified;
            }
            set
            {
                this.mealPlanIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] MealPlanCodes
        {
            get
            {
                return this.mealPlanCodesField;
            }
            set
            {
                this.mealPlanCodesField = value;
            }
        }
    }
}