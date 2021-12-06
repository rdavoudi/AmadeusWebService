namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirlinePrefTypeFareRestrictPref
    {

        private string fareRestrictionField;

        private string dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareRestriction
        {
            get
            {
                return this.fareRestrictionField;
            }
            set
            {
                this.fareRestrictionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }
}