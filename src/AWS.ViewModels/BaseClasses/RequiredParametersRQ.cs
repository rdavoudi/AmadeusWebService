namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RequiredParametersRQ
    {

        private int recommendationIDField;

        private int combinationIDField;

        private bool isOneWayCombinableField;

        private bool isOneWayCombinableFieldSpecified;

        private string cCTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int RecommendationID
        {
            get
            {
                return this.recommendationIDField;
            }
            set
            {
                this.recommendationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int CombinationID
        {
            get
            {
                return this.combinationIDField;
            }
            set
            {
                this.combinationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsOneWayCombinable
        {
            get
            {
                return this.isOneWayCombinableField;
            }
            set
            {
                this.isOneWayCombinableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsOneWayCombinableSpecified
        {
            get
            {
                return this.isOneWayCombinableFieldSpecified;
            }
            set
            {
                this.isOneWayCombinableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CCType
        {
            get
            {
                return this.cCTypeField;
            }
            set
            {
                this.cCTypeField = value;
            }
        }
    }
}