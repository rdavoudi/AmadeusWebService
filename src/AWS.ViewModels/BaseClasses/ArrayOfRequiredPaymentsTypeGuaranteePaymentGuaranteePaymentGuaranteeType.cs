namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public enum ArrayOfRequiredPaymentsTypeGuaranteePaymentGuaranteePaymentGuaranteeType
    {

        /// <remarks/>
        GuaranteeRequired,

        /// <remarks/>
        None,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CC/DC/Voucher")]
        CCDCVoucher,

        /// <remarks/>
        Profile,

        /// <remarks/>
        Deposit,

        /// <remarks/>
        PrePay,
    }
}