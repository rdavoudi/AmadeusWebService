namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ItemSearchCriterionTypeAddress : AddressType
    {

        private bool sameCountryIndField;

        private bool sameCountryIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SameCountryInd
        {
            get
            {
                return this.sameCountryIndField;
            }
            set
            {
                this.sameCountryIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SameCountryIndSpecified
        {
            get
            {
                return this.sameCountryIndFieldSpecified;
            }
            set
            {
                this.sameCountryIndFieldSpecified = value;
            }
        }
    }
}