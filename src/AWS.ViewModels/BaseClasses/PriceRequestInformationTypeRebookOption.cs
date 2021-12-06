namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PriceRequestInformationTypeRebookOption
    {

        private string flightSegmentRPHField;

        private string resBookDesigCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FlightSegmentRPH
        {
            get
            {
                return this.flightSegmentRPHField;
            }
            set
            {
                this.flightSegmentRPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this.resBookDesigCodeField;
            }
            set
            {
                this.resBookDesigCodeField = value;
            }
        }
    }
}