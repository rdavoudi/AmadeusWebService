namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RelatedMember
    {

        private string memberIDField;

        private string guestMemberIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MemberID
        {
            get
            {
                return this.memberIDField;
            }
            set
            {
                this.memberIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GuestMemberID
        {
            get
            {
                return this.guestMemberIDField;
            }
            set
            {
                this.guestMemberIDField = value;
            }
        }
    }
}