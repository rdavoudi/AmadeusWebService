namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GuaranteeType
    {

        private ArrayOfGuaranteeTypeGuaranteeAcceptedGuaranteeAccepted[] guaranteesAcceptedField;

        private GuaranteeTypeDeadline deadlineField;

        private ArrayOfCommentTypeCommentComment[] commentsField;

        private ParagraphType[] guaranteeDescriptionField;

        private GuaranteeTypeGuaranteeType1 guaranteeType1Field;

        private bool guaranteeType1FieldSpecified;

        private GuaranteeTypeRetributionType retributionTypeField;

        private bool retributionTypeFieldSpecified;

        private string guaranteeCodeField;

        private string guaranteeType2Field;

        private System.DateTime holdTimeField;

        private bool holdTimeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("GuaranteeAccepted", IsNullable = false)]
        public ArrayOfGuaranteeTypeGuaranteeAcceptedGuaranteeAccepted[] GuaranteesAccepted
        {
            get
            {
                return this.guaranteesAcceptedField;
            }
            set
            {
                this.guaranteesAcceptedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public GuaranteeTypeDeadline Deadline
        {
            get
            {
                return this.deadlineField;
            }
            set
            {
                this.deadlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Comment", IsNullable = false)]
        public ArrayOfCommentTypeCommentComment[] Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GuaranteeDescription", Order = 3)]
        public ParagraphType[] GuaranteeDescription
        {
            get
            {
                return this.guaranteeDescriptionField;
            }
            set
            {
                this.guaranteeDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public GuaranteeTypeGuaranteeType1 GuaranteeType1
        {
            get
            {
                return this.guaranteeType1Field;
            }
            set
            {
                this.guaranteeType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GuaranteeType1Specified
        {
            get
            {
                return this.guaranteeType1FieldSpecified;
            }
            set
            {
                this.guaranteeType1FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public GuaranteeTypeRetributionType RetributionType
        {
            get
            {
                return this.retributionTypeField;
            }
            set
            {
                this.retributionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RetributionTypeSpecified
        {
            get
            {
                return this.retributionTypeFieldSpecified;
            }
            set
            {
                this.retributionTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GuaranteeCode
        {
            get
            {
                return this.guaranteeCodeField;
            }
            set
            {
                this.guaranteeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("GuaranteeType")]
        public string GuaranteeType2
        {
            get
            {
                return this.guaranteeType2Field;
            }
            set
            {
                this.guaranteeType2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime HoldTime
        {
            get
            {
                return this.holdTimeField;
            }
            set
            {
                this.holdTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HoldTimeSpecified
        {
            get
            {
                return this.holdTimeFieldSpecified;
            }
            set
            {
                this.holdTimeFieldSpecified = value;
            }
        }
    }
}