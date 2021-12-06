namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfSpecialReqDetailsTypeSpecialRemarkSpecialRemark : SpecialRemarkType
    {

        private FlightLegType flightLegField;

        private ActionType operationField;

        private bool operationFieldSpecified;

        private string rPHField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public FlightLegType FlightLeg
        {
            get
            {
                return this.flightLegField;
            }
            set
            {
                this.flightLegField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionType Operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OperationSpecified
        {
            get
            {
                return this.operationFieldSpecified;
            }
            set
            {
                this.operationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }
    }
}