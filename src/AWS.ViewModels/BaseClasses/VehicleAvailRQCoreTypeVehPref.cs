namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleAvailRQCoreTypeVehPref : VehiclePrefType
    {

        private bool upSellIndField;

        private bool upSellIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool UpSellInd
        {
            get
            {
                return this.upSellIndField;
            }
            set
            {
                this.upSellIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpSellIndSpecified
        {
            get
            {
                return this.upSellIndFieldSpecified;
            }
            set
            {
                this.upSellIndFieldSpecified = value;
            }
        }
    }
}