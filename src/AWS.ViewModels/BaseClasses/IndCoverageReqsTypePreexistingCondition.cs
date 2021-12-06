namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class IndCoverageReqsTypePreexistingCondition : FreeTextType
    {

        private System.DateTime diagnosisDateField;

        private bool diagnosisDateFieldSpecified;

        private System.DateTime lastTreatmentDateField;

        private bool lastTreatmentDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime DiagnosisDate
        {
            get
            {
                return this.diagnosisDateField;
            }
            set
            {
                this.diagnosisDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiagnosisDateSpecified
        {
            get
            {
                return this.diagnosisDateFieldSpecified;
            }
            set
            {
                this.diagnosisDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime LastTreatmentDate
        {
            get
            {
                return this.lastTreatmentDateField;
            }
            set
            {
                this.lastTreatmentDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastTreatmentDateSpecified
        {
            get
            {
                return this.lastTreatmentDateFieldSpecified;
            }
            set
            {
                this.lastTreatmentDateFieldSpecified = value;
            }
        }
    }
}