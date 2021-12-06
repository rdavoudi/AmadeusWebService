namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RuleInfoTypeChargesRules
    {

        private VoluntaryChangesType voluntaryChangesField;

        private VoluntaryChangesType voluntaryRefundsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public VoluntaryChangesType VoluntaryChanges
        {
            get
            {
                return this.voluntaryChangesField;
            }
            set
            {
                this.voluntaryChangesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public VoluntaryChangesType VoluntaryRefunds
        {
            get
            {
                return this.voluntaryRefundsField;
            }
            set
            {
                this.voluntaryRefundsField = value;
            }
        }
    }
}