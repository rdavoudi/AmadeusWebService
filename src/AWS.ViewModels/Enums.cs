using System.Xml.Serialization;

namespace AWS.ViewModels
{
    [System.FlagsAttribute()]
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum UICustomizationsRights
    {
        /// <remarks/>
        IsHostAdmin = 1,
        /// <remarks/>
        IsThemeRoller = 2,
        /// <remarks/>
        IsThemeWizard = 4,
        /// <remarks/>
        IsFileMang = 8,
        /// <remarks/>
        IsAccessHostAdminMenu = 16,
        /// <remarks/>
        IsAgencyRules = 32,
        /// <remarks/>
        IsUserFromAdmin = 64,
        /// <remarks/>
        IsHeaderFooterAdmin = 128,
    }

    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum LocalizationInnerTypes
    {
        /// <remarks/>
        None,
        /// <remarks/>
        PriceMessage,
        /// <remarks/>
        EPower,
        /// <remarks/>
        EPowerValidation,
        /// <remarks/>
        EPowerDynamicValidation,
        /// <remarks/>
        EPowerException,
        /// <remarks/>
        AWCLabel,
        /// <remarks/>
        AWCHyperLink,
        /// <remarks/>
        AWCLinkButton,
        /// <remarks/>
        AWCButton,
        /// <remarks/>
        AWCDropDownList,
        /// <remarks/>
        AWCGridView,
        /// <remarks/>
        TableButton,
        /// <remarks/>
        Auto,
        /// <remarks/>
        AWCCustomValidator,
        /// <remarks/>
        WizardStep,
        /// <remarks/>
        Login,
        /// <remarks/>
        Register,
        /// <remarks/>
        RecoverPassword,
        /// <remarks/>
        ChangePassword,
        /// <remarks/>
        AdminTask,
        /// <remarks/>
        API,
        /// <remarks/>
        TemplatedWrapper,
        /// <remarks/>
        AWCCheckBox,
        /// <remarks/>
        EPowerMobile,
        /// <remarks/>
        EPowerWSValidation,
        /// <remarks/>
        SearchPassengerTypes,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum ValidationErrorTypes
    {
        /// <remarks/>
        None,
        /// <remarks/>
        ValidationError,
        /// <remarks/>
        AmadeusAPIError,
        /// <remarks/>
        EpowerInternalError,
        /// <remarks/>
        EpowerUnhandledError,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum ValidationErrorCategories
    {
        /// <remarks/>
        System,
        /// <remarks/>
        AmadeusAPI,
        /// <remarks/>
        FatalError,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum LocalizationTypes
    {
        /// <remarks/>
        UI,
        /// <remarks/>
        System,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum ValidationErrorCodes
    {
        /// <remarks/>
        A000,
        /// <remarks/>
        A001,
        /// <remarks/>
        A002,
        /// <remarks/>
        A003,
        /// <remarks/>
        A004,
        /// <remarks/>
        A005,
        /// <remarks/>
        A006,
        /// <remarks/>
        A007,
        /// <remarks/>
        A008,
        /// <remarks/>
        A009,
        /// <remarks/>
        A010,
        /// <remarks/>
        A011,
        /// <remarks/>
        A012,
        /// <remarks/>
        A013,
        /// <remarks/>
        A014,
        /// <remarks/>
        A015,
        /// <remarks/>
        A016,
        /// <remarks/>
        A017,
        /// <remarks/>
        A018,
        /// <remarks/>
        A019,
        /// <remarks/>
        A020,
        /// <remarks/>
        A021,
        /// <remarks/>
        A022,
        /// <remarks/>
        A023,
        /// <remarks/>
        A024,
        /// <remarks/>
        A025,
        /// <remarks/>
        A026,
        /// <remarks/>
        A027,
        /// <remarks/>
        A028,
        /// <remarks/>
        A029,
        /// <remarks/>
        USR000,
        /// <remarks/>
        USR011,
        /// <remarks/>
        USR012,
        /// <remarks/>
        USR013,
        /// <remarks/>
        USR014,
        /// <remarks/>
        USR015,
        /// <remarks/>
        USR016,
        /// <remarks/>
        USR017,
        /// <remarks/>
        USR018,
        /// <remarks/>
        USR019,
        /// <remarks/>
        USR020,
        /// <remarks/>
        USR021,
        /// <remarks/>
        USR022,
        /// <remarks/>
        USR023,
        /// <remarks/>
        USR024,
        /// <remarks/>
        USR025,
        /// <remarks/>
        USR026,
        /// <remarks/>
        USR027,
        /// <remarks/>
        USR028,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum TripApprovalRuleEnum
    {
        /// <remarks/>
        NEVERNEEDSAPPROVAL,
        /// <remarks/>
        ALWAYSNEEDSAPPROVAL,
        /// <remarks/>
        NEEDSAPPROVALWHENTRIPISOUTOFPOLICY,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum DisplayRuleEnum
    {
        /// <remarks/>
        DISPLAYALLOPTIONS,
        /// <remarks/>
        DISPLAYONLYINPOLICYOPTIONS,
        /// <remarks/>
        DISPLAYONLYOUTPOLICYOPTIONSIFNOINPOLICYOPTION,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum CarProviderTypeEnum
    {
        /// <remarks/>
        None,
        /// <remarks/>
        AmadeusProvider,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum RailProviderTypeEnum
    {
        /// <remarks/>
        None,
        /// <remarks/>
        SNCFProvider,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum HotelProviderTypeEnum
    {
        /// <remarks/>
        None,
        /// <remarks/>
        GoGlobal,
        /// <remarks/>
        HotelsPro,
        /// <remarks/>
        AmadeusProvider,
        /// <remarks/>
        ContentInn,
        /// <remarks/>
        SunHotels,
        /// <remarks/>
        ContentStore,
        /// <remarks/>
        Albatravel,
        /// <remarks/>
        Bedsonline,
        /// <remarks/>
        Transhotel,
        /// <remarks/>
        GTA,
        /// <remarks/>
        Valuehotel,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum CommissionInfoTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum CommissionInfoTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum CertificationTypeSingleVendorInd
    {
        /// <remarks/>
        SingleVndr,
        /// <remarks/>
        Alliance,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PreferLevelType
    {
        /// <remarks/>
        Only,
        /// <remarks/>
        Unacceptable,
        /// <remarks/>
        Preferred,
        /// <remarks/>
        Required,
        /// <remarks/>
        NoPreference,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum TravelArrangerTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum TravelArrangerTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum URL_TypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum URL_TypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PersonNameTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PersonNameTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum EmailTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum EmailTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AddressTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AddressTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum DocumentTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum DocumentTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum DocumentTypeGender
    {
        /// <remarks/>
        Male,
        /// <remarks/>
        Female,
        /// <remarks/>
        Unknown,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum DocumentTypeHolderType
    {
        /// <remarks/>
        Infant,
        /// <remarks/>
        HeadOfHousehold,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum ContactPersonTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum ContactPersonTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum InsCoverageDetailTypeType
    {
        /// <remarks/>
        SingleTrip,
        /// <remarks/>
        MultiTrip,
        /// <remarks/>
        Other,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum CoverageTextType
    {
        /// <remarks/>
        Supplement,
        /// <remarks/>
        Description,
        /// <remarks/>
        Limits,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AmountDeterminationType
    {
        /// <remarks/>
        Inclusive,
        /// <remarks/>
        Exclusive,
        /// <remarks/>
        Cumulative,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_InsuranceBookRSTarget
    {
        /// <remarks/>
        Test,
        /// <remarks/>
        Production,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_InsuranceBookRSTransactionStatusCode
    {
        /// <remarks/>
        Start,
        /// <remarks/>
        End,
        /// <remarks/>
        Rollback,
        /// <remarks/>
        InSeries,
        /// <remarks/>
        Continuation,
        /// <remarks/>
        Subsequent,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum BankAcctTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum BankAcctTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum DirectBillTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum DirectBillTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PaymentFormTypeLoyaltyRedemptionLoyaltyCertificateFormat
    {
        /// <remarks/>
        Paper,
        /// <remarks/>
        Electronic,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PaymentCardTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PaymentCardTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PaymentTypes
    {
        /// <remarks/>
        None,
        /// <remarks/>
        CallMe,
        /// <remarks/>
        CreditCard,
        /// <remarks/>
        Invoice,
        /// <remarks/>
        PayAtAgency,
        /// <remarks/>
        C,
        /// <remarks/>
        CC,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PaymentFPTypes
    {
        /// <remarks/>
        FPCA,
        /// <remarks/>
        FPCC,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PaymentFormTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PaymentFormTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PaymentFormTypePaymentTransactionTypeCode
    {
        /// <remarks/>
        charge,
        /// <remarks/>
        reserve,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum VehicleReservationRQAdditionalInfoTypeRentalPaymentPrefType
    {
        /// <remarks/>
        guarantee,
        /// <remarks/>
        payment,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum RelatedTravelerTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum RelatedTravelerTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum CustomerTypeGender
    {
        /// <remarks/>
        Male,
        /// <remarks/>
        Female,
        /// <remarks/>
        Unknown,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum CustomerPrimaryAdditionalTypeAdditionalQualificationMethod
    {
        /// <remarks/>
        RT_AirlineTicket,
        /// <remarks/>
        CreditCard,
        /// <remarks/>
        PassportAndReturnTkt,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_InsuranceBookRQTarget
    {
        /// <remarks/>
        Test,
        /// <remarks/>
        Production,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_InsuranceBookRQTransactionStatusCode
    {
        /// <remarks/>
        Start,
        /// <remarks/>
        End,
        /// <remarks/>
        Rollback,
        /// <remarks/>
        InSeries,
        /// <remarks/>
        Continuation,
        /// <remarks/>
        Subsequent,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum LocationDetailShuttleInfoType
    {
        /// <remarks/>
        Transportation,
        /// <remarks/>
        Frequency,
        /// <remarks/>
        PickupInfo,
        /// <remarks/>
        Distance,
        /// <remarks/>
        ElapsedTime,
        /// <remarks/>
        Fee,
        /// <remarks/>
        Miscellaneous,
        /// <remarks/>
        Hours,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_InsurancePlanSearchRSTarget
    {
        /// <remarks/>
        Test,
        /// <remarks/>
        Production,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_InsurancePlanSearchRSTransactionStatusCode
    {
        /// <remarks/>
        Start,
        /// <remarks/>
        End,
        /// <remarks/>
        Rollback,
        /// <remarks/>
        InSeries,
        /// <remarks/>
        Continuation,
        /// <remarks/>
        Subsequent,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OrganizationTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OrganizationTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OfficeLocationType
    {
        /// <remarks/>
        Main,
        /// <remarks/>
        Field,
        /// <remarks/>
        Division,
        /// <remarks/>
        Regional,
        /// <remarks/>
        Remote,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum LoyaltyProgramTypeSingleVendorInd
    {
        /// <remarks/>
        SingleVndr,
        /// <remarks/>
        Alliance,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum TravelClubTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum TravelClubTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum InsuranceTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum InsuranceTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AffiliationsTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AffiliationsTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PhoneTypeEnum
    {
        /// <remarks/>
        Home,
        /// <remarks/>
        Office,
        /// <remarks/>
        Gsm,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum ActionType
    {
        /// <remarks/>
        [XmlEnumAttribute("Add-Update")]
        AddUpdate,
        /// <remarks/>
        Cancel,
        /// <remarks/>
        Delete,
        /// <remarks/>
        Add,
        /// <remarks/>
        Replace,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AirTravelerTypeGender
    {
        /// <remarks/>
        Male,
        /// <remarks/>
        Female,
        /// <remarks/>
        Unknown,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AirTravelerTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AirTravelerTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum VehicleAvailCoreTypeVendorLocationCounterLocInfo
    {
        /// <remarks/>
        WalkToCar,
        /// <remarks/>
        ShuttleToCar,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum ArrayOfSpecialReqDetailsTypeSpecialServiceRequestSpecialServiceRequestSSRType
    {
        /// <remarks/>
        None,
        /// <remarks/>
        MeetAndAssist,
        /// <remarks/>
        WheelChair,
        /// <remarks/>
        Bicycle,
        /// <remarks/>
        Surfboard,
        /// <remarks/>
        Windsurf,
        /// <remarks/>
        Snowboard,
        /// <remarks/>
        Animal,
        /// <remarks/>
        Golf,
        /// <remarks/>
        FishingEquipment,
        /// <remarks/>
        ExstraSeat,
        /// <remarks/>
        OtherEquipment,
        /// <remarks/>
        Baggage,
        /// <remarks/>
        BabyBasket,
        /// <remarks/>
        CabinBaggage,
        /// <remarks/>
        AncillaryService,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum FlightSegmentTypeMarketingAirlineSingleVendorInd
    {
        /// <remarks/>
        SingleVndr,
        /// <remarks/>
        Alliance,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum CabinType
    {
        /// <remarks/>
        First,
        /// <remarks/>
        Business,
        /// <remarks/>
        Economy,
        /// <remarks/>
        Premium,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum BookFlightSegmentTypeE_TicketEligibility
    {
        /// <remarks/>
        Eligible,
        /// <remarks/>
        [XmlEnumAttribute("Not Eligible")]
        NotEligible,
        /// <remarks/>
        Required,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum DayOfWeekType
    {
        /// <remarks/>
        Mon,
        /// <remarks/>
        Tue,
        /// <remarks/>
        Wed,
        /// <remarks/>
        Thu,
        /// <remarks/>
        Fri,
        /// <remarks/>
        Sat,
        /// <remarks/>
        Sun,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_AirSeatMapRQAirTravelerGender
    {
        /// <remarks/>
        Male,
        /// <remarks/>
        Female,
        /// <remarks/>
        Unknown,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_AirSeatMapRQAirTravelerShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_AirSeatMapRQAirTravelerShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_AirSeatMapRQTarget
    {
        /// <remarks/>
        Test,
        /// <remarks/>
        Production,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_AirSeatMapRQTransactionStatusCode
    {
        /// <remarks/>
        Start,
        /// <remarks/>
        End,
        /// <remarks/>
        Rollback,
        /// <remarks/>
        InSeries,
        /// <remarks/>
        Continuation,
        /// <remarks/>
        Subsequent,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AirTripType
    {
        /// <remarks/>
        OneWay,
        /// <remarks/>
        OneWayOnly,
        /// <remarks/>
        Return,
        /// <remarks/>
        Circle,
        /// <remarks/>
        OpenJaw,
        /// <remarks/>
        Other,
        /// <remarks/>
        Outbound,
        /// <remarks/>
        OutboundSeasonRoundtrip,
        /// <remarks/>
        [XmlEnumAttribute("Non-directional")]
        Nondirectional,
        /// <remarks/>
        Inbound,
        /// <remarks/>
        Roundtrip,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum StayUnitType
    {
        /// <remarks/>
        Minutes,
        /// <remarks/>
        Hours,
        /// <remarks/>
        Days,
        /// <remarks/>
        Months,
        /// <remarks/>
        MON,
        /// <remarks/>
        TUES,
        /// <remarks/>
        WED,
        /// <remarks/>
        THU,
        /// <remarks/>
        FRI,
        /// <remarks/>
        SAT,
        /// <remarks/>
        SUN,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum StayRestrictionsTypeMaximumStayReturnType
    {
        /// <remarks/>
        C,
        /// <remarks/>
        S,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum FareInfoTypeDateType
    {
        /// <remarks/>
        LastRuleChange,
        /// <remarks/>
        RuleBecomesInvalid,
        /// <remarks/>
        RestrictiveFareEffective,
        /// <remarks/>
        RestrictiveFareDiscontinue,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum FareInfoTypeFareInfoDateType
    {
        /// <remarks/>
        EffectiveTravel,
        /// <remarks/>
        DiscontinueTravel,
        /// <remarks/>
        FirstTicketing,
        /// <remarks/>
        LastTicketing,
        /// <remarks/>
        TravelCompletion,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum GlobalIndicatorType
    {
        /// <remarks/>
        AP,
        /// <remarks/>
        AT,
        /// <remarks/>
        CT,
        /// <remarks/>
        DO,
        /// <remarks/>
        EH,
        /// <remarks/>
        FE,
        /// <remarks/>
        PA,
        /// <remarks/>
        PN,
        /// <remarks/>
        PO,
        /// <remarks/>
        RU,
        /// <remarks/>
        RW,
        /// <remarks/>
        SA,
        /// <remarks/>
        TS,
        /// <remarks/>
        WH,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum FareStatusType
    {
        /// <remarks/>
        constructed,
        /// <remarks/>
        published,
        /// <remarks/>
        created,
        /// <remarks/>
        fareByRule,
        /// <remarks/>
        fareByRulePrivate,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum FareInfoTypeDiscountPricingPurpose
    {
        /// <remarks/>
        Airline,
        /// <remarks/>
        Custom,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum FareInfoTypeDiscountPricingType
    {
        /// <remarks/>
        Amount,
        /// <remarks/>
        Percentage,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum FareInfoTypeDiscountPricingUsage
    {
        /// <remarks/>
        Plus,
        /// <remarks/>
        Minus,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_AirRulesRQTarget
    {
        /// <remarks/>
        Test,
        /// <remarks/>
        Production,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_AirRulesRQTransactionStatusCode
    {
        /// <remarks/>
        Start,
        /// <remarks/>
        End,
        /// <remarks/>
        Rollback,
        /// <remarks/>
        InSeries,
        /// <remarks/>
        Continuation,
        /// <remarks/>
        Subsequent,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_InsurancePlanSearchRQTarget
    {
        /// <remarks/>
        Test,
        /// <remarks/>
        Production,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_InsurancePlanSearchRQTransactionStatusCode
    {
        /// <remarks/>
        Start,
        /// <remarks/>
        End,
        /// <remarks/>
        Rollback,
        /// <remarks/>
        InSeries,
        /// <remarks/>
        Continuation,
        /// <remarks/>
        Subsequent,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OffLocationServiceID_Type
    {
        /// <remarks/>
        CustPickUp,
        /// <remarks/>
        VehDelivery,
        /// <remarks/>
        CustDropOff,
        /// <remarks/>
        VehCollection,
        /// <remarks/>
        Exchange,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum TransactionActionType
    {
        /// <remarks/>
        Book,
        /// <remarks/>
        Quote,
        /// <remarks/>
        Hold,
        /// <remarks/>
        Initiate,
        /// <remarks/>
        Ignore,
        /// <remarks/>
        Modify,
        /// <remarks/>
        Commit,
        /// <remarks/>
        Cancel,
        /// <remarks/>
        CommitOverrideEdits,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum DistanceUnitNameType
    {
        /// <remarks/>
        Mile,
        /// <remarks/>
        Km,
        /// <remarks/>
        Block,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum VehiclePeriodUnitNameType
    {
        /// <remarks/>
        RentalPeriod,
        /// <remarks/>
        Year,
        /// <remarks/>
        Month,
        /// <remarks/>
        Week,
        /// <remarks/>
        Day,
        /// <remarks/>
        Hour,
        /// <remarks/>
        Weekend,
        /// <remarks/>
        Bundle,
        /// <remarks/>
        Package,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum VehicleChargeTypeCalculationApplicability
    {
        /// <remarks/>
        FromPickupLocation,
        /// <remarks/>
        FromDropoffLocation,
        /// <remarks/>
        BeforePickup,
        /// <remarks/>
        AfterDropoff,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum VehicleTransmissionType
    {
        /// <remarks/>
        A,
        /// <remarks/>
        M,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum VehicleCoreTypeFuelType
    {
        /// <remarks/>
        Unspecified,
        /// <remarks/>
        Diesel,
        /// <remarks/>
        Hybrid,
        /// <remarks/>
        Electric,
        /// <remarks/>
        LPG_CompressedGas,
        /// <remarks/>
        Hydrogen,
        /// <remarks/>
        MultiFuel,
        /// <remarks/>
        Petrol,
        /// <remarks/>
        Ethanol,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum VehicleCoreTypeDriveType
    {
        /// <remarks/>
        AWD,
        /// <remarks/>
        [XmlEnumAttribute("4WD")]
        Item4WD,
        /// <remarks/>
        Unspecified,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum RateQualifierTypeRatePeriod
    {
        /// <remarks/>
        Hourly,
        /// <remarks/>
        Daily,
        /// <remarks/>
        Weekly,
        /// <remarks/>
        Monthly,
        /// <remarks/>
        WeekendDay,
        /// <remarks/>
        Other,
        /// <remarks/>
        Package,
        /// <remarks/>
        Bundle,
        /// <remarks/>
        Total,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_VehResRQTarget
    {
        /// <remarks/>
        Test,
        /// <remarks/>
        Production,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_VehResRQTransactionStatusCode
    {
        /// <remarks/>
        Start,
        /// <remarks/>
        End,
        /// <remarks/>
        Rollback,
        /// <remarks/>
        InSeries,
        /// <remarks/>
        Continuation,
        /// <remarks/>
        Subsequent,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum EquipmentRestrictionType
    {
        /// <remarks/>
        OneWayOnly,
        /// <remarks/>
        RoundTripOnly,
        /// <remarks/>
        AnyReservation,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum TimeUnitType
    {
        /// <remarks/>
        Year,
        /// <remarks/>
        Month,
        /// <remarks/>
        Week,
        /// <remarks/>
        Day,
        /// <remarks/>
        Hour,
        /// <remarks/>
        Second,
        /// <remarks/>
        FullDuration,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum VehicleRentalRateTypeRateGuaranteeOffsetDropTime
    {
        /// <remarks/>
        BeforeArrival,
        /// <remarks/>
        AfterBooking,
        /// <remarks/>
        AfterConfirmation,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum VehicleRentalRateTypeRateRestrictionsOneWayPolicy
    {
        /// <remarks/>
        OneWayAllowed,
        /// <remarks/>
        OneWayNotAllowed,
        /// <remarks/>
        RestrictedOneWay,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum VehicleRentalRateTypePickupReturnRuleRuleType
    {
        /// <remarks/>
        EarliestPickup,
        /// <remarks/>
        LatestPickup,
        /// <remarks/>
        LatestReturn,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_VehRateRuleRSTarget
    {
        /// <remarks/>
        Test,
        /// <remarks/>
        Production,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_VehRateRuleRSTransactionStatusCode
    {
        /// <remarks/>
        Start,
        /// <remarks/>
        End,
        /// <remarks/>
        Rollback,
        /// <remarks/>
        InSeries,
        /// <remarks/>
        Continuation,
        /// <remarks/>
        Subsequent,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_VehRateRuleRQRentalInfoRateQualifierRatePeriod
    {
        /// <remarks/>
        Hourly,
        /// <remarks/>
        Daily,
        /// <remarks/>
        Weekly,
        /// <remarks/>
        Monthly,
        /// <remarks/>
        WeekendDay,
        /// <remarks/>
        Other,
        /// <remarks/>
        Package,
        /// <remarks/>
        Bundle,
        /// <remarks/>
        Total,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_VehRateRuleRQTarget
    {
        /// <remarks/>
        Test,
        /// <remarks/>
        Production,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_VehRateRuleRQTransactionStatusCode
    {
        /// <remarks/>
        Start,
        /// <remarks/>
        End,
        /// <remarks/>
        Rollback,
        /// <remarks/>
        InSeries,
        /// <remarks/>
        Continuation,
        /// <remarks/>
        Subsequent,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum ItemSearchCriterionTypeImportanceType
    {
        /// <remarks/>
        Mandatory,
        /// <remarks/>
        High,
        /// <remarks/>
        Medium,
        /// <remarks/>
        Low,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AccessesTypeAccessActionType
    {
        /// <remarks/>
        Create,
        /// <remarks/>
        Read,
        /// <remarks/>
        Update,
        /// <remarks/>
        Delete,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AccessesTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AccessesTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AddressPrefTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AddressPrefTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum MealType
    {
        /// <remarks/>
        AVML,
        /// <remarks/>
        BBML,
        /// <remarks/>
        BLML,
        /// <remarks/>
        CHML,
        /// <remarks/>
        DBML,
        /// <remarks/>
        FPML,
        /// <remarks/>
        GFML,
        /// <remarks/>
        HFML,
        /// <remarks/>
        HNML,
        /// <remarks/>
        KSML,
        /// <remarks/>
        LCML,
        /// <remarks/>
        LFML,
        /// <remarks/>
        LPML,
        /// <remarks/>
        LSML,
        /// <remarks/>
        MOML,
        /// <remarks/>
        NLML,
        /// <remarks/>
        ORML,
        /// <remarks/>
        PRML,
        /// <remarks/>
        RVML,
        /// <remarks/>
        SFML,
        /// <remarks/>
        SPML,
        /// <remarks/>
        VGML,
        /// <remarks/>
        VLML,
        /// <remarks/>
        RGML,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum CommonPrefTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum CommonPrefTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum VehicleProfileRentalPrefTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum VehicleProfileRentalPrefTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum FlightTypeType
    {
        /// <remarks/>
        Nonstop,
        /// <remarks/>
        Direct,
        /// <remarks/>
        Connection,
        /// <remarks/>
        SingleConnection,
        /// <remarks/>
        DoubleConnection,
        /// <remarks/>
        OneStopOnly,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AirlinePrefTypeFlightTypePrefNonScheduledFltInfo
    {
        /// <remarks/>
        ChartersOnly,
        /// <remarks/>
        ExcludeCharters,
        /// <remarks/>
        All,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AirlinePrefTypeFlightTypePrefRoutingType
    {
        /// <remarks/>
        Normal,
        /// <remarks/>
        Mirror,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AirlinePrefTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AirlinePrefTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum TicketType
    {
        /// <remarks/>
        BookingOnly,
        /// <remarks/>
        ETicketInstant,
        /// <remarks/>
        ETicketRequest,
        /// <remarks/>
        MyAddress,
        /// <remarks/>
        Ticketless,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum HotelPrefTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum HotelPrefTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OtherSrvcPrefTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OtherSrvcPrefTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PreferencesTypePrefCollectionShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PreferencesTypePrefCollectionShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PreferencesTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PreferencesTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AgreementsTypeShareSynchInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AgreementsTypeShareMarketInd
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
        /// <remarks/>
        Inherit,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum YesNoType
    {
        /// <remarks/>
        Yes,
        /// <remarks/>
        No,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_VehLocSearchRSTarget
    {
        /// <remarks/>
        Test,
        /// <remarks/>
        Production,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_VehLocSearchRSTransactionStatusCode
    {
        /// <remarks/>
        Start,
        /// <remarks/>
        End,
        /// <remarks/>
        Rollback,
        /// <remarks/>
        InSeries,
        /// <remarks/>
        Continuation,
        /// <remarks/>
        Subsequent,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_VehLocSearchRQTarget
    {
        /// <remarks/>
        Test,
        /// <remarks/>
        Production,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_VehLocSearchRQTransactionStatusCode
    {
        /// <remarks/>
        Start,
        /// <remarks/>
        End,
        /// <remarks/>
        Rollback,
        /// <remarks/>
        InSeries,
        /// <remarks/>
        Continuation,
        /// <remarks/>
        Subsequent,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum InventoryStatusType
    {
        /// <remarks/>
        Available,
        /// <remarks/>
        Unavailable,
        /// <remarks/>
        OnRequest,
        /// <remarks/>
        Confirmed,
        /// <remarks/>
        All,
        /// <remarks/>
        Waitlist,
        /// <remarks/>
        SupplierBooked,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_VehAvailRateRSTarget
    {
        /// <remarks/>
        Test,
        /// <remarks/>
        Production,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_VehAvailRateRSTransactionStatusCode
    {
        /// <remarks/>
        Start,
        /// <remarks/>
        End,
        /// <remarks/>
        Rollback,
        /// <remarks/>
        InSeries,
        /// <remarks/>
        Continuation,
        /// <remarks/>
        Subsequent,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum VehicleAvailRQCoreTypeRateQualifierRatePeriod
    {
        /// <remarks/>
        Hourly,
        /// <remarks/>
        Daily,
        /// <remarks/>
        Weekly,
        /// <remarks/>
        Monthly,
        /// <remarks/>
        WeekendDay,
        /// <remarks/>
        Other,
        /// <remarks/>
        Package,
        /// <remarks/>
        Bundle,
        /// <remarks/>
        Total,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_VehAvailRateRQTarget
    {
        /// <remarks/>
        Test,
        /// <remarks/>
        Production,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum OTA_VehAvailRateRQTransactionStatusCode
    {
        /// <remarks/>
        Start,
        /// <remarks/>
        End,
        /// <remarks/>
        Rollback,
        /// <remarks/>
        InSeries,
        /// <remarks/>
        Continuation,
        /// <remarks/>
        Subsequent,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum RateIndicatorType
    {
        /// <remarks/>
        ChangeDuringStay,
        /// <remarks/>
        MultipleNights,
        /// <remarks/>
        Exclusive,
        /// <remarks/>
        OnRequest,
        /// <remarks/>
        LimitedAvailability,
        /// <remarks/>
        AvailableForSale,
        /// <remarks/>
        ClosedOut,
        /// <remarks/>
        OtherAvailable,
        /// <remarks/>
        UnableToProcess,
        /// <remarks/>
        NoAvailability,
        /// <remarks/>
        RoomTypeClosed,
        /// <remarks/>
        RatePlanClosed,
        /// <remarks/>
        LOS_Restricted,
        /// <remarks/>
        Restricted,
        /// <remarks/>
        DoesNotExist,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum ArrayOfOTA_HotelAvailRSRoomStaysRoomStayRoomStayResponseType
    {
        /// <remarks/>
        PropertyList,
        /// <remarks/>
        AreaList,
        /// <remarks/>
        PropertyRateList,
        /// <remarks/>
        RateInfoDetails,
        /// <remarks/>
        ProfilePrefs,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum GuaranteeTypeDeadlineOffsetDropTime
    {
        /// <remarks/>
        BeforeArrival,
        /// <remarks/>
        AfterBooking,
        /// <remarks/>
        AfterConfirmation,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum GuaranteeTypeGuaranteeType1
    {
        /// <remarks/>
        GuaranteeRequired,
        /// <remarks/>
        None,
        /// <remarks/>
        [XmlEnumAttribute("CC/DC/Voucher")]
        CCDCVoucher,
        /// <remarks/>
        Profile,
        /// <remarks/>
        Deposit,
        /// <remarks/>
        PrePay,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum GuaranteeTypeRetributionType
    {
        /// <remarks/>
        ResAutoCancelled,
        /// <remarks/>
        ResNotGuaranteed,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum CancelPenaltyTypeDeadlineOffsetDropTime
    {
        /// <remarks/>
        BeforeArrival,
        /// <remarks/>
        AfterBooking,
        /// <remarks/>
        AfterConfirmation,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AmountPercentTypeBasisType
    {
        /// <remarks/>
        FullStay,
        /// <remarks/>
        Nights,
        /// <remarks/>
        FirstLast,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AmountPercentTypeApplyAs
    {
        /// <remarks/>
        FirstNightDeposit,
        /// <remarks/>
        LastNightDepost,
        /// <remarks/>
        FirstAndLastNightDeposit,
        /// <remarks/>
        FirstNightPayment,
        /// <remarks/>
        LastNightPayment,
        /// <remarks/>
        FirstAndLastNightPayment,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum CommissionTypeStatusType
    {
        /// <remarks/>
        Full,
        /// <remarks/>
        [XmlEnumAttribute("Non-paying")]
        Nonpaying,
        /// <remarks/>
        [XmlEnumAttribute("No-show")]
        Noshow,
        /// <remarks/>
        Adjustment,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum RatePlanTypeRestrictionStatusRestriction
    {
        /// <remarks/>
        Master,
        /// <remarks/>
        Arrival,
        /// <remarks/>
        Departure,
        /// <remarks/>
        NonGuarantee,
        /// <remarks/>
        TravelAgent,
    }
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AvailabilityStatusType
    {
        /// <remarks/>
        Open,
        /// <remarks/>
        Close,
        /// <remarks/>
        ClosedOnArrival,
        /// <remarks/>
        ClosedOnArrivalOnRequest,
        /// <remarks/>
        OnRequest,
    }

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PricingType
    {
        /// <remarks/>
        [XmlEnumAttribute("Per stay")]
        Perstay,
        /// <remarks/>
        [XmlEnumAttribute("Per person")]
        Perperson,
        /// <remarks/>
        [XmlEnumAttribute("Per night")]
        Pernight,
        /// <remarks/>
        [XmlEnumAttribute("Per person per night")]
        Perpersonpernight,
        /// <remarks/>
        [XmlEnumAttribute("Per use")]
        Peruse,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePaymentDeadlineOffsetDropTime
    {
        /// <remarks/>
        BeforeArrival,
        /// <remarks/>
        AfterBooking,
        /// <remarks/>
        AfterConfirmation,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePaymentRetributionType
    {
        /// <remarks/>
        ResAutoCancelled,
        /// <remarks/>
        ResNotGuaranteed,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePaymentType
    {
        /// <remarks/>
        RequiredPayment,
        /// <remarks/>
        GuaranteePolicy,
        /// <remarks/>
        AcceptedPaymentForms,
    }
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePaymentGuaranteeType
    {
        /// <remarks/>
        GuaranteeRequired,
        /// <remarks/>
        None,
        /// <remarks/>
        [XmlEnumAttribute("CC/DC/Voucher")]
        CCDCVoucher,
        /// <remarks/>
        Profile,
        /// <remarks/>
        Deposit,
        /// <remarks/>
        PrePay,
    }

    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum AmountTypeDiscountAppliesTo
    {
        /// <remarks/>
        Base,
        /// <remarks/>
        AdditionalGuestAmount,
        /// <remarks/>
        Fee,
    }

}
