namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfViewershipsTypeViewershipViewershipSystemCodes
    {

        private ArrayOfViewershipsTypeViewershipViewershipSystemCodesSystemCode[] systemCodeField;

        private bool systemCodesInclusiveField;

        private bool systemCodesInclusiveFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SystemCode", Order = 0)]
        public ArrayOfViewershipsTypeViewershipViewershipSystemCodesSystemCode[] SystemCode
        {
            get
            {
                return this.systemCodeField;
            }
            set
            {
                this.systemCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SystemCodesInclusive
        {
            get
            {
                return this.systemCodesInclusiveField;
            }
            set
            {
                this.systemCodesInclusiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SystemCodesInclusiveSpecified
        {
            get
            {
                return this.systemCodesInclusiveFieldSpecified;
            }
            set
            {
                this.systemCodesInclusiveFieldSpecified = value;
            }
        }
    }
}