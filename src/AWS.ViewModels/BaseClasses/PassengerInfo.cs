namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PassengerInfo
    {

        private FrequentFlyerCardType[] frequentFlyerCardField;

        private string passengerTypeField;

        private int passengerIndexField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FrequentFlyerCard", Order = 0)]
        public FrequentFlyerCardType[] FrequentFlyerCard
        {
            get
            {
                return this.frequentFlyerCardField;
            }
            set
            {
                this.frequentFlyerCardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PassengerType
        {
            get
            {
                return this.passengerTypeField;
            }
            set
            {
                this.passengerTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int PassengerIndex
        {
            get
            {
                return this.passengerIndexField;
            }
            set
            {
                this.passengerIndexField = value;
            }
        }
    }
}