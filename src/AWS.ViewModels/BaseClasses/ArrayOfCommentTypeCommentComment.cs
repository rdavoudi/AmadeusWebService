namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfCommentTypeCommentComment : ParagraphType
    {

        private string commentOriginatorCodeField;

        private bool guestViewableField;

        private bool guestViewableFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CommentOriginatorCode
        {
            get
            {
                return this.commentOriginatorCodeField;
            }
            set
            {
                this.commentOriginatorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool GuestViewable
        {
            get
            {
                return this.guestViewableField;
            }
            set
            {
                this.guestViewableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GuestViewableSpecified
        {
            get
            {
                return this.guestViewableFieldSpecified;
            }
            set
            {
                this.guestViewableFieldSpecified = value;
            }
        }
    }
}