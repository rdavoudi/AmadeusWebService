namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Corporate))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class Organization : Entity
    {

        private string codeField;

        private string titleField;

        private string judicalRecordNoField;

        private string typeCodeField;

        private string shortNameField;

        private System.Nullable<System.Guid> logoFileIDField;

        private System.Nullable<System.Guid> marketIDField;

        private string iATAField;

        private string officeIDField;

        private string subAgencyOIDField;

        private string offerOfficeIDField;

        private Organization[] branchesField;

        private System.Nullable<bool> isBSPMarketField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string JudicalRecordNo
        {
            get
            {
                return this.judicalRecordNoField;
            }
            set
            {
                this.judicalRecordNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string TypeCode
        {
            get
            {
                return this.typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string ShortName
        {
            get
            {
                return this.shortNameField;
            }
            set
            {
                this.shortNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<System.Guid> LogoFileID
        {
            get
            {
                return this.logoFileIDField;
            }
            set
            {
                this.logoFileIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.Guid> MarketID
        {
            get
            {
                return this.marketIDField;
            }
            set
            {
                this.marketIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string IATA
        {
            get
            {
                return this.iATAField;
            }
            set
            {
                this.iATAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string OfficeID
        {
            get
            {
                return this.officeIDField;
            }
            set
            {
                this.officeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string SubAgencyOID
        {
            get
            {
                return this.subAgencyOIDField;
            }
            set
            {
                this.subAgencyOIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string OfferOfficeID
        {
            get
            {
                return this.offerOfficeIDField;
            }
            set
            {
                this.offerOfficeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 11)]
        public Organization[] Branches
        {
            get
            {
                return this.branchesField;
            }
            set
            {
                this.branchesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<bool> IsBSPMarket
        {
            get
            {
                return this.isBSPMarketField;
            }
            set
            {
                this.isBSPMarketField = value;
            }
        }
    }
}