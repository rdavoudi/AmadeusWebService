namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirTaxType
    {

        private string taxCodeField;

        private decimal amountField;

        private bool amountFieldSpecified;

        private string taxCountryField;

        private string taxNameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TaxCode
        {
            get
            {
                return this.taxCodeField;
            }
            set
            {
                this.taxCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified
        {
            get
            {
                return this.amountFieldSpecified;
            }
            set
            {
                this.amountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TaxCountry
        {
            get
            {
                return this.taxCountryField;
            }
            set
            {
                this.taxCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TaxName
        {
            get
            {
                return this.taxNameField;
            }
            set
            {
                this.taxNameField = value;
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