namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CorporateSetting
    {

        private string flightProviderTypeField;

        private RailProviderTypeEnum railProviderTypeField;

        private HotelProviderTypeEnum hotelProviderTypeField;

        private CarProviderTypeEnum carProviderTypeField;

        private DisplayRuleEnum displayRuleField;

        private TripApprovalRuleEnum tripApprovalRuleField;

        private bool requireJustificationRuleField;

        private bool requireJustificationOnlyFlightRuleField;

        private bool requireJusificationForDeclineProcessField;

        private string applyApprovalRulesField;

        private System.Nullable<bool> allowBookingOnlyArrangerOrSelectedMembersField;

        private System.Nullable<int> allowETicketForNextField;

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
        public DisplayRuleEnum DisplayRule
        {
            get
            {
                return this.displayRuleField;
            }
            set
            {
                this.displayRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TripApprovalRuleEnum TripApprovalRule
        {
            get
            {
                return this.tripApprovalRuleField;
            }
            set
            {
                this.tripApprovalRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public bool RequireJustificationRule
        {
            get
            {
                return this.requireJustificationRuleField;
            }
            set
            {
                this.requireJustificationRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public bool RequireJustificationOnlyFlightRule
        {
            get
            {
                return this.requireJustificationOnlyFlightRuleField;
            }
            set
            {
                this.requireJustificationOnlyFlightRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public bool RequireJusificationForDeclineProcess
        {
            get
            {
                return this.requireJusificationForDeclineProcessField;
            }
            set
            {
                this.requireJusificationForDeclineProcessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string ApplyApprovalRules
        {
            get
            {
                return this.applyApprovalRulesField;
            }
            set
            {
                this.applyApprovalRulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<bool> AllowBookingOnlyArrangerOrSelectedMembers
        {
            get
            {
                return this.allowBookingOnlyArrangerOrSelectedMembersField;
            }
            set
            {
                this.allowBookingOnlyArrangerOrSelectedMembersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<int> AllowETicketForNext
        {
            get
            {
                return this.allowETicketForNextField;
            }
            set
            {
                this.allowETicketForNextField = value;
            }
        }
    }
}