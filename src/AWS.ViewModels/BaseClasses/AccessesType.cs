namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AccessesType
    {

        private AccessesTypeAccess[] accessField;

        private AccessesTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private AccessesTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private System.DateTime createDateTimeField;

        private bool createDateTimeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Access", Order = 0)]
        public AccessesTypeAccess[] Access
        {
            get
            {
                return this.accessField;
            }
            set
            {
                this.accessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AccessesTypeShareSynchInd ShareSynchInd
        {
            get
            {
                return this.shareSynchIndField;
            }
            set
            {
                this.shareSynchIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShareSynchIndSpecified
        {
            get
            {
                return this.shareSynchIndFieldSpecified;
            }
            set
            {
                this.shareSynchIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AccessesTypeShareMarketInd ShareMarketInd
        {
            get
            {
                return this.shareMarketIndField;
            }
            set
            {
                this.shareMarketIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShareMarketIndSpecified
        {
            get
            {
                return this.shareMarketIndFieldSpecified;
            }
            set
            {
                this.shareMarketIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime CreateDateTime
        {
            get
            {
                return this.createDateTimeField;
            }
            set
            {
                this.createDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreateDateTimeSpecified
        {
            get
            {
                return this.createDateTimeFieldSpecified;
            }
            set
            {
                this.createDateTimeFieldSpecified = value;
            }
        }
    }
}