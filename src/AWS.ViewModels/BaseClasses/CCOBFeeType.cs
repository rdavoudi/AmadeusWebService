namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CCOBFeeType : BookingFeeType
    {

        private decimal minOBFeeField;

        private decimal maxOBFeeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MinOBFee
        {
            get
            {
                return this.minOBFeeField;
            }
            set
            {
                this.minOBFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MaxOBFee
        {
            get
            {
                return this.maxOBFeeField;
            }
            set
            {
                this.maxOBFeeField = value;
            }
        }
    }
}