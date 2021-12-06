namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleTypeVehMakeModel
    {

        private string modelYearField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "gYear")]
        public string ModelYear
        {
            get
            {
                return this.modelYearField;
            }
            set
            {
                this.modelYearField = value;
            }
        }
    }
}