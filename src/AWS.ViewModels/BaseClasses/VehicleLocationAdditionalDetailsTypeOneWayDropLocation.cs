namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleLocationAdditionalDetailsTypeOneWayDropLocation : LocationType
    {

        private string extendedLocationCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExtendedLocationCode
        {
            get
            {
                return this.extendedLocationCodeField;
            }
            set
            {
                this.extendedLocationCodeField = value;
            }
        }
    }
}