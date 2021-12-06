namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CancelOTA_CancelRQSegment
    {

        private string itinSegNbrField;

        private string firstItinSegNbrField;

        private string lastItinSegNbrField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string ItinSegNbr
        {
            get
            {
                return this.itinSegNbrField;
            }
            set
            {
                this.itinSegNbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string FirstItinSegNbr
        {
            get
            {
                return this.firstItinSegNbrField;
            }
            set
            {
                this.firstItinSegNbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string LastItinSegNbr
        {
            get
            {
                return this.lastItinSegNbrField;
            }
            set
            {
                this.lastItinSegNbrField = value;
            }
        }
    }
}