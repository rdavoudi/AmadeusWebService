namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OriginDestinationCombinationType
    {

        private string validatingAirlineCodeField;

        private bool forceETicketField;

        private int originIndexField;

        private bool originIndexFieldSpecified;

        private string indexListField;

        private int destinationIndexField;

        private bool destinationIndexFieldSpecified;

        private int combinationIDField;

        private int recommendationIDField;

        private bool recommendationIDFieldSpecified;

        private OriginDestinationCombinationTypeE_TicketEligibility e_TicketEligibilityField;

        private bool e_TicketEligibilityFieldSpecified;

        private decimal serviceFeeAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ValidatingAirlineCode
        {
            get
            {
                return this.validatingAirlineCodeField;
            }
            set
            {
                this.validatingAirlineCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ForceETicket
        {
            get
            {
                return this.forceETicketField;
            }
            set
            {
                this.forceETicketField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int OriginIndex
        {
            get
            {
                return this.originIndexField;
            }
            set
            {
                this.originIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OriginIndexSpecified
        {
            get
            {
                return this.originIndexFieldSpecified;
            }
            set
            {
                this.originIndexFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IndexList
        {
            get
            {
                return this.indexListField;
            }
            set
            {
                this.indexListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int DestinationIndex
        {
            get
            {
                return this.destinationIndexField;
            }
            set
            {
                this.destinationIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DestinationIndexSpecified
        {
            get
            {
                return this.destinationIndexFieldSpecified;
            }
            set
            {
                this.destinationIndexFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int CombinationID
        {
            get
            {
                return this.combinationIDField;
            }
            set
            {
                this.combinationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int RecommendationID
        {
            get
            {
                return this.recommendationIDField;
            }
            set
            {
                this.recommendationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecommendationIDSpecified
        {
            get
            {
                return this.recommendationIDFieldSpecified;
            }
            set
            {
                this.recommendationIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OriginDestinationCombinationTypeE_TicketEligibility E_TicketEligibility
        {
            get
            {
                return this.e_TicketEligibilityField;
            }
            set
            {
                this.e_TicketEligibilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool E_TicketEligibilitySpecified
        {
            get
            {
                return this.e_TicketEligibilityFieldSpecified;
            }
            set
            {
                this.e_TicketEligibilityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ServiceFeeAmount
        {
            get
            {
                return this.serviceFeeAmountField;
            }
            set
            {
                this.serviceFeeAmountField = value;
            }
        }
    }
}