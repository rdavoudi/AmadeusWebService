namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class StayRestrictionsTypeMaximumStay
    {

        private StayRestrictionsTypeMaximumStayReturnType returnTypeField;

        private bool returnTypeFieldSpecified;

        private string returnTimeOfDayField;

        private string maxStayField;

        private StayUnitType stayUnitField;

        private bool stayUnitFieldSpecified;

        private string maxStayDateField;

        private bool complicatedRulesIndField;

        private bool complicatedRulesIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StayRestrictionsTypeMaximumStayReturnType ReturnType
        {
            get
            {
                return this.returnTypeField;
            }
            set
            {
                this.returnTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnTypeSpecified
        {
            get
            {
                return this.returnTypeFieldSpecified;
            }
            set
            {
                this.returnTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReturnTimeOfDay
        {
            get
            {
                return this.returnTimeOfDayField;
            }
            set
            {
                this.returnTimeOfDayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaxStay
        {
            get
            {
                return this.maxStayField;
            }
            set
            {
                this.maxStayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public StayUnitType StayUnit
        {
            get
            {
                return this.stayUnitField;
            }
            set
            {
                this.stayUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StayUnitSpecified
        {
            get
            {
                return this.stayUnitFieldSpecified;
            }
            set
            {
                this.stayUnitFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MaxStayDate
        {
            get
            {
                return this.maxStayDateField;
            }
            set
            {
                this.maxStayDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ComplicatedRulesInd
        {
            get
            {
                return this.complicatedRulesIndField;
            }
            set
            {
                this.complicatedRulesIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ComplicatedRulesIndSpecified
        {
            get
            {
                return this.complicatedRulesIndFieldSpecified;
            }
            set
            {
                this.complicatedRulesIndFieldSpecified = value;
            }
        }
    }
}