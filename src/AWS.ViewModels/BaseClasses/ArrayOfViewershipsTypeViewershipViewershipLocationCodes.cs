namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfViewershipsTypeViewershipViewershipLocationCodes
    {

        private ArrayOfViewershipsTypeViewershipViewershipLocationCodesLocationCode[] locationCodeField;

        private bool locationCodesInclusiveField;

        private bool locationCodesInclusiveFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LocationCode", Order = 0)]
        public ArrayOfViewershipsTypeViewershipViewershipLocationCodesLocationCode[] LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool LocationCodesInclusive
        {
            get
            {
                return this.locationCodesInclusiveField;
            }
            set
            {
                this.locationCodesInclusiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LocationCodesInclusiveSpecified
        {
            get
            {
                return this.locationCodesInclusiveFieldSpecified;
            }
            set
            {
                this.locationCodesInclusiveFieldSpecified = value;
            }
        }
    }
}