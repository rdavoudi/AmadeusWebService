namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SpecificFlightInfoTypeBookingClassPref
    {

        private string resBookDesigCodeField;

        private SpecificFlightInfoTypeBookingClassPrefResBookDesigCodeType resBookDesigCodeTypeField;

        private bool resBookDesigCodeTypeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this.resBookDesigCodeField;
            }
            set
            {
                this.resBookDesigCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SpecificFlightInfoTypeBookingClassPrefResBookDesigCodeType ResBookDesigCodeType
        {
            get
            {
                return this.resBookDesigCodeTypeField;
            }
            set
            {
                this.resBookDesigCodeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResBookDesigCodeTypeSpecified
        {
            get
            {
                return this.resBookDesigCodeTypeFieldSpecified;
            }
            set
            {
                this.resBookDesigCodeTypeFieldSpecified = value;
            }
        }
    }
}