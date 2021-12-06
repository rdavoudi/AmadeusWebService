namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.FlagsAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
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
}