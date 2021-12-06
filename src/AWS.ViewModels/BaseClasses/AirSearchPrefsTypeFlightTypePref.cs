namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirSearchPrefsTypeFlightTypePref
    {

        private FlightTypeType flightTypeField;

        private bool flightTypeFieldSpecified;

        private string maxConnectionsField;

        private AirSearchPrefsTypeFlightTypePrefNonScheduledFltInfo nonScheduledFltInfoField;

        private bool nonScheduledFltInfoFieldSpecified;

        private bool backhaulIndicatorField;

        private bool backhaulIndicatorFieldSpecified;

        private bool groundTransportIndicatorField;

        private bool groundTransportIndicatorFieldSpecified;

        private bool directAndNonStopOnlyIndField;

        private bool directAndNonStopOnlyIndFieldSpecified;

        private bool nonStopsOnlyIndField;

        private bool nonStopsOnlyIndFieldSpecified;

        private bool onlineConnectionsOnlyIndField;

        private bool onlineConnectionsOnlyIndFieldSpecified;

        private AirSearchPrefsTypeFlightTypePrefRoutingType routingTypeField;

        private bool routingTypeFieldSpecified;

        private bool excludeTrainIndField;

        private bool excludeTrainIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FlightTypeType FlightType
        {
            get
            {
                return this.flightTypeField;
            }
            set
            {
                this.flightTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FlightTypeSpecified
        {
            get
            {
                return this.flightTypeFieldSpecified;
            }
            set
            {
                this.flightTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string MaxConnections
        {
            get
            {
                return this.maxConnectionsField;
            }
            set
            {
                this.maxConnectionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirSearchPrefsTypeFlightTypePrefNonScheduledFltInfo NonScheduledFltInfo
        {
            get
            {
                return this.nonScheduledFltInfoField;
            }
            set
            {
                this.nonScheduledFltInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NonScheduledFltInfoSpecified
        {
            get
            {
                return this.nonScheduledFltInfoFieldSpecified;
            }
            set
            {
                this.nonScheduledFltInfoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BackhaulIndicator
        {
            get
            {
                return this.backhaulIndicatorField;
            }
            set
            {
                this.backhaulIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BackhaulIndicatorSpecified
        {
            get
            {
                return this.backhaulIndicatorFieldSpecified;
            }
            set
            {
                this.backhaulIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GroundTransportIndicator
        {
            get
            {
                return this.groundTransportIndicatorField;
            }
            set
            {
                this.groundTransportIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GroundTransportIndicatorSpecified
        {
            get
            {
                return this.groundTransportIndicatorFieldSpecified;
            }
            set
            {
                this.groundTransportIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DirectAndNonStopOnlyInd
        {
            get
            {
                return this.directAndNonStopOnlyIndField;
            }
            set
            {
                this.directAndNonStopOnlyIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DirectAndNonStopOnlyIndSpecified
        {
            get
            {
                return this.directAndNonStopOnlyIndFieldSpecified;
            }
            set
            {
                this.directAndNonStopOnlyIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonStopsOnlyInd
        {
            get
            {
                return this.nonStopsOnlyIndField;
            }
            set
            {
                this.nonStopsOnlyIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NonStopsOnlyIndSpecified
        {
            get
            {
                return this.nonStopsOnlyIndFieldSpecified;
            }
            set
            {
                this.nonStopsOnlyIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OnlineConnectionsOnlyInd
        {
            get
            {
                return this.onlineConnectionsOnlyIndField;
            }
            set
            {
                this.onlineConnectionsOnlyIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OnlineConnectionsOnlyIndSpecified
        {
            get
            {
                return this.onlineConnectionsOnlyIndFieldSpecified;
            }
            set
            {
                this.onlineConnectionsOnlyIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirSearchPrefsTypeFlightTypePrefRoutingType RoutingType
        {
            get
            {
                return this.routingTypeField;
            }
            set
            {
                this.routingTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RoutingTypeSpecified
        {
            get
            {
                return this.routingTypeFieldSpecified;
            }
            set
            {
                this.routingTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExcludeTrainInd
        {
            get
            {
                return this.excludeTrainIndField;
            }
            set
            {
                this.excludeTrainIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExcludeTrainIndSpecified
        {
            get
            {
                return this.excludeTrainIndFieldSpecified;
            }
            set
            {
                this.excludeTrainIndFieldSpecified = value;
            }
        }
    }
}