namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PTCFareBreakdownTypePricingUnitFareComponentFlightLeg : BookFlightSegmentType
    {

        private bool surchargeIndField;

        private bool surchargeIndFieldSpecified;

        private string fareBasisCodeField;

        private decimal unitOfMeasureQuantityField;

        private bool unitOfMeasureQuantityFieldSpecified;

        private string unitOfMeasureField;

        private string unitOfMeasureCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SurchargeInd
        {
            get
            {
                return this.surchargeIndField;
            }
            set
            {
                this.surchargeIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SurchargeIndSpecified
        {
            get
            {
                return this.surchargeIndFieldSpecified;
            }
            set
            {
                this.surchargeIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareBasisCode
        {
            get
            {
                return this.fareBasisCodeField;
            }
            set
            {
                this.fareBasisCodeField = value;
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
    }
}