namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AgreementsType
    {

        private CertificationType[] certificationField;

        private AllianceConsortiumType[] allianceConsortiumField;

        private CommissionInfoType[] commissionInfoField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        private AgreementsTypeShareSynchInd shareSynchIndField;

        private bool shareSynchIndFieldSpecified;

        private AgreementsTypeShareMarketInd shareMarketIndField;

        private bool shareMarketIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Certification", Order = 0)]
        public CertificationType[] Certification
        {
            get
            {
                return this.certificationField;
            }
            set
            {
                this.certificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllianceConsortium", Order = 1)]
        public AllianceConsortiumType[] AllianceConsortium
        {
            get
            {
                return this.allianceConsortiumField;
            }
            set
            {
                this.allianceConsortiumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommissionInfo", Order = 2)]
        public CommissionInfoType[] CommissionInfo
        {
            get
            {
                return this.commissionInfoField;
            }
            set
            {
                this.commissionInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AgreementsTypeShareSynchInd ShareSynchInd
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
        public AgreementsTypeShareMarketInd ShareMarketInd
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
    }
}