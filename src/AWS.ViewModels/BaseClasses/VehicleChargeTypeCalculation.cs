namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleChargeTypeCalculation
    {

        private decimal unitChargeField;

        private bool unitChargeFieldSpecified;

        private string unitNameField;

        private string quantityField;

        private decimal percentageField;

        private bool percentageFieldSpecified;

        private VehicleChargeTypeCalculationApplicability applicabilityField;

        private bool applicabilityFieldSpecified;

        private string maxQuantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal UnitCharge
        {
            get
            {
                return this.unitChargeField;
            }
            set
            {
                this.unitChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitChargeSpecified
        {
            get
            {
                return this.unitChargeFieldSpecified;
            }
            set
            {
                this.unitChargeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
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
        public decimal Percentage
        {
            get
            {
                return this.percentageField;
            }
            set
            {
                this.percentageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentageSpecified
        {
            get
            {
                return this.percentageFieldSpecified;
            }
            set
            {
                this.percentageFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleChargeTypeCalculationApplicability Applicability
        {
            get
            {
                return this.applicabilityField;
            }
            set
            {
                this.applicabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplicabilitySpecified
        {
            get
            {
                return this.applicabilityFieldSpecified;
            }
            set
            {
                this.applicabilityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaxQuantity
        {
            get
            {
                return this.maxQuantityField;
            }
            set
            {
                this.maxQuantityField = value;
            }
        }
    }
}