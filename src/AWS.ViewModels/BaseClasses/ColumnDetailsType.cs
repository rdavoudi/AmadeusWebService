namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ColumnDetailsType
    {

        private ColumnDetailsTypeAirColumnCharacteristics airColumnCharacteristicsField;

        private string seatColumnField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ColumnDetailsTypeAirColumnCharacteristics AirColumnCharacteristics
        {
            get
            {
                return this.airColumnCharacteristicsField;
            }
            set
            {
                this.airColumnCharacteristicsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SeatColumn
        {
            get
            {
                return this.seatColumnField;
            }
            set
            {
                this.seatColumnField = value;
            }
        }
    }
}