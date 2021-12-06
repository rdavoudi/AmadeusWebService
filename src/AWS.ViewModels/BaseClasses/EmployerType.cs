namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class EmployerType
    {

        private CompanyNameType companyNameField;

        private CompanyNameType[] relatedEmployerField;

        private EmployeeInfoType[] employeeInfoField;

        private FreeTextType[] internalRefNmbrField;

        private TravelArrangerType[] travelArrangerField;

        private LoyaltyProgramType[] loyaltyProgramField;

        private bool defaultIndField;

        private OfficeLocationType officeTypeField;

        private bool officeTypeFieldSpecified;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private System.DateTime expireDateField;

        private bool expireDateFieldSpecified;

        public EmployerType()
        {
            this.defaultIndField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CompanyNameType CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RelatedEmployer", Order = 1)]
        public CompanyNameType[] RelatedEmployer
        {
            get
            {
                return this.relatedEmployerField;
            }
            set
            {
                this.relatedEmployerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EmployeeInfo", Order = 2)]
        public EmployeeInfoType[] EmployeeInfo
        {
            get
            {
                return this.employeeInfoField;
            }
            set
            {
                this.employeeInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InternalRefNmbr", Order = 3)]
        public FreeTextType[] InternalRefNmbr
        {
            get
            {
                return this.internalRefNmbrField;
            }
            set
            {
                this.internalRefNmbrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TravelArranger", Order = 4)]
        public TravelArrangerType[] TravelArranger
        {
            get
            {
                return this.travelArrangerField;
            }
            set
            {
                this.travelArrangerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyProgram", Order = 5)]
        public LoyaltyProgramType[] LoyaltyProgram
        {
            get
            {
                return this.loyaltyProgramField;
            }
            set
            {
                this.loyaltyProgramField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DefaultInd
        {
            get
            {
                return this.defaultIndField;
            }
            set
            {
                this.defaultIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OfficeLocationType OfficeType
        {
            get
            {
                return this.officeTypeField;
            }
            set
            {
                this.officeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OfficeTypeSpecified
        {
            get
            {
                return this.officeTypeFieldSpecified;
            }
            set
            {
                this.officeTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EffectiveDateSpecified
        {
            get
            {
                return this.effectiveDateFieldSpecified;
            }
            set
            {
                this.effectiveDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpireDateSpecified
        {
            get
            {
                return this.expireDateFieldSpecified;
            }
            set
            {
                this.expireDateFieldSpecified = value;
            }
        }
    }
}