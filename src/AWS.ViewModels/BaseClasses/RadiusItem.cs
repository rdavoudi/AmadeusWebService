namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RadiusItem
    {

        private int indexField;

        private int fromValueField;

        private int toValueField;

        private string measureUnitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int Index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int FromValue
        {
            get
            {
                return this.fromValueField;
            }
            set
            {
                this.fromValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ToValue
        {
            get
            {
                return this.toValueField;
            }
            set
            {
                this.toValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MeasureUnit
        {
            get
            {
                return this.measureUnitField;
            }
            set
            {
                this.measureUnitField = value;
            }
        }
    }
}