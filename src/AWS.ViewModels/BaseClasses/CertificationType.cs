namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CertificationType : FreeTextType
    {

        private string idField;

        private CertificationTypeSingleVendorInd singleVendorIndField;

        private bool singleVendorIndFieldSpecified;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private System.DateTime expireDateField;

        private bool expireDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CertificationTypeSingleVendorInd SingleVendorInd
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
    }
}