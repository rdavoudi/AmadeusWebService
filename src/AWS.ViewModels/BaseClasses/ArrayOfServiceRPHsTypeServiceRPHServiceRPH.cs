namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfServiceRPHsTypeServiceRPHServiceRPH
    {

        private string rPHField;

        private bool isPerRoomField;

        private bool isPerRoomFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsPerRoom
        {
            get
            {
                return this.isPerRoomField;
            }
            set
            {
                this.isPerRoomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsPerRoomSpecified
        {
            get
            {
                return this.isPerRoomFieldSpecified;
            }
            set
            {
                this.isPerRoomFieldSpecified = value;
            }
        }
    }
}