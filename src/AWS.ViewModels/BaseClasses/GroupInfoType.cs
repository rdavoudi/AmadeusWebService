namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GroupInfoType
    {

        private GroupDetailType[] groupDetailsField;

        private string groupNameField;

        private int paxNumberofGroupField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public GroupDetailType[] GroupDetails
        {
            get
            {
                return this.groupDetailsField;
            }
            set
            {
                this.groupDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GroupName
        {
            get
            {
                return this.groupNameField;
            }
            set
            {
                this.groupNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int PaxNumberofGroup
        {
            get
            {
                return this.paxNumberofGroupField;
            }
            set
            {
                this.paxNumberofGroupField = value;
            }
        }
    }
}