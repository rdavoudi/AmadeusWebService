namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirlinePrefTypeCabinPref
    {

        private CabinType cabinField;

        private bool cabinFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CabinType Cabin
        {
            get
            {
                return this.cabinField;
            }
            set
            {
                this.cabinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CabinSpecified
        {
            get
            {
                return this.cabinFieldSpecified;
            }
            set
            {
                this.cabinFieldSpecified = value;
            }
        }
    }
}