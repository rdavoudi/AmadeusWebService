namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class LengthsOfStayType
    {

        private LengthsOfStayTypeLengthOfStay[] lengthOfStayField;

        private bool arrivalDateBasedField;

        private bool arrivalDateBasedFieldSpecified;

        private string fixedPatternLengthField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LengthOfStay", Order = 0)]
        public LengthsOfStayTypeLengthOfStay[] LengthOfStay
        {
            get
            {
                return this.lengthOfStayField;
            }
            set
            {
                this.lengthOfStayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ArrivalDateBased
        {
            get
            {
                return this.arrivalDateBasedField;
            }
            set
            {
                this.arrivalDateBasedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArrivalDateBasedSpecified
        {
            get
            {
                return this.arrivalDateBasedFieldSpecified;
            }
            set
            {
                this.arrivalDateBasedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string FixedPatternLength
        {
            get
            {
                return this.fixedPatternLengthField;
            }
            set
            {
                this.fixedPatternLengthField = value;
            }
        }
    }
}