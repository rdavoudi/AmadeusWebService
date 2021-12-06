namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfPropertiesTypeProperty
    {

        private ArrayOfPropertiesTypePropertyPropertiesTypeProperty[] propertiesTypePropertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertiesTypeProperty", IsNullable = true, Order = 0)]
        public ArrayOfPropertiesTypePropertyPropertiesTypeProperty[] PropertiesTypeProperty
        {
            get
            {
                return this.propertiesTypePropertyField;
            }
            set
            {
                this.propertiesTypePropertyField = value;
            }
        }
    }
}