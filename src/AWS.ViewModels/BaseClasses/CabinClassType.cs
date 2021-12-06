namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CabinClassType
    {

        private RowDetailsType[] airRowsField;

        private ColumnDetailsType[] airColumnsField;

        private CabinType cabinTypeField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AirRow", IsNullable = false)]
        public RowDetailsType[] AirRows
        {
            get
            {
                return this.airRowsField;
            }
            set
            {
                this.airRowsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AirColumn", IsNullable = false)]
        public ColumnDetailsType[] AirColumns
        {
            get
            {
                return this.airColumnsField;
            }
            set
            {
                this.airColumnsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CabinType CabinType
        {
            get
            {
                return this.cabinTypeField;
            }
            set
            {
                this.cabinTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
}