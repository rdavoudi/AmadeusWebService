namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleLocationAdditionalDetailsType
    {

        private VehicleLocationInformationType[] vehRentLocInfosField;

        private VehicleWhereAtFacilityType parkLocationField;

        private VehicleWhereAtFacilityType counterLocationField;

        private OperationSchedulesType operationSchedulesField;

        private VehicleLocationAdditionalDetailsTypeShuttle shuttleField;

        private VehicleLocationAdditionalDetailsTypeOneWayDropLocation[] oneWayDropLocationsField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("VehRentLocInfo", IsNullable = false)]
        public VehicleLocationInformationType[] VehRentLocInfos
        {
            get
            {
                return this.vehRentLocInfosField;
            }
            set
            {
                this.vehRentLocInfosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public VehicleWhereAtFacilityType ParkLocation
        {
            get
            {
                return this.parkLocationField;
            }
            set
            {
                this.parkLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public VehicleWhereAtFacilityType CounterLocation
        {
            get
            {
                return this.counterLocationField;
            }
            set
            {
                this.counterLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public OperationSchedulesType OperationSchedules
        {
            get
            {
                return this.operationSchedulesField;
            }
            set
            {
                this.operationSchedulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public VehicleLocationAdditionalDetailsTypeShuttle Shuttle
        {
            get
            {
                return this.shuttleField;
            }
            set
            {
                this.shuttleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("OneWayDropLocation", IsNullable = false)]
        public VehicleLocationAdditionalDetailsTypeOneWayDropLocation[] OneWayDropLocations
        {
            get
            {
                return this.oneWayDropLocationsField;
            }
            set
            {
                this.oneWayDropLocationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }
    }
}