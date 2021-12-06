namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehRateRuleRQRentalInfoRateQualifier
    {

        private string travelPurposeField;

        private string rateCategoryField;

        private string corpDiscountNmbrField;

        private string rateQualifierField;

        private OTA_VehRateRuleRQRentalInfoRateQualifierRatePeriod ratePeriodField;

        private bool ratePeriodFieldSpecified;

        private bool guaranteedIndField;

        private bool guaranteedIndFieldSpecified;

        private string rateAuthorizationCodeField;

        private string vendorRateIDField;

        private bool rateModifiedIndField;

        private bool rateModifiedIndFieldSpecified;

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
        public OTA_VehRateRuleRQRentalInfoRateQualifierRatePeriod RatePeriod
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateAuthorizationCode
        {
            get
            {
                return this.rateAuthorizationCodeField;
            }
            set
            {
                this.rateAuthorizationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VendorRateID
        {
            get
            {
                return this.vendorRateIDField;
            }
            set
            {
                this.vendorRateIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RateModifiedInd
        {
            get
            {
                return this.rateModifiedIndField;
            }
            set
            {
                this.rateModifiedIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateModifiedIndSpecified
        {
            get
            {
                return this.rateModifiedIndFieldSpecified;
            }
            set
            {
                this.rateModifiedIndFieldSpecified = value;
            }
        }
    }
}