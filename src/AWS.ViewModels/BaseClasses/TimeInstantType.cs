namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class TimeInstantType
    {

        private string windowBeforeField;

        private string windowAfterField;

        private bool crossDateAllowedIndicatorField;

        private bool crossDateAllowedIndicatorFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public string WindowBefore
        {
            get
            {
                return this.windowBeforeField;
            }
            set
            {
                this.windowBeforeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public string WindowAfter
        {
            get
            {
                return this.windowAfterField;
            }
            set
            {
                this.windowAfterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CrossDateAllowedIndicator
        {
            get
            {
                return this.crossDateAllowedIndicatorField;
            }
            set
            {
                this.crossDateAllowedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CrossDateAllowedIndicatorSpecified
        {
            get
            {
                return this.crossDateAllowedIndicatorFieldSpecified;
            }
            set
            {
                this.crossDateAllowedIndicatorFieldSpecified = value;
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