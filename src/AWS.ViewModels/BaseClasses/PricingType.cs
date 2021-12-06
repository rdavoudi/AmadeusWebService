namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PricingType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Per stay")]
        Perstay,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Per person")]
        Perperson,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Per night")]
        Pernight,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Per person per night")]
        Perpersonpernight,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Per use")]
        Peruse,
    }
}