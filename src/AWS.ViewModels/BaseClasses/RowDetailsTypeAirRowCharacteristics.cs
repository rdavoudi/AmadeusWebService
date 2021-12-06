namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ColumnDetailsTypeAirColumnCharacteristics))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RowDetailsTypeAirRowCharacteristics
    {

        private string[] characteristicListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] CharacteristicList
        {
            get
            {
                return this.characteristicListField;
            }
            set
            {
                this.characteristicListField = value;
            }
        }
    }
}