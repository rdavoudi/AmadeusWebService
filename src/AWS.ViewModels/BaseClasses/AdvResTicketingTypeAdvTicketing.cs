namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AdvResTicketingTypeAdvTicketing
    {

        private string fromResTimeOfDayField;

        private string fromResPeriodField;

        private StayUnitType fromResUnitField;

        private bool fromResUnitFieldSpecified;

        private string fromDepartTimeOfDayField;

        private string fromDepartPeriodField;

        private StayUnitType fromDepartUnitField;

        private bool fromDepartUnitFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FromResTimeOfDay
        {
            get
            {
                return this.fromResTimeOfDayField;
            }
            set
            {
                this.fromResTimeOfDayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FromResPeriod
        {
            get
            {
                return this.fromResPeriodField;
            }
            set
            {
                this.fromResPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StayUnitType FromResUnit
        {
            get
            {
                return this.fromResUnitField;
            }
            set
            {
                this.fromResUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FromResUnitSpecified
        {
            get
            {
                return this.fromResUnitFieldSpecified;
            }
            set
            {
                this.fromResUnitFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FromDepartTimeOfDay
        {
            get
            {
                return this.fromDepartTimeOfDayField;
            }
            set
            {
                this.fromDepartTimeOfDayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FromDepartPeriod
        {
            get
            {
                return this.fromDepartPeriodField;
            }
            set
            {
                this.fromDepartPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StayUnitType FromDepartUnit
        {
            get
            {
                return this.fromDepartUnitField;
            }
            set
            {
                this.fromDepartUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FromDepartUnitSpecified
        {
            get
            {
                return this.fromDepartUnitFieldSpecified;
            }
            set
            {
                this.fromDepartUnitFieldSpecified = value;
            }
        }
    }
}