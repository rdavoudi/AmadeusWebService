namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RoomAmenityPrefType
    {

        private PreferLevelType preferLevelField;

        private string roomAmenityField;

        private string existsCodeField;

        private string quantityField;

        private string qualityLevelField;

        private string valueField;

        public RoomAmenityPrefType()
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
        public string RoomAmenity
        {
            get
            {
                return this.roomAmenityField;
            }
            set
            {
                this.roomAmenityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExistsCode
        {
            get
            {
                return this.existsCodeField;
            }
            set
            {
                this.existsCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string QualityLevel
        {
            get
            {
                return this.qualityLevelField;
            }
            set
            {
                this.qualityLevelField = value;
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