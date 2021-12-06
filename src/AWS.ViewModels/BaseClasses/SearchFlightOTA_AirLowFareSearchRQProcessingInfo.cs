namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SearchFlightOTA_AirLowFareSearchRQProcessingInfo
    {

        private SearchFlightOTA_AirLowFareSearchRQProcessingInfoTargetSource targetSourceField;

        private bool targetSourceFieldSpecified;

        private bool flightSvcInfoIndicatorField;

        private bool flightSvcInfoIndicatorFieldSpecified;

        private DisplayOrderType displayOrderField;

        private bool displayOrderFieldSpecified;

        private bool reducedDataIndicatorField;

        private bool reducedDataIndicatorFieldSpecified;

        private bool baseFaresOnlyIndicatorField;

        private bool baseFaresOnlyIndicatorFieldSpecified;

        private SearchFlightOTA_AirLowFareSearchRQProcessingInfoSearchType searchTypeField;

        private bool searchTypeFieldSpecified;

        private bool availabilityIndicatorField;

        private bool availabilityIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SearchFlightOTA_AirLowFareSearchRQProcessingInfoTargetSource TargetSource
        {
            get
            {
                return this.targetSourceField;
            }
            set
            {
                this.targetSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TargetSourceSpecified
        {
            get
            {
                return this.targetSourceFieldSpecified;
            }
            set
            {
                this.targetSourceFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FlightSvcInfoIndicator
        {
            get
            {
                return this.flightSvcInfoIndicatorField;
            }
            set
            {
                this.flightSvcInfoIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FlightSvcInfoIndicatorSpecified
        {
            get
            {
                return this.flightSvcInfoIndicatorFieldSpecified;
            }
            set
            {
                this.flightSvcInfoIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DisplayOrderType DisplayOrder
        {
            get
            {
                return this.displayOrderField;
            }
            set
            {
                this.displayOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisplayOrderSpecified
        {
            get
            {
                return this.displayOrderFieldSpecified;
            }
            set
            {
                this.displayOrderFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReducedDataIndicator
        {
            get
            {
                return this.reducedDataIndicatorField;
            }
            set
            {
                this.reducedDataIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReducedDataIndicatorSpecified
        {
            get
            {
                return this.reducedDataIndicatorFieldSpecified;
            }
            set
            {
                this.reducedDataIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BaseFaresOnlyIndicator
        {
            get
            {
                return this.baseFaresOnlyIndicatorField;
            }
            set
            {
                this.baseFaresOnlyIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BaseFaresOnlyIndicatorSpecified
        {
            get
            {
                return this.baseFaresOnlyIndicatorFieldSpecified;
            }
            set
            {
                this.baseFaresOnlyIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SearchFlightOTA_AirLowFareSearchRQProcessingInfoSearchType SearchType
        {
            get
            {
                return this.searchTypeField;
            }
            set
            {
                this.searchTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SearchTypeSpecified
        {
            get
            {
                return this.searchTypeFieldSpecified;
            }
            set
            {
                this.searchTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AvailabilityIndicator
        {
            get
            {
                return this.availabilityIndicatorField;
            }
            set
            {
                this.availabilityIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AvailabilityIndicatorSpecified
        {
            get
            {
                return this.availabilityIndicatorFieldSpecified;
            }
            set
            {
                this.availabilityIndicatorFieldSpecified = value;
            }
        }
    }
}