namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ScheduleChangeParameter
    {

        private string segmentRefField;

        private System.DateTime newDateField;

        private System.DateTime oldDateField;

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
        public System.DateTime NewDate
        {
            get
            {
                return this.newDateField;
            }
            set
            {
                this.newDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public System.DateTime OldDate
        {
            get
            {
                return this.oldDateField;
            }
            set
            {
                this.oldDateField = value;
            }
        }
    }
}