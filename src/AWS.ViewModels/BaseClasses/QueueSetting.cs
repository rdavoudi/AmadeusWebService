namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class QueueSetting
    {

        private string flightProviderTypeField;

        private RailProviderTypeEnum railProviderTypeField;

        private HotelProviderTypeEnum hotelProviderTypeField;

        private CarProviderTypeEnum carProviderTypeField;

        private QueSetting defaultQueField;

        private QueSetting cancellationQueField;

        private QueSetting pendingApprovalField;

        private QueSetting approvedApprovalField;

        private QueSetting declinedApprovalField;

        private QueSetting ticketedQueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string FlightProviderType
        {
            get
            {
                return this.flightProviderTypeField;
            }
            set
            {
                this.flightProviderTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public RailProviderTypeEnum RailProviderType
        {
            get
            {
                return this.railProviderTypeField;
            }
            set
            {
                this.railProviderTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public HotelProviderTypeEnum HotelProviderType
        {
            get
            {
                return this.hotelProviderTypeField;
            }
            set
            {
                this.hotelProviderTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CarProviderTypeEnum CarProviderType
        {
            get
            {
                return this.carProviderTypeField;
            }
            set
            {
                this.carProviderTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public QueSetting DefaultQue
        {
            get
            {
                return this.defaultQueField;
            }
            set
            {
                this.defaultQueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public QueSetting CancellationQue
        {
            get
            {
                return this.cancellationQueField;
            }
            set
            {
                this.cancellationQueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public QueSetting PendingApproval
        {
            get
            {
                return this.pendingApprovalField;
            }
            set
            {
                this.pendingApprovalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public QueSetting ApprovedApproval
        {
            get
            {
                return this.approvedApprovalField;
            }
            set
            {
                this.approvedApprovalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public QueSetting DeclinedApproval
        {
            get
            {
                return this.declinedApprovalField;
            }
            set
            {
                this.declinedApprovalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public QueSetting TicketedQue
        {
            get
            {
                return this.ticketedQueField;
            }
            set
            {
                this.ticketedQueField = value;
            }
        }
    }
}