namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class Corporate : Organization
    {

        private string homeOfficeIDField;

        private string[] awayOfficeIDsField;

        private string crossBorderSearchLogicField;

        private CrossBoarderSearchSetting cBSSettingsField;

        private string[] b2CRulesField;

        private string themeField;

        private string masterField;

        private string[] fareCodesField;

        private CorporateSetting[] corporateSettingsField;

        private QueueSetting[] queueSettingsField;

        private System.Nullable<bool> modifyProfileField;

        private System.Nullable<System.Guid> agencyCommissionIDField;

        private System.Nullable<System.Guid> agencySecondaryLevelServiceFeeIDField;

        private System.Nullable<System.Guid> groupCommissionIDField;

        private System.Nullable<System.Guid> agencyGroupIDField;

        private string groupNameField;

        private System.Nullable<bool> subAgencyUseParentCommissionField;

        private System.Nullable<bool> subAgencyUseParentServiceFeeField;

        private System.Nullable<bool> groupUseParentCommissionField;

        private System.Nullable<bool> groupUseParentServiceFeeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string HomeOfficeID
        {
            get
            {
                return this.homeOfficeIDField;
            }
            set
            {
                this.homeOfficeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        public string[] AwayOfficeIDs
        {
            get
            {
                return this.awayOfficeIDsField;
            }
            set
            {
                this.awayOfficeIDsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string CrossBorderSearchLogic
        {
            get
            {
                return this.crossBorderSearchLogicField;
            }
            set
            {
                this.crossBorderSearchLogicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CrossBoarderSearchSetting CBSSettings
        {
            get
            {
                return this.cBSSettingsField;
            }
            set
            {
                this.cBSSettingsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        public string[] B2CRules
        {
            get
            {
                return this.b2CRulesField;
            }
            set
            {
                this.b2CRulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string Theme
        {
            get
            {
                return this.themeField;
            }
            set
            {
                this.themeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string Master
        {
            get
            {
                return this.masterField;
            }
            set
            {
                this.masterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 7)]
        public string[] FareCodes
        {
            get
            {
                return this.fareCodesField;
            }
            set
            {
                this.fareCodesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 8)]
        public CorporateSetting[] CorporateSettings
        {
            get
            {
                return this.corporateSettingsField;
            }
            set
            {
                this.corporateSettingsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 9)]
        public QueueSetting[] QueueSettings
        {
            get
            {
                return this.queueSettingsField;
            }
            set
            {
                this.queueSettingsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<bool> ModifyProfile
        {
            get
            {
                return this.modifyProfileField;
            }
            set
            {
                this.modifyProfileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<System.Guid> AgencyCommissionID
        {
            get
            {
                return this.agencyCommissionIDField;
            }
            set
            {
                this.agencyCommissionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 12)]
        public System.Nullable<System.Guid> AgencySecondaryLevelServiceFeeID
        {
            get
            {
                return this.agencySecondaryLevelServiceFeeIDField;
            }
            set
            {
                this.agencySecondaryLevelServiceFeeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<System.Guid> GroupCommissionID
        {
            get
            {
                return this.groupCommissionIDField;
            }
            set
            {
                this.groupCommissionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<System.Guid> AgencyGroupID
        {
            get
            {
                return this.agencyGroupIDField;
            }
            set
            {
                this.agencyGroupIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 16)]
        public System.Nullable<bool> SubAgencyUseParentCommission
        {
            get
            {
                return this.subAgencyUseParentCommissionField;
            }
            set
            {
                this.subAgencyUseParentCommissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 17)]
        public System.Nullable<bool> SubAgencyUseParentServiceFee
        {
            get
            {
                return this.subAgencyUseParentServiceFeeField;
            }
            set
            {
                this.subAgencyUseParentServiceFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 18)]
        public System.Nullable<bool> GroupUseParentCommission
        {
            get
            {
                return this.groupUseParentCommissionField;
            }
            set
            {
                this.groupUseParentCommissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 19)]
        public System.Nullable<bool> GroupUseParentServiceFee
        {
            get
            {
                return this.groupUseParentServiceFeeField;
            }
            set
            {
                this.groupUseParentServiceFeeField = value;
            }
        }
    }
}