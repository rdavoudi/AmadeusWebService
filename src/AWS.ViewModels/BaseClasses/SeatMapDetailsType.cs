namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SeatMapDetailsType
    {

        private CabinClassType[] cabinClassField;

        private string[] travelerRefNumberRPHsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CabinClass", Order = 0)]
        public CabinClassType[] CabinClass
        {
            get
            {
                return this.cabinClassField;
            }
            set
            {
                this.cabinClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] TravelerRefNumberRPHs
        {
            get
            {
                return this.travelerRefNumberRPHsField;
            }
            set
            {
                this.travelerRefNumberRPHsField = value;
            }
        }
    }
}