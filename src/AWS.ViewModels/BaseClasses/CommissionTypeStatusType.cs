namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum CommissionTypeStatusType
    {

        /// <remarks/>
        Full,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Non-paying")]
        Nonpaying,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("No-show")]
        Noshow,

        /// <remarks/>
        Adjustment,
    }
}