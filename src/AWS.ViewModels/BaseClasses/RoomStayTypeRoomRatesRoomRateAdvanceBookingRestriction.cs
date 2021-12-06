namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RoomStayTypeRoomRatesRoomRateAdvanceBookingRestriction
    {

        private string startField;

        private string durationField;

        private string endField;

        private string minAdvanceBookingOffsetField;

        private string maxAdvanceBookingOffsetField;

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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public string MinAdvanceBookingOffset
        {
            get
            {
                return this.minAdvanceBookingOffsetField;
            }
            set
            {
                this.minAdvanceBookingOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "duration")]
        public string MaxAdvanceBookingOffset
        {
            get
            {
                return this.maxAdvanceBookingOffsetField;
            }
            set
            {
                this.maxAdvanceBookingOffsetField = value;
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
    }
}