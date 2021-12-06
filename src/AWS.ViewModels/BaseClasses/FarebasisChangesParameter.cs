namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FarebasisChangesParameter
    {

        private string segmentRefField;

        private string fareBasisField;

        private string passengerTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string SegmentRef
        {
            get
            {
                return this.segmentRefField;
            }
            set
            {
                this.segmentRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string PassengerType
        {
            get
            {
                return this.passengerTypeField;
            }
            set
            {
                this.passengerTypeField = value;
            }
        }
    }
}