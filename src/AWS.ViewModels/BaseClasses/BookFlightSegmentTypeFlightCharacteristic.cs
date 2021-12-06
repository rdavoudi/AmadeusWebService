namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookFlightSegmentTypeFlightCharacteristic
    {

        private ArrayOfInFlightServiceInFlightSrv[] inFlightServicesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("inFlightSrv", IsNullable = false)]
        public ArrayOfInFlightServiceInFlightSrv[] InFlightServices
        {
            get
            {
                return this.inFlightServicesField;
            }
            set
            {
                this.inFlightServicesField = value;
            }
        }
    }
}