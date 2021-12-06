namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OTA_InsurancePlanSearchRSAvailablePlansAvailablePlanPlanDetail
    {

        private string requiredDocumentTypeField;

        private FormattedTextType planDescriptionField;

        private URL_Type planRulesURLField;

        private System.DateTime startDateField;

        private System.DateTime endDateField;

        private URL_Type quoteDetailURLField;

        private URL_Type bookingDetailURLField;

        private string parentProductNameField;

        private string parentProductCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string RequiredDocumentType
        {
            get
            {
                return this.requiredDocumentTypeField;
            }
            set
            {
                this.requiredDocumentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public FormattedTextType PlanDescription
        {
            get
            {
                return this.planDescriptionField;
            }
            set
            {
                this.planDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public URL_Type PlanRulesURL
        {
            get
            {
                return this.planRulesURLField;
            }
            set
            {
                this.planRulesURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public System.DateTime StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public System.DateTime EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public URL_Type QuoteDetailURL
        {
            get
            {
                return this.quoteDetailURLField;
            }
            set
            {
                this.quoteDetailURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public URL_Type BookingDetailURL
        {
            get
            {
                return this.bookingDetailURLField;
            }
            set
            {
                this.bookingDetailURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParentProductName
        {
            get
            {
                return this.parentProductNameField;
            }
            set
            {
                this.parentProductNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParentProductCode
        {
            get
            {
                return this.parentProductCodeField;
            }
            set
            {
                this.parentProductCodeField = value;
            }
        }
    }
}