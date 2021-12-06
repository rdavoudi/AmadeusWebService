namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_AirScheduleRSOriginDestinationOptions
    {

        private OTA_AirScheduleRSOriginDestinationOptionsOriginDestinationOption[] originDestinationOptionField;

        private string originCodeField;

        private string destinationCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OriginDestinationOption", Order = 0)]
        public OTA_AirScheduleRSOriginDestinationOptionsOriginDestinationOption[] OriginDestinationOption
        {
            get
            {
                return this.originDestinationOptionField;
            }
            set
            {
                this.originDestinationOptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginCode
        {
            get
            {
                return this.originCodeField;
            }
            set
            {
                this.originCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DestinationCode
        {
            get
            {
                return this.destinationCodeField;
            }
            set
            {
                this.destinationCodeField = value;
            }
        }
    }
}