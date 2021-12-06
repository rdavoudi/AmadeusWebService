namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AdditionalGuestAmountType
    {

        private TotalType amountField;

        private ParagraphType[] addlGuestAmtDescriptionField;

        private string maxAdditionalGuestsField;

        private string ageQualifyingCodeField;

        private string minAgeField;

        private string maxAgeField;

        private TimeUnitType ageTimeUnitField;

        private bool ageTimeUnitFieldSpecified;

        private string typeField;

        private decimal percentField;

        private bool percentFieldSpecified;

        private string rPHField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TotalType Amount
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
        [System.Xml.Serialization.XmlElementAttribute("AddlGuestAmtDescription", Order = 1)]
        public ParagraphType[] AddlGuestAmtDescription
        {
            get
            {
                return this.addlGuestAmtDescriptionField;
            }
            set
            {
                this.addlGuestAmtDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaxAdditionalGuests
        {
            get
            {
                return this.maxAdditionalGuestsField;
            }
            set
            {
                this.maxAdditionalGuestsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AgeQualifyingCode
        {
            get
            {
                return this.ageQualifyingCodeField;
            }
            set
            {
                this.ageQualifyingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MinAge
        {
            get
            {
                return this.minAgeField;
            }
            set
            {
                this.minAgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaxAge
        {
            get
            {
                return this.maxAgeField;
            }
            set
            {
                this.maxAgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeUnitType AgeTimeUnit
        {
            get
            {
                return this.ageTimeUnitField;
            }
            set
            {
                this.ageTimeUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgeTimeUnitSpecified
        {
            get
            {
                return this.ageTimeUnitFieldSpecified;
            }
            set
            {
                this.ageTimeUnitFieldSpecified = value;
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
        public decimal Percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentSpecified
        {
            get
            {
                return this.percentFieldSpecified;
            }
            set
            {
                this.percentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }
    }
}