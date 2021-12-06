namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class HotelSearchCriterionTypeService
    {

        private string businessServiceCodeField;

        private string serviceInventoryCodeField;

        private string quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BusinessServiceCode
        {
            get
            {
                return this.businessServiceCodeField;
            }
            set
            {
                this.businessServiceCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ServiceInventoryCode
        {
            get
            {
                return this.serviceInventoryCodeField;
            }
            set
            {
                this.serviceInventoryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }
}