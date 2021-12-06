namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SeatingPrefType
    {

        private PreferLevelType preferLevelField;

        private string seatDirectionField;

        private string seatLocationField;

        private string seatPositionField;

        private string seatRowField;

        private string valueField;

        public SeatingPrefType()
        {
            this.preferLevelField = PreferLevelType.Preferred;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(PreferLevelType.Preferred)]
        public PreferLevelType PreferLevel
        {
            get
            {
                return this.preferLevelField;
            }
            set
            {
                this.preferLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatDirection
        {
            get
            {
                return this.seatDirectionField;
            }
            set
            {
                this.seatDirectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatLocation
        {
            get
            {
                return this.seatLocationField;
            }
            set
            {
                this.seatLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatPosition
        {
            get
            {
                return this.seatPositionField;
            }
            set
            {
                this.seatPositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatRow
        {
            get
            {
                return this.seatRowField;
            }
            set
            {
                this.seatRowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}