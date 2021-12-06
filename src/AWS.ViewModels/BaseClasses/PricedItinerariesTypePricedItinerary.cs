namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PricedItinerariesTypePricedItinerary : PricedItineraryType
    {

        private string originDestinationRefNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string OriginDestinationRefNumber
        {
            get
            {
                return this.originDestinationRefNumberField;
            }
            set
            {
                this.originDestinationRefNumberField = value;
            }
        }
    }
}