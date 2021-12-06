namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PTCFareBreakdownTypeEndorsements
    {

        private PTCFareBreakdownTypeEndorsementsEndorsement[] endorsementField;

        private bool nonRefundableIndicatorField;

        private bool nonRefundableIndicatorFieldSpecified;

        private bool nonEndorsableIndicatorField;

        private bool nonEndorsableIndicatorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Endorsement", Order = 0)]
        public PTCFareBreakdownTypeEndorsementsEndorsement[] Endorsement
        {
            get
            {
                return this.endorsementField;
            }
            set
            {
                this.endorsementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonRefundableIndicator
        {
            get
            {
                return this.nonRefundableIndicatorField;
            }
            set
            {
                this.nonRefundableIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NonRefundableIndicatorSpecified
        {
            get
            {
                return this.nonRefundableIndicatorFieldSpecified;
            }
            set
            {
                this.nonRefundableIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonEndorsableIndicator
        {
            get
            {
                return this.nonEndorsableIndicatorField;
            }
            set
            {
                this.nonEndorsableIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NonEndorsableIndicatorSpecified
        {
            get
            {
                return this.nonEndorsableIndicatorFieldSpecified;
            }
            set
            {
                this.nonEndorsableIndicatorFieldSpecified = value;
            }
        }
    }
}