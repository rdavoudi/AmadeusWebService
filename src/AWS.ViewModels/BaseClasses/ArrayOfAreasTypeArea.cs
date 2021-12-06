namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfAreasTypeArea
    {

        private ArrayOfAreasTypeAreaAreasTypeArea[] areasTypeAreaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AreasTypeArea", IsNullable = true, Order = 0)]
        public ArrayOfAreasTypeAreaAreasTypeArea[] AreasTypeArea
        {
            get
            {
                return this.areasTypeAreaField;
            }
            set
            {
                this.areasTypeAreaField = value;
            }
        }
    }
}