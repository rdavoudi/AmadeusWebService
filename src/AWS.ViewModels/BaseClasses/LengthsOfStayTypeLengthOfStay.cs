namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class LengthsOfStayTypeLengthOfStay
    {

        private LengthsOfStayTypeLengthOfStayLOS_Pattern lOS_PatternField;

        private string timeField;

        private TimeUnitType timeUnitField;

        private bool timeUnitFieldSpecified;

        private bool openStatusIndicatorField;

        private bool openStatusIndicatorFieldSpecified;

        private LengthsOfStayTypeLengthOfStayMinMaxMessageType minMaxMessageTypeField;

        private bool minMaxMessageTypeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public LengthsOfStayTypeLengthOfStayLOS_Pattern LOS_Pattern
        {
            get
            {
                return this.lOS_PatternField;
            }
            set
            {
                this.lOS_PatternField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeUnitType TimeUnit
        {
            get
            {
                return this.timeUnitField;
            }
            set
            {
                this.timeUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeUnitSpecified
        {
            get
            {
                return this.timeUnitFieldSpecified;
            }
            set
            {
                this.timeUnitFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OpenStatusIndicator
        {
            get
            {
                return this.openStatusIndicatorField;
            }
            set
            {
                this.openStatusIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OpenStatusIndicatorSpecified
        {
            get
            {
                return this.openStatusIndicatorFieldSpecified;
            }
            set
            {
                this.openStatusIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LengthsOfStayTypeLengthOfStayMinMaxMessageType MinMaxMessageType
        {
            get
            {
                return this.minMaxMessageTypeField;
            }
            set
            {
                this.minMaxMessageTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinMaxMessageTypeSpecified
        {
            get
            {
                return this.minMaxMessageTypeFieldSpecified;
            }
            set
            {
                this.minMaxMessageTypeFieldSpecified = value;
            }
        }
    }
}