namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfServicesTypeService1
    {

        private ArrayOfServicesTypeService1ServicesTypeService[] servicesTypeServiceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServicesTypeService", IsNullable = true, Order = 0)]
        public ArrayOfServicesTypeService1ServicesTypeService[] ServicesTypeService
        {
            get
            {
                return this.servicesTypeServiceField;
            }
            set
            {
                this.servicesTypeServiceField = value;
            }
        }
    }
}