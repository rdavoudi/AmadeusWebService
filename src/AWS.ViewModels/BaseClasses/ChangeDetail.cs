namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ChangeDetail
    {

        private SpecialReqDetailsType[][] specialRequestsField;

        private PersonNameType personNameField;

        private ChangeDetailDocument documentField;

        private ChangeDetailActionTypes changeDetailActionField;

        private int segmentIndexField;

        private bool segmentIndexFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SpecialRequestChange")]
        [System.Xml.Serialization.XmlArrayItemAttribute("SpecialReqDetails", IsNullable = false, NestingLevel = 1)]
        public SpecialReqDetailsType[][] SpecialRequests
        {
            get
            {
                return this.specialRequestsField;
            }
            set
            {
                this.specialRequestsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ChangeDetailDocument Document
        {
            get
            {
                return this.documentField;
            }
            set
            {
                this.documentField = value;
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