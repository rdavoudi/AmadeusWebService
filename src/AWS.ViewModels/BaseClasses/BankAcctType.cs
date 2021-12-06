namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BankAcctType
    {

        private string bankAcctNameField;

        private BankAcctTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private BankAcctTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        private string bankIDField;

        private string acctTypeField;

        private string bankAcctNumberField;

        private bool checksAcceptedIndField;

        private bool checksAcceptedIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string BankAcctName
        {
            get
            {
                return this.bankAcctNameField;
            }
            set
            {
                this.bankAcctNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public BankAcctTypeShareSynchInd ShareSynchInd
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
        public BankAcctTypeShareMarketInd ShareMarketInd
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
        public string BankID
        {
            get
            {
                return this.bankIDField;
            }
            set
            {
                this.bankIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AcctType
        {
            get
            {
                return this.acctTypeField;
            }
            set
            {
                this.acctTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BankAcctNumber
        {
            get
            {
                return this.bankAcctNumberField;
            }
            set
            {
                this.bankAcctNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ChecksAcceptedInd
        {
            get
            {
                return this.checksAcceptedIndField;
            }
            set
            {
                this.checksAcceptedIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChecksAcceptedIndSpecified
        {
            get
            {
                return this.checksAcceptedIndFieldSpecified;
            }
            set
            {
                this.checksAcceptedIndFieldSpecified = value;
            }
        }
    }
}