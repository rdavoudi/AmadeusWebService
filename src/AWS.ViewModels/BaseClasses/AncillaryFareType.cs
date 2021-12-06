namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AncillaryFareType
    {

        private decimal amountField;

        private decimal taxField;

        private string currencyField;

        private string itineraryReferenceField;

        private string segmentReferenceField;

        private string segmentInfoField;

        private string passengerTypeField;

        private int xMLPassengerIDField;

        private string descriptionField;

        private AncillaryServiceFeeType[] serviceFeesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public decimal Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string ItineraryReference
        {
            get
            {
                return this.itineraryReferenceField;
            }
            set
            {
                this.itineraryReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string SegmentReference
        {
            get
            {
                return this.segmentReferenceField;
            }
            set
            {
                this.segmentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string SegmentInfo
        {
            get
            {
                return this.segmentInfoField;
            }
            set
            {
                this.segmentInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string PassengerType
        {
            get
            {
                return this.passengerTypeField;
            }
            set
            {
                this.passengerTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public int XMLPassengerID
        {
            get
            {
                return this.xMLPassengerIDField;
            }
            set
            {
                this.xMLPassengerIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 9)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ServiceFee", IsNullable = false)]
        public AncillaryServiceFeeType[] ServiceFees
        {
            get
            {
                return this.serviceFeesField;
            }
            set
            {
                this.serviceFeesField = value;
            }
        }
    }
}