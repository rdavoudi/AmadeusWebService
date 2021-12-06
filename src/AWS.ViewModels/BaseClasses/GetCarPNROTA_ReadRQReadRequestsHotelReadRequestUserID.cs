namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetCarPNROTA_ReadRQReadRequestsHotelReadRequestUserID : UniqueID_Type
    {

        private string pinNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PinNumber
        {
            get
            {
                return this.pinNumberField;
            }
            set
            {
                this.pinNumberField = value;
            }
        }
    }
}