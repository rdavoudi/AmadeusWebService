namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfRatePlanCandidatesTypeRatePlanCandidateRatePlanCandidate
    {

        private ArrayOfRatePlanCandidatesTypeRatePlanCandidateHotelRefHotelRef[] hotelRefsField;

        private ArrayOfRatePlanCandidatesTypeRatePlanCandidateRatePlanCandidateMealsIncluded mealsIncludedField;

        private string ratePlanTypeField;

        private string ratePlanCodeField;

        private string ratePlanIDField;

        private bool ratePlanQualifierField;

        private bool ratePlanQualifierFieldSpecified;

        private string ratePlanCategoryField;

        private string rPHField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("HotelRef", IsNullable = false)]
        public ArrayOfRatePlanCandidatesTypeRatePlanCandidateHotelRefHotelRef[] HotelRefs
        {
            get
            {
                return this.hotelRefsField;
            }
            set
            {
                this.hotelRefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ArrayOfRatePlanCandidatesTypeRatePlanCandidateRatePlanCandidateMealsIncluded MealsIncluded
        {
            get
            {
                return this.mealsIncludedField;
            }
            set
            {
                this.mealsIncludedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanType
        {
            get
            {
                return this.ratePlanTypeField;
            }
            set
            {
                this.ratePlanTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanCode
        {
            get
            {
                return this.ratePlanCodeField;
            }
            set
            {
                this.ratePlanCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanID
        {
            get
            {
                return this.ratePlanIDField;
            }
            set
            {
                this.ratePlanIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RatePlanQualifier
        {
            get
            {
                return this.ratePlanQualifierField;
            }
            set
            {
                this.ratePlanQualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RatePlanQualifierSpecified
        {
            get
            {
                return this.ratePlanQualifierFieldSpecified;
            }
            set
            {
                this.ratePlanQualifierFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RatePlanCategory
        {
            get
            {
                return this.ratePlanCategoryField;
            }
            set
            {
                this.ratePlanCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }
    }
}