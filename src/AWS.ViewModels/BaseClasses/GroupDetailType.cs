namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GroupDetailType
    {

        private string groupCodeField;

        private int paxCountofGroupField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GroupCode
        {
            get
            {
                return this.groupCodeField;
            }
            set
            {
                this.groupCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int PaxCountofGroup
        {
            get
            {
                return this.paxCountofGroupField;
            }
            set
            {
                this.paxCountofGroupField = value;
            }
        }
    }
}