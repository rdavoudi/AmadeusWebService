namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleCoreTypeVehType
    {

        private string vehicleCategoryField;

        private string doorCountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VehicleCategory
        {
            get
            {
                return this.vehicleCategoryField;
            }
            set
            {
                this.vehicleCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DoorCount
        {
            get
            {
                return this.doorCountField;
            }
            set
            {
                this.doorCountField = value;
            }
        }
    }
}