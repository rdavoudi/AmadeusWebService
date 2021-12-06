namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehLocSearchRSVehMatchedLocs
    {

        private VehicleMatchedLocationType[] vehMatchedLocField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VehMatchedLoc", Order = 0)]
        public VehicleMatchedLocationType[] VehMatchedLoc
        {
            get
            {
                return this.vehMatchedLocField;
            }
            set
            {
                this.vehMatchedLocField = value;
            }
        }
    }
}