namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FareInfoTypeFareInfo
    {

        private FareInfoTypeFareInfoDate[] dateField;

        private FareInfoTypeFareInfoFare fareField;

        private FareInfoTypeFareInfoPTC[] pTCField;

        private string fareBasisCodeField;

        private GlobalIndicatorType globalIndicatorCodeField;

        private bool globalIndicatorCodeFieldSpecified;

        private string maximumPermittedMileageField;

        private AirTripType tripTypeField;

        private bool tripTypeFieldSpecified;

        private string fareTypeField;

        private FareStatusType fareStatusField;

        private bool fareStatusFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Date", Order = 0)]
        public FareInfoTypeFareInfoDate[] Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public FareInfoTypeFareInfoFare Fare
        {
            get
            {
                return this.fareField;
            }
            set
            {
                this.fareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PTC", Order = 2)]
        public FareInfoTypeFareInfoPTC[] PTC
        {
            get
            {
                return this.pTCField;
            }
            set
            {
                this.pTCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareBasisCode
        {
            get
            {
                return this.fareBasisCodeField;
            }
            set
            {
                this.fareBasisCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public GlobalIndicatorType GlobalIndicatorCode
        {
            get
            {
                return this.globalIndicatorCodeField;
            }
            set
            {
                this.globalIndicatorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GlobalIndicatorCodeSpecified
        {
            get
            {
                return this.globalIndicatorCodeFieldSpecified;
            }
            set
            {
                this.globalIndicatorCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaximumPermittedMileage
        {
            get
            {
                return this.maximumPermittedMileageField;
            }
            set
            {
                this.maximumPermittedMileageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirTripType TripType
        {
            get
            {
                return this.tripTypeField;
            }
            set
            {
                this.tripTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TripTypeSpecified
        {
            get
            {
                return this.tripTypeFieldSpecified;
            }
            set
            {
                this.tripTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareType
        {
            get
            {
                return this.fareTypeField;
            }
            set
            {
                this.fareTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FareStatusType FareStatus
        {
            get
            {
                return this.fareStatusField;
            }
            set
            {
                this.fareStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FareStatusSpecified
        {
            get
            {
                return this.fareStatusFieldSpecified;
            }
            set
            {
                this.fareStatusFieldSpecified = value;
            }
        }
    }
}