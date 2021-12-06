namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetHotelPNROTA_ReadRQReadRequestsCruiseReadRequest
    {

        private GetHotelPNROTA_ReadRQReadRequestsCruiseReadRequestSelectedSailing selectedSailingField;

        private PersonNameType guestInfoField;

        private bool historyRequestedIndField;

        private bool historyRequestedIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public GetHotelPNROTA_ReadRQReadRequestsCruiseReadRequestSelectedSailing SelectedSailing
        {
            get
            {
                return this.selectedSailingField;
            }
            set
            {
                this.selectedSailingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public PersonNameType GuestInfo
        {
            get
            {
                return this.guestInfoField;
            }
            set
            {
                this.guestInfoField = value;
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