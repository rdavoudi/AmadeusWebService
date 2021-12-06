namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_VehRateRuleRSVehRentalCore : VehicleRentalCoreType
    {

        private DayOfWeekType dayOfWeekField;

        private bool dayOfWeekFieldSpecified;

        private string currencyCodeField;

        private string companyShortNameField;

        private string travelSectorField;

        private string codeField;

        private string codeContextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DayOfWeekType DayOfWeek
        {
            get
            {
                return this.dayOfWeekField;
            }
            set
            {
                this.dayOfWeekField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DayOfWeekSpecified
        {
            get
            {
                return this.dayOfWeekFieldSpecified;
            }
            set
            {
                this.dayOfWeekFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CompanyShortName
        {
            get
            {
                return this.companyShortNameField;
            }
            set
            {
                this.companyShortNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelSector
        {
            get
            {
                return this.travelSectorField;
            }
            set
            {
                this.travelSectorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeContext
        {
            get
            {
                return this.codeContextField;
            }
            set
            {
                this.codeContextField = value;
            }
        }
    }
}