namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleReservationRQAdditionalInfoTypeReference))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleAvailCoreTypeReference))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class UniqueID_Type
    {

        private CompanyNameType companyNameField;

        private string uRLField;

        private string typeField;

        private string instanceField;

        private string iD_ContextField;

        private string secondarySplitPNRsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CompanyNameType CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Instance
        {
            get
            {
                return this.instanceField;
            }
            set
            {
                this.instanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID_Context
        {
            get
            {
                return this.iD_ContextField;
            }
            set
            {
                this.iD_ContextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SecondarySplitPNRs
        {
            get
            {
                return this.secondarySplitPNRsField;
            }
            set
            {
                this.secondarySplitPNRsField = value;
            }
        }
    }
}