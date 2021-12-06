namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AddressDetails : BaseEntity
    {

        private AddressDB[] addressesField;

        private AddressHint[] addresHintsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public AddressDB[] Addresses
        {
            get
            {
                return this.addressesField;
            }
            set
            {
                this.addressesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        public AddressHint[] AddresHints
        {
            get
            {
                return this.addresHintsField;
            }
            set
            {
                this.addresHintsField = value;
            }
        }
    }
}