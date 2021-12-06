namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_InsuranceBookRQPlanForBookRQ : InsCoverageType
    {

        private InsuranceCustomerType insuranceCustomerField;

        private PlanCostType planCostField;

        private UniqueID_Type uniqueIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public InsuranceCustomerType InsuranceCustomer
        {
            get
            {
                return this.insuranceCustomerField;
            }
            set
            {
                this.insuranceCustomerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public PlanCostType PlanCost
        {
            get
            {
                return this.planCostField;
            }
            set
            {
                this.planCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public UniqueID_Type UniqueID
        {
            get
            {
                return this.uniqueIDField;
            }
            set
            {
                this.uniqueIDField = value;
            }
        }
    }
}