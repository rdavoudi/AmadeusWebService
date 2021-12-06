namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PassengerFlyerCard : DBBaseEntity
    {

        private System.Nullable<System.Guid> passengerIDField;

        private string airlineCodeField;

        private string cardNameField;

        private TDESValue cardNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<System.Guid> PassengerID
        {
            get
            {
                return this.passengerIDField;
            }
            set
            {
                this.passengerIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string AirlineCode
        {
            get
            {
                return this.airlineCodeField;
            }
            set
            {
                this.airlineCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string CardName
        {
            get
            {
                return this.cardNameField;
            }
            set
            {
                this.cardNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TDESValue CardNumber
        {
            get
            {
                return this.cardNumberField;
            }
            set
            {
                this.cardNumberField = value;
            }
        }
    }
}