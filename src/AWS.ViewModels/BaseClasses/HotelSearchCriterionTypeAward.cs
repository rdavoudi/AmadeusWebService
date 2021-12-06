namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class HotelSearchCriterionTypeAward
    {

        private string providerField;

        private string ratingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Provider
        {
            get
            {
                return this.providerField;
            }
            set
            {
                this.providerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rating
        {
            get
            {
                return this.ratingField;
            }
            set
            {
                this.ratingField = value;
            }
        }
    }
}