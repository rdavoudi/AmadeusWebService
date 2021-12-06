namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FareTypeFareConstruction
    {

        private bool formattedIndicatorField;

        private bool formattedIndicatorFieldSpecified;

        private string languageField;

        private string originCityCodeField;

        private string originCodeContextField;

        private string destinationCityCodeField;

        private string destinationCodeContextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FormattedIndicator
        {
            get
            {
                return this.formattedIndicatorField;
            }
            set
            {
                this.formattedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FormattedIndicatorSpecified
        {
            get
            {
                return this.formattedIndicatorFieldSpecified;
            }
            set
            {
                this.formattedIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "language")]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginCityCode
        {
            get
            {
                return this.originCityCodeField;
            }
            set
            {
                this.originCityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginCodeContext
        {
            get
            {
                return this.originCodeContextField;
            }
            set
            {
                this.originCodeContextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DestinationCityCode
        {
            get
            {
                return this.destinationCityCodeField;
            }
            set
            {
                this.destinationCityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DestinationCodeContext
        {
            get
            {
                return this.destinationCodeContextField;
            }
            set
            {
                this.destinationCodeContextField = value;
            }
        }
    }
}