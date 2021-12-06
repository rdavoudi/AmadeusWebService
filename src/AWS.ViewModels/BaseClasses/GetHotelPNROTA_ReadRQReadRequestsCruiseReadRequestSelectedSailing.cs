namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetHotelPNROTA_ReadRQReadRequestsCruiseReadRequestSelectedSailing
    {

        private string voyageIDField;

        private string statusField;

        private string groupCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VoyageID
        {
            get
            {
                return this.voyageIDField;
            }
            set
            {
                this.voyageIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GroupCode
        {
            get
            {
                return this.groupCodeField;
            }
            set
            {
                this.groupCodeField = value;
            }
        }
    }
}