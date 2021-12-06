namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PaymentFormTypeVoucher
    {

        private string seriesCodeField;

        private string billingNumberField;

        private string supplierIdentifierField;

        private string identifierField;

        private string valueTypeField;

        private bool electronicIndicatorField;

        private bool electronicIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeriesCode
        {
            get
            {
                return this.seriesCodeField;
            }
            set
            {
                this.seriesCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BillingNumber
        {
            get
            {
                return this.billingNumberField;
            }
            set
            {
                this.billingNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SupplierIdentifier
        {
            get
            {
                return this.supplierIdentifierField;
            }
            set
            {
                this.supplierIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ValueType
        {
            get
            {
                return this.valueTypeField;
            }
            set
            {
                this.valueTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ElectronicIndicator
        {
            get
            {
                return this.electronicIndicatorField;
            }
            set
            {
                this.electronicIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ElectronicIndicatorSpecified
        {
            get
            {
                return this.electronicIndicatorFieldSpecified;
            }
            set
            {
                this.electronicIndicatorFieldSpecified = value;
            }
        }
    }
}