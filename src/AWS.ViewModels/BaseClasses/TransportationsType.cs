namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelativePositionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class TransportationsType
    {

        private ArrayOfTransportationTypeTransportationTransportation[] transportationsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Transportation", IsNullable = false)]
        public ArrayOfTransportationTypeTransportationTransportation[] Transportations
        {
            get
            {
                return this.transportationsField;
            }
            set
            {
                this.transportationsField = value;
            }
        }
    }
}