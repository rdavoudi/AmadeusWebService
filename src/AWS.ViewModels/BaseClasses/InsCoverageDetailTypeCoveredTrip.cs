namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class InsCoverageDetailTypeCoveredTrip : TripFeaturesType
    {

        private string startField;

        private string durationField;

        private string endField;

        private System.DateTime depositDateField;

        private bool depositDateFieldSpecified;

        private System.DateTime finalPayDateField;

        private bool finalPayDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DepositDate
        {
            get
            {
                return this.depositDateField;
            }
            set
            {
                this.depositDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepositDateSpecified
        {
            get
            {
                return this.depositDateFieldSpecified;
            }
            set
            {
                this.depositDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime FinalPayDate
        {
            get
            {
                return this.finalPayDateField;
            }
            set
            {
                this.finalPayDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FinalPayDateSpecified
        {
            get
            {
                return this.finalPayDateFieldSpecified;
            }
            set
            {
                this.finalPayDateFieldSpecified = value;
            }
        }
    }
}