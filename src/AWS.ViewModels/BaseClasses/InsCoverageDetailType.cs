namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class InsCoverageDetailType
    {

        private CoverageLimitType[] coverageRequirementsField;

        private InsCoverageDetailTypeTotalTripQuantity totalTripQuantityField;

        private TimeDurationType maximumTripLengthField;

        private InsCoverageDetailTypeTotalTripCost totalTripCostField;

        private InsCoverageDetailTypeCoveredTrip[] coveredTripsField;

        private DistribPrefType[] deliveryPrefField;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private System.DateTime expireDateField;

        private bool expireDateFieldSpecified;

        private InsCoverageDetailTypeType typeField;

        private bool autoRenewField;

        private bool autoRenewFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CoverageRequirement", IsNullable = false)]
        public CoverageLimitType[] CoverageRequirements
        {
            get
            {
                return this.coverageRequirementsField;
            }
            set
            {
                this.coverageRequirementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public InsCoverageDetailTypeTotalTripQuantity TotalTripQuantity
        {
            get
            {
                return this.totalTripQuantityField;
            }
            set
            {
                this.totalTripQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TimeDurationType MaximumTripLength
        {
            get
            {
                return this.maximumTripLengthField;
            }
            set
            {
                this.maximumTripLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public InsCoverageDetailTypeTotalTripCost TotalTripCost
        {
            get
            {
                return this.totalTripCostField;
            }
            set
            {
                this.totalTripCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CoveredTrip", IsNullable = false)]
        public InsCoverageDetailTypeCoveredTrip[] CoveredTrips
        {
            get
            {
                return this.coveredTripsField;
            }
            set
            {
                this.coveredTripsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryPref", Order = 5)]
        public DistribPrefType[] DeliveryPref
        {
            get
            {
                return this.deliveryPrefField;
            }
            set
            {
                this.deliveryPrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EffectiveDateSpecified
        {
            get
            {
                return this.effectiveDateFieldSpecified;
            }
            set
            {
                this.effectiveDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpireDateSpecified
        {
            get
            {
                return this.expireDateFieldSpecified;
            }
            set
            {
                this.expireDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InsCoverageDetailTypeType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AutoRenew
        {
            get
            {
                return this.autoRenewField;
            }
            set
            {
                this.autoRenewField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AutoRenewSpecified
        {
            get
            {
                return this.autoRenewFieldSpecified;
            }
            set
            {
                this.autoRenewFieldSpecified = value;
            }
        }
    }
}