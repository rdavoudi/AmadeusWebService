namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfTransportationTypeTransportationTransportation
    {

        private MultimediaDescriptionsType multimediaDescriptionsField;

        private OperationSchedulesType operationSchedulesField;

        private string descriptiveTextField;

        private string notificationRequiredField;

        private string transportationCodeField;

        private string chargeUnitField;

        private bool includedField;

        private bool includedFieldSpecified;

        private string codeDetailField;

        private string descriptionField;

        private string typicalTravelTimeField;

        private decimal amountField;

        private bool amountFieldSpecified;

        private string existsCodeField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public MultimediaDescriptionsType MultimediaDescriptions
        {
            get
            {
                return this.multimediaDescriptionsField;
            }
            set
            {
                this.multimediaDescriptionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OperationSchedulesType OperationSchedules
        {
            get
            {
                return this.operationSchedulesField;
            }
            set
            {
                this.operationSchedulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string DescriptiveText
        {
            get
            {
                return this.descriptiveTextField;
            }
            set
            {
                this.descriptiveTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NotificationRequired
        {
            get
            {
                return this.notificationRequiredField;
            }
            set
            {
                this.notificationRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransportationCode
        {
            get
            {
                return this.transportationCodeField;
            }
            set
            {
                this.transportationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChargeUnit
        {
            get
            {
                return this.chargeUnitField;
            }
            set
            {
                this.chargeUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Included
        {
            get
            {
                return this.includedField;
            }
            set
            {
                this.includedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludedSpecified
        {
            get
            {
                return this.includedFieldSpecified;
            }
            set
            {
                this.includedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeDetail
        {
            get
            {
                return this.codeDetailField;
            }
            set
            {
                this.codeDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TypicalTravelTime
        {
            get
            {
                return this.typicalTravelTimeField;
            }
            set
            {
                this.typicalTravelTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified
        {
            get
            {
                return this.amountFieldSpecified;
            }
            set
            {
                this.amountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExistsCode
        {
            get
            {
                return this.existsCodeField;
            }
            set
            {
                this.existsCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}