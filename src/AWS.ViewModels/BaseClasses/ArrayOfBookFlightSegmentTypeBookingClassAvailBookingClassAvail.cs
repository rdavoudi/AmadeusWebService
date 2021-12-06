namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfBookFlightSegmentTypeBookingClassAvailBookingClassAvail
    {

        private string resBookDesigCodeField;

        private string resBookDesigQuantityField;

        private string resBookDesigStatusCodeField;

        private string rPHField;

        private string availablePTCField;

        private string resBookDesigCabinCodeField;

        private string fareBasisField;

        private string fareTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this.resBookDesigCodeField;
            }
            set
            {
                this.resBookDesigCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigQuantity
        {
            get
            {
                return this.resBookDesigQuantityField;
            }
            set
            {
                this.resBookDesigQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigStatusCode
        {
            get
            {
                return this.resBookDesigStatusCodeField;
            }
            set
            {
                this.resBookDesigStatusCodeField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AvailablePTC
        {
            get
            {
                return this.availablePTCField;
            }
            set
            {
                this.availablePTCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCabinCode
        {
            get
            {
                return this.resBookDesigCabinCodeField;
            }
            set
            {
                this.resBookDesigCabinCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareBasis
        {
            get
            {
                return this.fareBasisField;
            }
            set
            {
                this.fareBasisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareType
        {
            get
            {
                return this.fareTypeField;
            }
            set
            {
                this.fareTypeField = value;
            }
        }
    }
}