namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BrandCodeType
    {

        private string outBoundField;

        private string inBoundField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OutBound
        {
            get
            {
                return this.outBoundField;
            }
            set
            {
                this.outBoundField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InBound
        {
            get
            {
                return this.inBoundField;
            }
            set
            {
                this.inBoundField = value;
            }
        }
    }
}