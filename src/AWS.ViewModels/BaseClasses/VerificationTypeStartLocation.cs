namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VerificationTypeStartLocation : LocationType
    {

        private System.DateTime associatedDateTimeField;

        private bool associatedDateTimeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime AssociatedDateTime
        {
            get
            {
                return this.associatedDateTimeField;
            }
            set
            {
                this.associatedDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AssociatedDateTimeSpecified
        {
            get
            {
                return this.associatedDateTimeFieldSpecified;
            }
            set
            {
                this.associatedDateTimeFieldSpecified = value;
            }
        }
    }
}