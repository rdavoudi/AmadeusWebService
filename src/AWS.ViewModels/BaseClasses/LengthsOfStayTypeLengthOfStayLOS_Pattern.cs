namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class LengthsOfStayTypeLengthOfStayLOS_Pattern
    {

        private string fullPatternLOSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FullPatternLOS
        {
            get
            {
                return this.fullPatternLOSField;
            }
            set
            {
                this.fullPatternLOSField = value;
            }
        }
    }
}