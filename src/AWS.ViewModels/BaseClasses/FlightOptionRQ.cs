namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FlightOptionRQ : GenericFlightRQ
    {

        private int directionIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int DirectionId
        {
            get
            {
                return this.directionIdField;
            }
            set
            {
                this.directionIdField = value;
            }
        }
    }
}