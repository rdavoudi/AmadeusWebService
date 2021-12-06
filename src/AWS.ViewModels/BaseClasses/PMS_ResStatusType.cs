namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum PMS_ResStatusType
    {

        /// <remarks/>
        Reserved,

        /// <remarks/>
        Requested,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Request denied")]
        Requestdenied,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("No-show")]
        Noshow,

        /// <remarks/>
        Cancelled,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("In-house")]
        Inhouse,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Checked out")]
        Checkedout,

        /// <remarks/>
        Waitlisted,
    }
}