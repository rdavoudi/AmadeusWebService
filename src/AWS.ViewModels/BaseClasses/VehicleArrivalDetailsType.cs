namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleArrivalDetailsType
    {

        private LocationType arrivalLocationField;

        private CompanyNameType marketingCompanyField;

        private CompanyNameType operatingCompanyField;

        private string transportationCodeField;

        private string numberField;

        private System.DateTime arrivalDateTimeField;

        private bool arrivalDateTimeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public LocationType ArrivalLocation
        {
            get
            {
                return this.arrivalLocationField;
            }
            set
            {
                this.arrivalLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CompanyNameType MarketingCompany
        {
            get
            {
                return this.marketingCompanyField;
            }
            set
            {
                this.marketingCompanyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CompanyNameType OperatingCompany
        {
            get
            {
                return this.operatingCompanyField;
            }
            set
            {
                this.operatingCompanyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransportationCode
        {
            get
            {
                return this.transportationCodeField;
            }
            set
            {
                this.transportationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ArrivalDateTime
        {
            get
            {
                return this.arrivalDateTimeField;
            }
            set
            {
                this.arrivalDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArrivalDateTimeSpecified
        {
            get
            {
                return this.arrivalDateTimeFieldSpecified;
            }
            set
            {
                this.arrivalDateTimeFieldSpecified = value;
            }
        }
    }
}