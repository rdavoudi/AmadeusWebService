namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AddressTypeStreetNmbr : StreetNmbrType
    {

        private string streetNmbrSuffixField;

        private string streetDirectionField;

        private string ruralRouteNmbrField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StreetNmbrSuffix
        {
            get
            {
                return this.streetNmbrSuffixField;
            }
            set
            {
                this.streetNmbrSuffixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StreetDirection
        {
            get
            {
                return this.streetDirectionField;
            }
            set
            {
                this.streetDirectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RuralRouteNmbr
        {
            get
            {
                return this.ruralRouteNmbrField;
            }
            set
            {
                this.ruralRouteNmbrField = value;
            }
        }
    }
}