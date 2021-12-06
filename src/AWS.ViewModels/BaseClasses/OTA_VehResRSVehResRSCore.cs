namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehResRSVehResRSCore : VehicleResRSCoreType
    {

        private string reservationStatusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReservationStatus
        {
            get
            {
                return this.reservationStatusField;
            }
            set
            {
                this.reservationStatusField = value;
            }
        }
    }
}