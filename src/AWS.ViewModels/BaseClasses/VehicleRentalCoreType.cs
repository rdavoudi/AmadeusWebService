namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OTA_VehRateRuleRSVehRentalCore))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleRentalCoreType
    {

        private AddressType pickupAddressField;

        private VehicleRentalCoreTypePickUpLocation[] pickUpLocationField;

        private VehicleRentalCoreTypeReturnLocation returnLocationField;

        private System.DateTime pickUpDateTimeField;

        private bool pickUpDateTimeFieldSpecified;

        private System.DateTime returnDateTimeField;

        private bool returnDateTimeFieldSpecified;

        private System.DateTime startChargesDateTimeField;

        private bool startChargesDateTimeFieldSpecified;

        private System.DateTime stopChargesDateTimeField;

        private bool stopChargesDateTimeFieldSpecified;

        private bool oneWayIndicatorField;

        private bool oneWayIndicatorFieldSpecified;

        private string multiIslandRentalDaysField;

        private string quantityField;

        private DistanceUnitNameType distUnitNameField;

        private bool distUnitNameFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AddressType PickupAddress
        {
            get
            {
                return this.pickupAddressField;
            }
            set
            {
                this.pickupAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PickUpLocation", Order = 1)]
        public VehicleRentalCoreTypePickUpLocation[] PickUpLocation
        {
            get
            {
                return this.pickUpLocationField;
            }
            set
            {
                this.pickUpLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public VehicleRentalCoreTypeReturnLocation ReturnLocation
        {
            get
            {
                return this.returnLocationField;
            }
            set
            {
                this.returnLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime PickUpDateTime
        {
            get
            {
                return this.pickUpDateTimeField;
            }
            set
            {
                this.pickUpDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PickUpDateTimeSpecified
        {
            get
            {
                return this.pickUpDateTimeFieldSpecified;
            }
            set
            {
                this.pickUpDateTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ReturnDateTime
        {
            get
            {
                return this.returnDateTimeField;
            }
            set
            {
                this.returnDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnDateTimeSpecified
        {
            get
            {
                return this.returnDateTimeFieldSpecified;
            }
            set
            {
                this.returnDateTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime StartChargesDateTime
        {
            get
            {
                return this.startChargesDateTimeField;
            }
            set
            {
                this.startChargesDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartChargesDateTimeSpecified
        {
            get
            {
                return this.startChargesDateTimeFieldSpecified;
            }
            set
            {
                this.startChargesDateTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime StopChargesDateTime
        {
            get
            {
                return this.stopChargesDateTimeField;
            }
            set
            {
                this.stopChargesDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StopChargesDateTimeSpecified
        {
            get
            {
                return this.stopChargesDateTimeFieldSpecified;
            }
            set
            {
                this.stopChargesDateTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OneWayIndicator
        {
            get
            {
                return this.oneWayIndicatorField;
            }
            set
            {
                this.oneWayIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OneWayIndicatorSpecified
        {
            get
            {
                return this.oneWayIndicatorFieldSpecified;
            }
            set
            {
                this.oneWayIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MultiIslandRentalDays
        {
            get
            {
                return this.multiIslandRentalDaysField;
            }
            set
            {
                this.multiIslandRentalDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DistanceUnitNameType DistUnitName
        {
            get
            {
                return this.distUnitNameField;
            }
            set
            {
                this.distUnitNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DistUnitNameSpecified
        {
            get
            {
                return this.distUnitNameFieldSpecified;
            }
            set
            {
                this.distUnitNameFieldSpecified = value;
            }
        }
    }
}