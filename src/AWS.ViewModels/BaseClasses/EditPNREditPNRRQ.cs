namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class EditPNREditPNRRQ
    {

        private UniqueID_Type bookingReferenceIDField;

        private string surNameField;

        private string agentSignatureField;

        private PassengerDetailChanges passengerDetailChangesField;

        private PNRRemarkChange[] pNRRemarkChangesField;

        private OSIElementChange[] oSIElementChangesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public UniqueID_Type BookingReferenceID
        {
            get
            {
                return this.bookingReferenceIDField;
            }
            set
            {
                this.bookingReferenceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string SurName
        {
            get
            {
                return this.surNameField;
            }
            set
            {
                this.surNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string AgentSignature
        {
            get
            {
                return this.agentSignatureField;
            }
            set
            {
                this.agentSignatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public PassengerDetailChanges PassengerDetailChanges
        {
            get
            {
                return this.passengerDetailChangesField;
            }
            set
            {
                this.passengerDetailChangesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        public PNRRemarkChange[] PNRRemarkChanges
        {
            get
            {
                return this.pNRRemarkChangesField;
            }
            set
            {
                this.pNRRemarkChangesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        public OSIElementChange[] OSIElementChanges
        {
            get
            {
                return this.oSIElementChangesField;
            }
            set
            {
                this.oSIElementChangesField = value;
            }
        }
    }
}