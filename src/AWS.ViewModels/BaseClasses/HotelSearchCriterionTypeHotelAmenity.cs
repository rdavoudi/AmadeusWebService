namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class HotelSearchCriterionTypeHotelAmenity
    {

        private string codeField;

        private bool complimentaryIndField;

        private bool complimentaryIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ComplimentaryInd
        {
            get
            {
                return this.complimentaryIndField;
            }
            set
            {
                this.complimentaryIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ComplimentaryIndSpecified
        {
            get
            {
                return this.complimentaryIndFieldSpecified;
            }
            set
            {
                this.complimentaryIndFieldSpecified = value;
            }
        }
    }
}