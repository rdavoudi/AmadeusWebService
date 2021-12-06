namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OtherServiceInfoType
    {

        private OtherServiceInfoTypeTravelerRefNumber[] travelerRefNumberField;

        private CompanyNameType airlineField;

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TravelerRefNumber", Order = 0)]
        public OtherServiceInfoTypeTravelerRefNumber[] TravelerRefNumber
        {
            get
            {
                return this.travelerRefNumberField;
            }
            set
            {
                this.travelerRefNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CompanyNameType Airline
        {
            get
            {
                return this.airlineField;
            }
            set
            {
                this.airlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
}