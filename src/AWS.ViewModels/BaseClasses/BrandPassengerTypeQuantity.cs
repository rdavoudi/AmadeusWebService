namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BrandPassengerTypeQuantity
    {

        private string quantityField;

        private string codeField;

        private Tax[] taxesField;

        private BaseFare baseFareField;

        private TotalFare totalFareField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        public Tax[] Taxes
        {
            get
            {
                return this.taxesField;
            }
            set
            {
                this.taxesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public BaseFare BaseFare
        {
            get
            {
                return this.baseFareField;
            }
            set
            {
                this.baseFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TotalFare TotalFare
        {
            get
            {
                return this.totalFareField;
            }
            set
            {
                this.totalFareField = value;
            }
        }
    }
}