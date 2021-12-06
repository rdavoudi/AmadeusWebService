namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetPNROTA_ReadRQReadRequestsVehicleReadRequest : VehicleRetrieveResRQCoreType
    {

        private VehicleRetrieveResRQAdditionalInfoType vehRetResRQInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public VehicleRetrieveResRQAdditionalInfoType VehRetResRQInfo
        {
            get
            {
                return this.vehRetResRQInfoField;
            }
            set
            {
                this.vehRetResRQInfoField = value;
            }
        }
    }
}