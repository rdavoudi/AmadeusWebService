namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleAvailRQCoreTypeRateQualifier
    {

        private string travelPurposeField;

        private string rateCategoryField;

        private string corpDiscountNmbrField;

        private string rateQualifierField;

        private VehicleAvailRQCoreTypeRateQualifierRatePeriod ratePeriodField;

        private bool ratePeriodFieldSpecified;

        private bool guaranteedIndField;

        private bool guaranteedIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelPurpose
        {
            get
            {
                return this.travelPurposeField;
            }
            set
            {
                this.travelPurposeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateCategory
        {
            get
            {
                return this.rateCategoryField;
            }
            set
            {
                this.rateCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CorpDiscountNmbr
        {
            get
            {
                return this.corpDiscountNmbrField;
            }
            set
            {
                this.corpDiscountNmbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateQualifier
        {
            get
            {
                return this.rateQualifierField;
            }
            set
            {
                this.rateQualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VehicleAvailRQCoreTypeRateQualifierRatePeriod RatePeriod
        {
            get
            {
                return this.ratePeriodField;
            }
            set
            {
                this.ratePeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RatePeriodSpecified
        {
            get
            {
                return this.ratePeriodFieldSpecified;
            }
            set
            {
                this.ratePeriodFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuaranteedInd
        {
            get
            {
                return this.guaranteedIndField;
            }
            set
            {
                this.guaranteedIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GuaranteedIndSpecified
        {
            get
            {
                return this.guaranteedIndFieldSpecified;
            }
            set
            {
                this.guaranteedIndFieldSpecified = value;
            }
        }
    }
}