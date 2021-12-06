namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehResRQVehResRQInfo : VehicleReservationRQAdditionalInfoType
    {

        private TransactionActionType resStatusField;

        private bool resStatusFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransactionActionType ResStatus
        {
            get
            {
                return this.resStatusField;
            }
            set
            {
                this.resStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResStatusSpecified
        {
            get
            {
                return this.resStatusFieldSpecified;
            }
            set
            {
                this.resStatusFieldSpecified = value;
            }
        }
    }
}