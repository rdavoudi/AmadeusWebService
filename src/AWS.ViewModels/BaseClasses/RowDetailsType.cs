namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RowDetailsType
    {

        private RowDetailsTypeAirSeat[] airSeatsField;

        private RowDetailsTypeAirRowCharacteristics airRowCharacteristicsField;

        private string maxNumberOfSeatsField;

        private string rowNumberField;

        private string airBookDesigCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AirSeat", IsNullable = false)]
        public RowDetailsTypeAirSeat[] AirSeats
        {
            get
            {
                return this.airSeatsField;
            }
            set
            {
                this.airSeatsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public RowDetailsTypeAirRowCharacteristics AirRowCharacteristics
        {
            get
            {
                return this.airRowCharacteristicsField;
            }
            set
            {
                this.airRowCharacteristicsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaxNumberOfSeats
        {
            get
            {
                return this.maxNumberOfSeatsField;
            }
            set
            {
                this.maxNumberOfSeatsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string RowNumber
        {
            get
            {
                return this.rowNumberField;
            }
            set
            {
                this.rowNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirBookDesigCode
        {
            get
            {
                return this.airBookDesigCodeField;
            }
            set
            {
                this.airBookDesigCodeField = value;
            }
        }
    }
}