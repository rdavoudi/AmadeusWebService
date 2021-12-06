namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleLocationAdditionalDetailsTypeShuttleShuttleInfo : FormattedTextType
    {

        private LocationDetailShuttleInfoType typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LocationDetailShuttleInfoType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }
}