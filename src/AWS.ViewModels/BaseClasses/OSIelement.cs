namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OSIelement
    {

        private string airlineIDField;

        private string textField;

        private string subjectQualifierField;

        private string typeField;

        private System.Nullable<int> numberOfAssociatedPassengerField;

        private string numberOfAssociatedSegmentsField;

        private int lineNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string AirlineID
        {
            get
            {
                return this.airlineIDField;
            }
            set
            {
                this.airlineIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string SubjectQualifier
        {
            get
            {
                return this.subjectQualifierField;
            }
            set
            {
                this.subjectQualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<int> NumberOfAssociatedPassenger
        {
            get
            {
                return this.numberOfAssociatedPassengerField;
            }
            set
            {
                this.numberOfAssociatedPassengerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string NumberOfAssociatedSegments
        {
            get
            {
                return this.numberOfAssociatedSegmentsField;
            }
            set
            {
                this.numberOfAssociatedSegmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public int LineNumber
        {
            get
            {
                return this.lineNumberField;
            }
            set
            {
                this.lineNumberField = value;
            }
        }
    }
}