namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FlightSegmentTypeMarketingAirline : CompanyNameType
    {

        private FlightSegmentTypeMarketingAirlineSingleVendorInd singleVendorIndField;

        private bool singleVendorIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FlightSegmentTypeMarketingAirlineSingleVendorInd SingleVendorInd
        {
            get
            {
                return this.singleVendorIndField;
            }
            set
            {
                this.singleVendorIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SingleVendorIndSpecified
        {
            get
            {
                return this.singleVendorIndFieldSpecified;
            }
            set
            {
                this.singleVendorIndFieldSpecified = value;
            }
        }
    }
}