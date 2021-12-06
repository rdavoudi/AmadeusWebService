namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VehicleMatchedLocationType
    {

        private VehicleLocationDetailsType locationDetailField;

        private ItemSearchCriterionType[] vehLocSearchCriterionField;

        private string companyNameField;

        private string companyCodeField;

        private bool alternateLocIndField;

        private bool alternateLocIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public VehicleLocationDetailsType LocationDetail
        {
            get
            {
                return this.locationDetailField;
            }
            set
            {
                this.locationDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VehLocSearchCriterion", Order = 1)]
        public ItemSearchCriterionType[] VehLocSearchCriterion
        {
            get
            {
                return this.vehLocSearchCriterionField;
            }
            set
            {
                this.vehLocSearchCriterionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CompanyName
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CompanyCode
        {
            get
            {
                return this.companyCodeField;
            }
            set
            {
                this.companyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AlternateLocInd
        {
            get
            {
                return this.alternateLocIndField;
            }
            set
            {
                this.alternateLocIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AlternateLocIndSpecified
        {
            get
            {
                return this.alternateLocIndFieldSpecified;
            }
            set
            {
                this.alternateLocIndFieldSpecified = value;
            }
        }
    }
}