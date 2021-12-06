namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class EditPNRResponseEditPnrRS
    {

        private EditPNRResponseEditPnrRSAirReservation airReservationField;

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public EditPNRResponseEditPnrRSAirReservation AirReservation
        {
            get
            {
                return this.airReservationField;
            }
            set
            {
                this.airReservationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Errors", typeof(ErrorsType), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("Success", typeof(SuccessType), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("Warnings", typeof(WarningsType), Order = 1)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
}