namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PassengerDetails : BaseEntity
    {

        private PassengerFlyerCard[] flyerCardsField;

        private PassengerSpecialRequest[] specialRequestsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public PassengerFlyerCard[] FlyerCards
        {
            get
            {
                return this.flyerCardsField;
            }
            set
            {
                this.flyerCardsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        public PassengerSpecialRequest[] SpecialRequests
        {
            get
            {
                return this.specialRequestsField;
            }
            set
            {
                this.specialRequestsField = value;
            }
        }
    }
}