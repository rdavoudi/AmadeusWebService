namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirSearchPrefsTypeCabinPref
    {

        private CabinType cabinField;

        private bool cabinFieldSpecified;

        private bool majorityCabinField;

        private bool majorityCabinFieldSpecified;

        private bool mandatoryCabinField;

        private bool mandatoryCabinFieldSpecified;

        private string cabinSubtypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CabinType Cabin
        {
            get
            {
                return this.cabinField;
            }
            set
            {
                this.cabinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CabinSpecified
        {
            get
            {
                return this.cabinFieldSpecified;
            }
            set
            {
                this.cabinFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MajorityCabin
        {
            get
            {
                return this.majorityCabinField;
            }
            set
            {
                this.majorityCabinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MajorityCabinSpecified
        {
            get
            {
                return this.majorityCabinFieldSpecified;
            }
            set
            {
                this.majorityCabinFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MandatoryCabin
        {
            get
            {
                return this.mandatoryCabinField;
            }
            set
            {
                this.mandatoryCabinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MandatoryCabinSpecified
        {
            get
            {
                return this.mandatoryCabinFieldSpecified;
            }
            set
            {
                this.mandatoryCabinFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CabinSubtype
        {
            get
            {
                return this.cabinSubtypeField;
            }
            set
            {
                this.cabinSubtypeField = value;
            }
        }
    }
}