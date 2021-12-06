namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfPropertyValueMatchTypeAmenityAmenity : RoomAmenityPrefType
    {

        private string propertyAmenityTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PropertyAmenityType
        {
            get
            {
                return this.propertyAmenityTypeField;
            }
            set
            {
                this.propertyAmenityTypeField = value;
            }
        }
    }
}