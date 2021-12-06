namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CreateTicketOTA_AirBookRQPriceInfoPricingPref
    {

        private CreateTicketOTA_AirBookRQPriceInfoPricingPrefType typeField;

        private bool excludeIndField;

        private bool excludeIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CreateTicketOTA_AirBookRQPriceInfoPricingPrefType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExcludeInd
        {
            get
            {
                return this.excludeIndField;
            }
            set
            {
                this.excludeIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExcludeIndSpecified
        {
            get
            {
                return this.excludeIndFieldSpecified;
            }
            set
            {
                this.excludeIndFieldSpecified = value;
            }
        }
    }
}