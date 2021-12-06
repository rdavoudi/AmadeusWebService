namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FareRuleResponseInfoTypeRouting
    {

        private FareRuleResponseInfoTypeRoutingInfo[] infoField;

        private string numberField;

        private bool routingConstructedIndField;

        private bool routingConstructedIndFieldSpecified;

        private string maximumPermittedMileageField;

        private string routingRestrictionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Info", Order = 0)]
        public FareRuleResponseInfoTypeRoutingInfo[] Info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RoutingConstructedInd
        {
            get
            {
                return this.routingConstructedIndField;
            }
            set
            {
                this.routingConstructedIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RoutingConstructedIndSpecified
        {
            get
            {
                return this.routingConstructedIndFieldSpecified;
            }
            set
            {
                this.routingConstructedIndFieldSpecified = value;
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
        public string RoutingRestriction
        {
            get
            {
                return this.routingRestrictionField;
            }
            set
            {
                this.routingRestrictionField = value;
            }
        }
    }
}