namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleLocationAdditionalDetailsTypeShuttle
    {

        private VehicleLocationAdditionalDetailsTypeShuttleShuttleInfo[] shuttleInfosField;

        private OperationSchedulesType operationSchedulesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ShuttleInfo", IsNullable = false)]
        public VehicleLocationAdditionalDetailsTypeShuttleShuttleInfo[] ShuttleInfos
        {
            get
            {
                return this.shuttleInfosField;
            }
            set
            {
                this.shuttleInfosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OperationSchedulesType OperationSchedules
        {
            get
            {
                return this.operationSchedulesField;
            }
            set
            {
                this.operationSchedulesField = value;
            }
        }
    }
}