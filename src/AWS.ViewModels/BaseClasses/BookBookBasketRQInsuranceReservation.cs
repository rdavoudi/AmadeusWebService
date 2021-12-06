namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BookBookBasketRQInsuranceReservation
    {

        private int planIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int PlanID
        {
            get
            {
                return this.planIDField;
            }
            set
            {
                this.planIDField = value;
            }
        }
    }
}