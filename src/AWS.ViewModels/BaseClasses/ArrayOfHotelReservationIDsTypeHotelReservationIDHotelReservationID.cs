namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfHotelReservationIDsTypeHotelReservationIDHotelReservationID
    {

        private string resID_TypeField;

        private string resID_ValueField;

        private string resID_SourceField;

        private string resID_SourceContextField;

        private System.DateTime resID_DateField;

        private bool resID_DateFieldSpecified;

        private bool forGuestField;

        private string resGuestRPHField;

        private string cancelOriginatorCodeField;

        private System.DateTime cancellationDateField;

        private bool cancellationDateFieldSpecified;

        public ArrayOfHotelReservationIDsTypeHotelReservationIDHotelReservationID()
        {
            this.forGuestField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResID_Type
        {
            get
            {
                return this.resID_TypeField;
            }
            set
            {
                this.resID_TypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResID_Value
        {
            get
            {
                return this.resID_ValueField;
            }
            set
            {
                this.resID_ValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResID_Source
        {
            get
            {
                return this.resID_SourceField;
            }
            set
            {
                this.resID_SourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResID_SourceContext
        {
            get
            {
                return this.resID_SourceContextField;
            }
            set
            {
                this.resID_SourceContextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ResID_Date
        {
            get
            {
                return this.resID_DateField;
            }
            set
            {
                this.resID_DateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResID_DateSpecified
        {
            get
            {
                return this.resID_DateFieldSpecified;
            }
            set
            {
                this.resID_DateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ForGuest
        {
            get
            {
                return this.forGuestField;
            }
            set
            {
                this.forGuestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResGuestRPH
        {
            get
            {
                return this.resGuestRPHField;
            }
            set
            {
                this.resGuestRPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CancelOriginatorCode
        {
            get
            {
                return this.cancelOriginatorCodeField;
            }
            set
            {
                this.cancelOriginatorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime CancellationDate
        {
            get
            {
                return this.cancellationDateField;
            }
            set
            {
                this.cancellationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CancellationDateSpecified
        {
            get
            {
                return this.cancellationDateFieldSpecified;
            }
            set
            {
                this.cancellationDateFieldSpecified = value;
            }
        }
    }
}