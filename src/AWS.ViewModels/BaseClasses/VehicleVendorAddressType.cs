namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleVendorAddressType : AddressType
    {

        private string openingHourField;

        private string closingHourField;

        private string faxNumberField;

        private string officePhoneField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string OpeningHour
        {
            get
            {
                return this.openingHourField;
            }
            set
            {
                this.openingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string ClosingHour
        {
            get
            {
                return this.closingHourField;
            }
            set
            {
                this.closingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string FaxNumber
        {
            get
            {
                return this.faxNumberField;
            }
            set
            {
                this.faxNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string OfficePhone
        {
            get
            {
                return this.officePhoneField;
            }
            set
            {
                this.officePhoneField = value;
            }
        }
    }
}