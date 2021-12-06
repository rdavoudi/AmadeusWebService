namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class EquipmentTypePref : EquipmentType
    {

        private PreferLevelType preferLevelField;

        private bool wideBodyField;

        private bool wideBodyFieldSpecified;

        public EquipmentTypePref()
        {
            this.preferLevelField = PreferLevelType.Preferred;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(PreferLevelType.Preferred)]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this.preferLevelField;
            }
            set
            {
                this.preferLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool WideBody
        {
            get
            {
                return this.wideBodyField;
            }
            set
            {
                this.wideBodyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WideBodySpecified
        {
            get
            {
                return this.wideBodyFieldSpecified;
            }
            set
            {
                this.wideBodyFieldSpecified = value;
            }
        }
    }
}