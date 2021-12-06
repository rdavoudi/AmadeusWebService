namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleAvailCoreTypeReference : UniqueID_Type
    {

        private System.DateTime dateTimeField;

        private bool dateTimeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateTimeSpecified
        {
            get
            {
                return this.dateTimeFieldSpecified;
            }
            set
            {
                this.dateTimeFieldSpecified = value;
            }
        }
    }
}