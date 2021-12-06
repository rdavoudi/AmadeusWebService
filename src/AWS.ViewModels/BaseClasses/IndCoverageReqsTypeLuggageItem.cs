namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class IndCoverageReqsTypeLuggageItem
    {

        private FreeTextType luggageDescriptionField;

        private IndCoverageReqsTypeLuggageItemItemDeclaredValue itemDeclaredValueField;

        private IndCoverageReqsTypeLuggageItemLuggagePremium luggagePremiumField;

        private string luggageTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public FreeTextType LuggageDescription
        {
            get
            {
                return this.luggageDescriptionField;
            }
            set
            {
                this.luggageDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public IndCoverageReqsTypeLuggageItemItemDeclaredValue ItemDeclaredValue
        {
            get
            {
                return this.itemDeclaredValueField;
            }
            set
            {
                this.itemDeclaredValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public IndCoverageReqsTypeLuggageItemLuggagePremium LuggagePremium
        {
            get
            {
                return this.luggagePremiumField;
            }
            set
            {
                this.luggagePremiumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LuggageType
        {
            get
            {
                return this.luggageTypeField;
            }
            set
            {
                this.luggageTypeField = value;
            }
        }
    }
}