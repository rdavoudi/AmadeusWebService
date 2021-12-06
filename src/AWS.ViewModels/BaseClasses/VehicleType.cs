namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_VehRateRuleRSVehicle))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleType : VehicleCoreType
    {

        private string numberOfSeatsField;

        private string numberOfDoorField;

        private string modelNameField;

        private VehicleTypeVehMakeModel vehMakeModelField;

        private string pictureURLField;

        private VehicleTypeVehIdentity vehIdentityField;

        private string passengerQuantityField;

        private string baggageQuantityField;

        private string vendorCarTypeField;

        private string codeField;

        private string codeContextField;

        private decimal unitOfMeasureQuantityField;

        private bool unitOfMeasureQuantityFieldSpecified;

        private string unitOfMeasureField;

        private string unitOfMeasureCodeField;

        private string startField;

        private string durationField;

        private string endField;

        private DistanceUnitNameType odometerUnitOfMeasureField;

        private bool odometerUnitOfMeasureFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string NumberOfSeats
        {
            get
            {
                return this.numberOfSeatsField;
            }
            set
            {
                this.numberOfSeatsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string NumberOfDoor
        {
            get
            {
                return this.numberOfDoorField;
            }
            set
            {
                this.numberOfDoorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ModelName
        {
            get
            {
                return this.modelNameField;
            }
            set
            {
                this.modelNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public VehicleTypeVehMakeModel VehMakeModel
        {
            get
            {
                return this.vehMakeModelField;
            }
            set
            {
                this.vehMakeModelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string PictureURL
        {
            get
            {
                return this.pictureURLField;
            }
            set
            {
                this.pictureURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public VehicleTypeVehIdentity VehIdentity
        {
            get
            {
                return this.vehIdentityField;
            }
            set
            {
                this.vehIdentityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PassengerQuantity
        {
            get
            {
                return this.passengerQuantityField;
            }
            set
            {
                this.passengerQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string BaggageQuantity
        {
            get
            {
                return this.baggageQuantityField;
            }
            set
            {
                this.baggageQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VendorCarType
        {
            get
            {
                return this.vendorCarTypeField;
            }
            set
            {
                this.vendorCarTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeContext
        {
            get
            {
                return this.codeContextField;
            }
            set
            {
                this.codeContextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal UnitOfMeasureQuantity
        {
            get
            {
                return this.unitOfMeasureQuantityField;
            }
            set
            {
                this.unitOfMeasureQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitOfMeasureQuantitySpecified
        {
            get
            {
                return this.unitOfMeasureQuantityFieldSpecified;
            }
            set
            {
                this.unitOfMeasureQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasureCode
        {
            get
            {
                return this.unitOfMeasureCodeField;
            }
            set
            {
                this.unitOfMeasureCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DistanceUnitNameType OdometerUnitOfMeasure
        {
            get
            {
                return this.odometerUnitOfMeasureField;
            }
            set
            {
                this.odometerUnitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OdometerUnitOfMeasureSpecified
        {
            get
            {
                return this.odometerUnitOfMeasureFieldSpecified;
            }
            set
            {
                this.odometerUnitOfMeasureFieldSpecified = value;
            }
        }
    }
}