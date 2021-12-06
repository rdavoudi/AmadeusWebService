namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetPNROTA_ReadRQReadRequestsReadRequest
    {

        private UniqueID_Type bookingReferenceIDField;

        private VerificationType verificationField;

        private bool historyRequestedIndField;

        private bool historyRequestedIndFieldSpecified;

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
        public VerificationType Verification
        {
            get
            {
                return this.verificationField;
            }
            set
            {
                this.verificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HistoryRequestedInd
        {
            get
            {
                return this.historyRequestedIndField;
            }
            set
            {
                this.historyRequestedIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HistoryRequestedIndSpecified
        {
            get
            {
                return this.historyRequestedIndFieldSpecified;
            }
            set
            {
                this.historyRequestedIndFieldSpecified = value;
            }
        }
    }
}