namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VoluntaryChangesType
    {

        private VoluntaryChangesTypePenalty penaltyField;

        private bool volChangeIndField;

        private bool volChangeIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public VoluntaryChangesTypePenalty Penalty
        {
            get
            {
                return this.penaltyField;
            }
            set
            {
                this.penaltyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool VolChangeInd
        {
            get
            {
                return this.volChangeIndField;
            }
            set
            {
                this.volChangeIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VolChangeIndSpecified
        {
            get
            {
                return this.volChangeIndFieldSpecified;
            }
            set
            {
                this.volChangeIndFieldSpecified = value;
            }
        }
    }
}