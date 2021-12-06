namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PNRRemarkChange
    {

        private PNRRemarkInfo pNRRemarkField;

        private PersonNameType personNameField;

        private ChangeDetailActionTypes changeDetailActionField;

        private int segmentIndexField;

        private bool segmentIndexFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PNRRemarkInfo PNRRemark
        {
            get
            {
                return this.pNRRemarkField;
            }
            set
            {
                this.pNRRemarkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public PersonNameType PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ChangeDetailActionTypes ChangeDetailAction
        {
            get
            {
                return this.changeDetailActionField;
            }
            set
            {
                this.changeDetailActionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int SegmentIndex
        {
            get
            {
                return this.segmentIndexField;
            }
            set
            {
                this.segmentIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SegmentIndexSpecified
        {
            get
            {
                return this.segmentIndexFieldSpecified;
            }
            set
            {
                this.segmentIndexFieldSpecified = value;
            }
        }
    }
}