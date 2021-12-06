namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleTourInfoType
    {

        private CompanyNameType tourOperatorField;

        private string tourNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CompanyNameType TourOperator
        {
            get
            {
                return this.tourOperatorField;
            }
            set
            {
                this.tourOperatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TourNumber
        {
            get
            {
                return this.tourNumberField;
            }
            set
            {
                this.tourNumberField = value;
            }
        }
    }
}