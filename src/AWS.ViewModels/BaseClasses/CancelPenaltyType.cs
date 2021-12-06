namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class CancelPenaltyType
    {

        private CancelPenaltyTypeDeadline deadlineField;

        private AmountPercentType amountPercentField;

        private ParagraphType[] penaltyDescriptionField;

        private string confirmClassCodeField;

        private string policyCodeField;

        private bool nonRefundableField;

        private bool nonRefundableFieldSpecified;

        private bool monField;

        private bool monFieldSpecified;

        private bool tueField;

        private bool tueFieldSpecified;

        private bool wedsField;

        private bool wedsFieldSpecified;

        private bool thurField;

        private bool thurFieldSpecified;

        private bool friField;

        private bool friFieldSpecified;

        private bool satField;

        private bool satFieldSpecified;

        private bool sunField;

        private bool sunFieldSpecified;

        private string startField;

        private string durationField;

        private string endField;

        private string roomTypeCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CancelPenaltyTypeDeadline Deadline
        {
            get
            {
                return this.deadlineField;
            }
            set
            {
                this.deadlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AmountPercentType AmountPercent
        {
            get
            {
                return this.amountPercentField;
            }
            set
            {
                this.amountPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PenaltyDescription", Order = 2)]
        public ParagraphType[] PenaltyDescription
        {
            get
            {
                return this.penaltyDescriptionField;
            }
            set
            {
                this.penaltyDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ConfirmClassCode
        {
            get
            {
                return this.confirmClassCodeField;
            }
            set
            {
                this.confirmClassCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PolicyCode
        {
            get
            {
                return this.policyCodeField;
            }
            set
            {
                this.policyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonRefundable
        {
            get
            {
                return this.nonRefundableField;
            }
            set
            {
                this.nonRefundableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NonRefundableSpecified
        {
            get
            {
                return this.nonRefundableFieldSpecified;
            }
            set
            {
                this.nonRefundableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Mon
        {
            get
            {
                return this.monField;
            }
            set
            {
                this.monField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MonSpecified
        {
            get
            {
                return this.monFieldSpecified;
            }
            set
            {
                this.monFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Tue
        {
            get
            {
                return this.tueField;
            }
            set
            {
                this.tueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TueSpecified
        {
            get
            {
                return this.tueFieldSpecified;
            }
            set
            {
                this.tueFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Weds
        {
            get
            {
                return this.wedsField;
            }
            set
            {
                this.wedsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WedsSpecified
        {
            get
            {
                return this.wedsFieldSpecified;
            }
            set
            {
                this.wedsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Thur
        {
            get
            {
                return this.thurField;
            }
            set
            {
                this.thurField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThurSpecified
        {
            get
            {
                return this.thurFieldSpecified;
            }
            set
            {
                this.thurFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Fri
        {
            get
            {
                return this.friField;
            }
            set
            {
                this.friField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FriSpecified
        {
            get
            {
                return this.friFieldSpecified;
            }
            set
            {
                this.friFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Sat
        {
            get
            {
                return this.satField;
            }
            set
            {
                this.satField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SatSpecified
        {
            get
            {
                return this.satFieldSpecified;
            }
            set
            {
                this.satFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Sun
        {
            get
            {
                return this.sunField;
            }
            set
            {
                this.sunField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SunSpecified
        {
            get
            {
                return this.sunFieldSpecified;
            }
            set
            {
                this.sunFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomTypeCode
        {
            get
            {
                return this.roomTypeCodeField;
            }
            set
            {
                this.roomTypeCodeField = value;
            }
        }
    }
}