namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_HotelInfoRQ
    {

        private string hotelIDField;

        private string cityCodeField;

        private string hotelCodeField;

        private string hotelChainCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelID
        {
            get
            {
                return this.hotelIDField;
            }
            set
            {
                this.hotelIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CityCode
        {
            get
            {
                return this.cityCodeField;
            }
            set
            {
                this.cityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCode
        {
            get
            {
                return this.hotelCodeField;
            }
            set
            {
                this.hotelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelChainCode
        {
            get
            {
                return this.hotelChainCodeField;
            }
            set
            {
                this.hotelChainCodeField = value;
            }
        }
    }
}