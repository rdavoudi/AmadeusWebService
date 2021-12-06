namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AncillaryChangeParameter
    {

        private int segmentRefField;

        private string ancillaryTypeField;

        private decimal newAncillaryFeeField;

        private decimal oldAncillaryFeeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int SegmentRef
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
        public string AncillaryType
        {
            get
            {
                return this.ancillaryTypeField;
            }
            set
            {
                this.ancillaryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public decimal NewAncillaryFee
        {
            get
            {
                return this.newAncillaryFeeField;
            }
            set
            {
                this.newAncillaryFeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public decimal OldAncillaryFee
        {
            get
            {
                return this.oldAncillaryFeeField;
            }
            set
            {
                this.oldAncillaryFeeField = value;
            }
        }
    }
}