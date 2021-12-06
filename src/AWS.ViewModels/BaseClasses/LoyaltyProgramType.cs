namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class LoyaltyProgramType
    {

        private string programCodeField;

        private LoyaltyProgramTypeSingleVendorInd singleVendorIndField;

        private bool singleVendorIndFieldSpecified;

        private string loyaltyLevelField;

        private string rPHField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProgramCode
        {
            get
            {
                return this.programCodeField;
            }
            set
            {
                this.programCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LoyaltyProgramTypeSingleVendorInd SingleVendorInd
        {
            get
            {
                return this.singleVendorIndField;
            }
            set
            {
                this.singleVendorIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SingleVendorIndSpecified
        {
            get
            {
                return this.singleVendorIndFieldSpecified;
            }
            set
            {
                this.singleVendorIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LoyaltyLevel
        {
            get
            {
                return this.loyaltyLevelField;
            }
            set
            {
                this.loyaltyLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}