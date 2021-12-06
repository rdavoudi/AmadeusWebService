namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResGlobalInfoType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ResCommonDetailType
    {

        private GuestCountType guestCountsField;

        private DateTimeSpanType timeSpanField;

        private ArrayOfResGuestRPHsTypeResGuestRPHResGuestRPH[] resGuestRPHsField;

        private ArrayOfMembershipTypeMembershipMembership[] membershipsField;

        private ArrayOfCommentTypeCommentComment[] commentsField;

        private ArrayOfSpecialRequestTypeSpecialRequestSpecialRequest[] specialRequestsField;

        private GuaranteeType guaranteeField;

        private ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePayment[] depositPaymentsField;

        private CancelPenaltiesType cancelPenaltiesField;

        private FeeType[] feesField;

        private TotalType totalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public GuestCountType GuestCounts
        {
            get
            {
                return this.guestCountsField;
            }
            set
            {
                this.guestCountsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public DateTimeSpanType TimeSpan
        {
            get
            {
                return this.timeSpanField;
            }
            set
            {
                this.timeSpanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ResGuestRPH", IsNullable = false)]
        public ArrayOfResGuestRPHsTypeResGuestRPHResGuestRPH[] ResGuestRPHs
        {
            get
            {
                return this.resGuestRPHsField;
            }
            set
            {
                this.resGuestRPHsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Membership", IsNullable = false)]
        public ArrayOfMembershipTypeMembershipMembership[] Memberships
        {
            get
            {
                return this.membershipsField;
            }
            set
            {
                this.membershipsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SpecialRequest", IsNullable = false)]
        public ArrayOfSpecialRequestTypeSpecialRequestSpecialRequest[] SpecialRequests
        {
            get
            {
                return this.specialRequestsField;
            }
            set
            {
                this.specialRequestsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public GuaranteeType Guarantee
        {
            get
            {
                return this.guaranteeField;
            }
            set
            {
                this.guaranteeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("GuaranteePayment", IsNullable = false)]
        public ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePayment[] DepositPayments
        {
            get
            {
                return this.depositPaymentsField;
            }
            set
            {
                this.depositPaymentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public CancelPenaltiesType CancelPenalties
        {
            get
            {
                return this.cancelPenaltiesField;
            }
            set
            {
                this.cancelPenaltiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 9)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable = false)]
        public FeeType[] Fees
        {
            get
            {
                return this.feesField;
            }
            set
            {
                this.feesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public TotalType Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }
    }
}