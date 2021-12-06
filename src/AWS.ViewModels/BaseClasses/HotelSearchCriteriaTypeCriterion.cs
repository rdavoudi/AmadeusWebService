namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class HotelSearchCriteriaTypeCriterion : HotelSearchCriterionType
    {

        private string moreDataEchoTokenField;

        private string infoSourceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MoreDataEchoToken
        {
            get
            {
                return this.moreDataEchoTokenField;
            }
            set
            {
                this.moreDataEchoTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InfoSource
        {
            get
            {
                return this.infoSourceField;
            }
            set
            {
                this.infoSourceField = value;
            }
        }
    }
}