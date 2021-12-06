namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirSearchPrefsTypeVendorPref : CompanyNamePrefType
    {

        private bool allianceAllowedIndField;

        private bool allianceAllowedIndFieldSpecified;

        private bool loyaltyAllowedIndField;

        private bool loyaltyAllowedIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AllianceAllowedInd
        {
            get
            {
                return this.allianceAllowedIndField;
            }
            set
            {
                this.allianceAllowedIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllianceAllowedIndSpecified
        {
            get
            {
                return this.allianceAllowedIndFieldSpecified;
            }
            set
            {
                this.allianceAllowedIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool LoyaltyAllowedInd
        {
            get
            {
                return this.loyaltyAllowedIndField;
            }
            set
            {
                this.loyaltyAllowedIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LoyaltyAllowedIndSpecified
        {
            get
            {
                return this.loyaltyAllowedIndFieldSpecified;
            }
            set
            {
                this.loyaltyAllowedIndFieldSpecified = value;
            }
        }
    }
}