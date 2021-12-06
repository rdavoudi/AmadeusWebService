namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AmountTypeDiscount : DiscountType
    {

        private AmountTypeDiscountAppliesTo appliesToField;

        private bool appliesToFieldSpecified;

        private string itemRPHField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AmountTypeDiscountAppliesTo AppliesTo
        {
            get
            {
                return this.appliesToField;
            }
            set
            {
                this.appliesToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AppliesToSpecified
        {
            get
            {
                return this.appliesToFieldSpecified;
            }
            set
            {
                this.appliesToFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ItemRPH
        {
            get
            {
                return this.itemRPHField;
            }
            set
            {
                this.itemRPHField = value;
            }
        }
    }
}