namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class User : PassengerDB
    {

        private NameValueTypeItem[] extraPropertiesField;

        private System.Nullable<bool> isEticketAllowedField;

        private System.Nullable<bool> isEticketRequestAllowedField;

        private NameValueTypeItem[] extraSettingsField;

        private System.Nullable<System.Guid> corporateUserGroupIDField;

        private string guestUserIdField;

        private string userNameField;

        private string passwordField;

        private string hashedPasswordField;

        private string saltField;

        private string passwordAnswerField;

        private string hashedPasswordAnswerField;

        private string passwordQuestionField;

        private System.Nullable<System.DateTime> memberDateField;

        private System.Nullable<bool> isApprovedMemberField;

        private System.Nullable<System.Guid> portalIDField;

        private string emailField;

        private System.Nullable<bool> isCallMeAllowedField;

        private PassengerDB[] passengersField;

        private string userCultureField;

        private System.Nullable<bool> isCreditCardAllowedField;

        private System.Nullable<decimal> currentAccountAmountField;

        private System.Nullable<decimal> aCurrentAccountAmountField;

        private string accountAmountCurrencyField;

        private string toleranceField;

        private System.Nullable<System.Guid> corporateIDField;

        private System.Nullable<System.Guid> virtualCorporateIDField;

        private System.Nullable<bool> registration1Field;

        private System.Nullable<bool> registration2Field;

        private Person contactPersonField;

        private Corporate userCorporateField;

        private User[] travelApproversField;

        private User[] travelArrangersField;

        private System.Nullable<bool> isTravelApproverField;

        private System.Nullable<bool> isTravelArrangerField;

        private System.Nullable<bool> approverNotRequiredField;

        private System.Nullable<bool> modifyProfileField;

        private string bookingAllowField;

        private System.Nullable<bool> isLockedField;

        private string lockedOutReasonField;

        private System.Nullable<bool> allowToAccessCorpReportsField;

        private System.Nullable<bool> pRDADMINField;

        private System.Nullable<UICustomizationsRights> uICustRightsField;

        private System.Nullable<bool> uIMigrationUserField;

        private OPSProfile oPSProfileField;

        private System.Guid logIDField;

        private bool passwordChangeNeededField;

        private string platformCodeField;

        private System.Nullable<System.DateTime> passwordUpdateDateField;

        private System.Nullable<System.DateTime> lastEntryDateField;

        private string lSSAccessTokenField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public NameValueTypeItem[] ExtraProperties
        {
            get
            {
                return this.extraPropertiesField;
            }
            set
            {
                this.extraPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<bool> IsEticketAllowed
        {
            get
            {
                return this.isEticketAllowedField;
            }
            set
            {
                this.isEticketAllowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<bool> IsEticketRequestAllowed
        {
            get
            {
                return this.isEticketRequestAllowedField;
            }
            set
            {
                this.isEticketRequestAllowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        public NameValueTypeItem[] ExtraSettings
        {
            get
            {
                return this.extraSettingsField;
            }
            set
            {
                this.extraSettingsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<System.Guid> CorporateUserGroupID
        {
            get
            {
                return this.corporateUserGroupIDField;
            }
            set
            {
                this.corporateUserGroupIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string GuestUserId
        {
            get
            {
                return this.guestUserIdField;
            }
            set
            {
                this.guestUserIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string HashedPassword
        {
            get
            {
                return this.hashedPasswordField;
            }
            set
            {
                this.hashedPasswordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string Salt
        {
            get
            {
                return this.saltField;
            }
            set
            {
                this.saltField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string PasswordAnswer
        {
            get
            {
                return this.passwordAnswerField;
            }
            set
            {
                this.passwordAnswerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string HashedPasswordAnswer
        {
            get
            {
                return this.hashedPasswordAnswerField;
            }
            set
            {
                this.hashedPasswordAnswerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string PasswordQuestion
        {
            get
            {
                return this.passwordQuestionField;
            }
            set
            {
                this.passwordQuestionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 13)]
        public System.Nullable<System.DateTime> MemberDate
        {
            get
            {
                return this.memberDateField;
            }
            set
            {
                this.memberDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 14)]
        public System.Nullable<bool> IsApprovedMember
        {
            get
            {
                return this.isApprovedMemberField;
            }
            set
            {
                this.isApprovedMemberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 15)]
        public System.Nullable<System.Guid> PortalID
        {
            get
            {
                return this.portalIDField;
            }
            set
            {
                this.portalIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 17)]
        public System.Nullable<bool> IsCallMeAllowed
        {
            get
            {
                return this.isCallMeAllowedField;
            }
            set
            {
                this.isCallMeAllowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 18)]
        public PassengerDB[] Passengers
        {
            get
            {
                return this.passengersField;
            }
            set
            {
                this.passengersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public string UserCulture
        {
            get
            {
                return this.userCultureField;
            }
            set
            {
                this.userCultureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 20)]
        public System.Nullable<bool> IsCreditCardAllowed
        {
            get
            {
                return this.isCreditCardAllowedField;
            }
            set
            {
                this.isCreditCardAllowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 21)]
        public System.Nullable<decimal> CurrentAccountAmount
        {
            get
            {
                return this.currentAccountAmountField;
            }
            set
            {
                this.currentAccountAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 22)]
        public System.Nullable<decimal> ACurrentAccountAmount
        {
            get
            {
                return this.aCurrentAccountAmountField;
            }
            set
            {
                this.aCurrentAccountAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public string AccountAmountCurrency
        {
            get
            {
                return this.accountAmountCurrencyField;
            }
            set
            {
                this.accountAmountCurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
        public string Tolerance
        {
            get
            {
                return this.toleranceField;
            }
            set
            {
                this.toleranceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 25)]
        public System.Nullable<System.Guid> CorporateID
        {
            get
            {
                return this.corporateIDField;
            }
            set
            {
                this.corporateIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 26)]
        public System.Nullable<System.Guid> VirtualCorporateID
        {
            get
            {
                return this.virtualCorporateIDField;
            }
            set
            {
                this.virtualCorporateIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<bool> Registration1
        {
            get
            {
                return this.registration1Field;
            }
            set
            {
                this.registration1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<bool> Registration2
        {
            get
            {
                return this.registration2Field;
            }
            set
            {
                this.registration2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 29)]
        public Person ContactPerson
        {
            get
            {
                return this.contactPersonField;
            }
            set
            {
                this.contactPersonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 30)]
        public Corporate UserCorporate
        {
            get
            {
                return this.userCorporateField;
            }
            set
            {
                this.userCorporateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 31)]
        public User[] TravelApprovers
        {
            get
            {
                return this.travelApproversField;
            }
            set
            {
                this.travelApproversField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 32)]
        public User[] TravelArrangers
        {
            get
            {
                return this.travelArrangersField;
            }
            set
            {
                this.travelArrangersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 33)]
        public System.Nullable<bool> IsTravelApprover
        {
            get
            {
                return this.isTravelApproverField;
            }
            set
            {
                this.isTravelApproverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 34)]
        public System.Nullable<bool> IsTravelArranger
        {
            get
            {
                return this.isTravelArrangerField;
            }
            set
            {
                this.isTravelArrangerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 35)]
        public System.Nullable<bool> ApproverNotRequired
        {
            get
            {
                return this.approverNotRequiredField;
            }
            set
            {
                this.approverNotRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 36)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 37)]
        public string BookingAllow
        {
            get
            {
                return this.bookingAllowField;
            }
            set
            {
                this.bookingAllowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 38)]
        public System.Nullable<bool> IsLocked
        {
            get
            {
                return this.isLockedField;
            }
            set
            {
                this.isLockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 39)]
        public string LockedOutReason
        {
            get
            {
                return this.lockedOutReasonField;
            }
            set
            {
                this.lockedOutReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 40)]
        public System.Nullable<bool> AllowToAccessCorpReports
        {
            get
            {
                return this.allowToAccessCorpReportsField;
            }
            set
            {
                this.allowToAccessCorpReportsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 41)]
        public System.Nullable<bool> PRDADMIN
        {
            get
            {
                return this.pRDADMINField;
            }
            set
            {
                this.pRDADMINField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 42)]
        public System.Nullable<UICustomizationsRights> UICustRights
        {
            get
            {
                return this.uICustRightsField;
            }
            set
            {
                this.uICustRightsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 43)]
        public System.Nullable<bool> UIMigrationUser
        {
            get
            {
                return this.uIMigrationUserField;
            }
            set
            {
                this.uIMigrationUserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 44)]
        public OPSProfile OPSProfile
        {
            get
            {
                return this.oPSProfileField;
            }
            set
            {
                this.oPSProfileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 45)]
        public System.Guid LogID
        {
            get
            {
                return this.logIDField;
            }
            set
            {
                this.logIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 46)]
        public bool PasswordChangeNeeded
        {
            get
            {
                return this.passwordChangeNeededField;
            }
            set
            {
                this.passwordChangeNeededField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 47)]
        public string PlatformCode
        {
            get
            {
                return this.platformCodeField;
            }
            set
            {
                this.platformCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 48)]
        public System.Nullable<System.DateTime> PasswordUpdateDate
        {
            get
            {
                return this.passwordUpdateDateField;
            }
            set
            {
                this.passwordUpdateDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 49)]
        public System.Nullable<System.DateTime> LastEntryDate
        {
            get
            {
                return this.lastEntryDateField;
            }
            set
            {
                this.lastEntryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 50)]
        public string LSSAccessToken
        {
            get
            {
                return this.lSSAccessTokenField;
            }
            set
            {
                this.lSSAccessTokenField = value;
            }
        }
    }
}