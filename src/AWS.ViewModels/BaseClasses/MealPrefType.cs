namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class MealPrefType
    {

        private PreferLevelType preferLevelField;

        private MealType mealTypeField;

        private bool mealTypeFieldSpecified;

        private string favoriteFoodField;

        private string beverageField;

        private string valueField;

        public MealPrefType()
        {
            this.preferLevelField = PreferLevelType.Preferred;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(PreferLevelType.Preferred)]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this.preferLevelField;
            }
            set
            {
                this.preferLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MealType MealType
        {
            get
            {
                return this.mealTypeField;
            }
            set
            {
                this.mealTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MealTypeSpecified
        {
            get
            {
                return this.mealTypeFieldSpecified;
            }
            set
            {
                this.mealTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FavoriteFood
        {
            get
            {
                return this.favoriteFoodField;
            }
            set
            {
                this.favoriteFoodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Beverage
        {
            get
            {
                return this.beverageField;
            }
            set
            {
                this.beverageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}