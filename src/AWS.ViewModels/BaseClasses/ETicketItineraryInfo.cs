namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ETicketItineraryInfo
    {

        private string fromField;

        private string fromTerminalField;

        private string toField;

        private string toTerminalField;

        private string carrierField;

        private int flightNoField;

        private string operatingAirlineCodeField;

        private string marketingAirlineCodeField;

        private string classField;

        private System.DateTime departureDateField;

        private System.DateTime arrivalDateField;

        private string fareBasisField;

        private System.DateTime notValidBeforeField;

        private bool notValidBeforeFieldSpecified;

        private System.DateTime notValidAfterField;

        private bool notValidAfterFieldSpecified;

        private decimal baggageWeightField;

        private bool baggageWeightFieldSpecified;

        private string baggageWeightMeasureUnitField;

        private decimal baggageQuantityField;

        private bool baggageQuantityFieldSpecified;

        private string statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string From
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string FromTerminal
        {
            get
            {
                return this.fromTerminalField;
            }
            set
            {
                this.fromTerminalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string To
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string ToTerminal
        {
            get
            {
                return this.toTerminalField;
            }
            set
            {
                this.toTerminalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Carrier
        {
            get
            {
                return this.carrierField;
            }
            set
            {
                this.carrierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public int FlightNo
        {
            get
            {
                return this.flightNoField;
            }
            set
            {
                this.flightNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string OperatingAirlineCode
        {
            get
            {
                return this.operatingAirlineCodeField;
            }
            set
            {
                this.operatingAirlineCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string MarketingAirlineCode
        {
            get
            {
                return this.marketingAirlineCodeField;
            }
            set
            {
                this.marketingAirlineCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string Class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public System.DateTime DepartureDate
        {
            get
            {
                return this.departureDateField;
            }
            set
            {
                this.departureDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public System.DateTime ArrivalDate
        {
            get
            {
                return this.arrivalDateField;
            }
            set
            {
                this.arrivalDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string FareBasis
        {
            get
            {
                return this.fareBasisField;
            }
            set
            {
                this.fareBasisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public System.DateTime NotValidBefore
        {
            get
            {
                return this.notValidBeforeField;
            }
            set
            {
                this.notValidBeforeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NotValidBeforeSpecified
        {
            get
            {
                return this.notValidBeforeFieldSpecified;
            }
            set
            {
                this.notValidBeforeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public System.DateTime NotValidAfter
        {
            get
            {
                return this.notValidAfterField;
            }
            set
            {
                this.notValidAfterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NotValidAfterSpecified
        {
            get
            {
                return this.notValidAfterFieldSpecified;
            }
            set
            {
                this.notValidAfterFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public decimal BaggageWeight
        {
            get
            {
                return this.baggageWeightField;
            }
            set
            {
                this.baggageWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BaggageWeightSpecified
        {
            get
            {
                return this.baggageWeightFieldSpecified;
            }
            set
            {
                this.baggageWeightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string BaggageWeightMeasureUnit
        {
            get
            {
                return this.baggageWeightMeasureUnitField;
            }
            set
            {
                this.baggageWeightMeasureUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public decimal BaggageQuantity
        {
            get
            {
                return this.baggageQuantityField;
            }
            set
            {
                this.baggageQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BaggageQuantitySpecified
        {
            get
            {
                return this.baggageQuantityFieldSpecified;
            }
            set
            {
                this.baggageQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }
}