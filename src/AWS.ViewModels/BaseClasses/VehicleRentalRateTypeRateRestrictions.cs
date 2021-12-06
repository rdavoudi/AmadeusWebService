namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleRentalRateTypeRateRestrictions
    {

        private bool arriveByFlightField;

        private bool minimumDayIndField;

        private bool minimumDayIndFieldSpecified;

        private bool maximumDayIndField;

        private bool maximumDayIndFieldSpecified;

        private bool advancedBookingIndField;

        private bool advancedBookingIndFieldSpecified;

        private bool restrictedMileageIndField;

        private bool restrictedMileageIndFieldSpecified;

        private bool corporateRateIndField;

        private bool corporateRateIndFieldSpecified;

        private bool guaranteeReqIndField;

        private bool guaranteeReqIndFieldSpecified;

        private string maximumVehiclesAllowedField;

        private bool overnightIndField;

        private bool overnightIndFieldSpecified;

        private VehicleRentalRateTypeRateRestrictionsOneWayPolicy oneWayPolicyField;

        private bool oneWayPolicyFieldSpecified;

        private bool cancellationPenaltyIndField;

        private bool cancellationPenaltyIndFieldSpecified;

        private bool modificationPenaltyIndField;

        private bool modificationPenaltyIndFieldSpecified;

        public VehicleRentalRateTypeRateRestrictions()
        {
            this.arriveByFlightField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ArriveByFlight
        {
            get
            {
                return this.arriveByFlightField;
            }
            set
            {
                this.arriveByFlightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MinimumDayInd
        {
            get
            {
                return this.minimumDayIndField;
            }
            set
            {
                this.minimumDayIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinimumDayIndSpecified
        {
            get
            {
                return this.minimumDayIndFieldSpecified;
            }
            set
            {
                this.minimumDayIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MaximumDayInd
        {
            get
            {
                return this.maximumDayIndField;
            }
            set
            {
                this.maximumDayIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaximumDayIndSpecified
        {
            get
            {
                return this.maximumDayIndFieldSpecified;
            }
            set
            {
                this.maximumDayIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AdvancedBookingInd
        {
            get
            {
                return this.advancedBookingIndField;
            }
            set
            {
                this.advancedBookingIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdvancedBookingIndSpecified
        {
            get
            {
                return this.advancedBookingIndFieldSpecified;
            }
            set
            {
                this.advancedBookingIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RestrictedMileageInd
        {
            get
            {
                return this.restrictedMileageIndField;
            }
            set
            {
                this.restrictedMileageIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RestrictedMileageIndSpecified
        {
            get
            {
                return this.restrictedMileageIndFieldSpecified;
            }
            set
            {
                this.restrictedMileageIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CorporateRateInd
        {
            get
            {
                return this.corporateRateIndField;
            }
            set
            {
                this.corporateRateIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CorporateRateIndSpecified
        {
            get
            {
                return this.corporateRateIndFieldSpecified;
            }
            set
            {
                this.corporateRateIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuaranteeReqInd
        {
            get
            {
                return this.guaranteeReqIndField;
            }
            set
            {
                this.guaranteeReqIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GuaranteeReqIndSpecified
        {
            get
            {
                return this.guaranteeReqIndFieldSpecified;
            }
            set
            {
                this.guaranteeReqIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaximumVehiclesAllowed
        {
            get
            {
                return this.maximumVehiclesAllowedField;
            }
            set
            {
                this.maximumVehiclesAllowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OvernightInd
        {
            get
            {
                return this.overnightIndField;
            }
            set
            {
                this.overnightIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OvernightIndSpecified
        {
            get
            {
                return this.overnightIndFieldSpecified;
            }
            set
            {
                this.overnightIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleRentalRateTypeRateRestrictionsOneWayPolicy OneWayPolicy
        {
            get
            {
                return this.oneWayPolicyField;
            }
            set
            {
                this.oneWayPolicyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OneWayPolicySpecified
        {
            get
            {
                return this.oneWayPolicyFieldSpecified;
            }
            set
            {
                this.oneWayPolicyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CancellationPenaltyInd
        {
            get
            {
                return this.cancellationPenaltyIndField;
            }
            set
            {
                this.cancellationPenaltyIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CancellationPenaltyIndSpecified
        {
            get
            {
                return this.cancellationPenaltyIndFieldSpecified;
            }
            set
            {
                this.cancellationPenaltyIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ModificationPenaltyInd
        {
            get
            {
                return this.modificationPenaltyIndField;
            }
            set
            {
                this.modificationPenaltyIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModificationPenaltyIndSpecified
        {
            get
            {
                return this.modificationPenaltyIndFieldSpecified;
            }
            set
            {
                this.modificationPenaltyIndFieldSpecified = value;
            }
        }
    }
}