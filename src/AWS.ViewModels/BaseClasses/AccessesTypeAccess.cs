namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AccessesTypeAccess
    {

        private PersonNameType accessPersonField;

        private FreeTextType accessCommentField;

        private AccessesTypeAccessActionType actionTypeField;

        private bool actionTypeFieldSpecified;

        private System.DateTime actionDateTimeField;

        private bool actionDateTimeFieldSpecified;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PersonNameType AccessPerson
        {
            get
            {
                return this.accessPersonField;
            }
            set
            {
                this.accessPersonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public FreeTextType AccessComment
        {
            get
            {
                return this.accessCommentField;
            }
            set
            {
                this.accessCommentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AccessesTypeAccessActionType ActionType
        {
            get
            {
                return this.actionTypeField;
            }
            set
            {
                this.actionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionTypeSpecified
        {
            get
            {
                return this.actionTypeFieldSpecified;
            }
            set
            {
                this.actionTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ActionDateTime
        {
            get
            {
                return this.actionDateTimeField;
            }
            set
            {
                this.actionDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionDateTimeSpecified
        {
            get
            {
                return this.actionDateTimeFieldSpecified;
            }
            set
            {
                this.actionDateTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}