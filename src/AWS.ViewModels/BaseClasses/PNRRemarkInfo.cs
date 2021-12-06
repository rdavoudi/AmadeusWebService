namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PNRRemarkInfo
    {

        private string remarkTypeField;

        private string remarkCategoryField;

        private string noteField;

        private int passengerOrderIdField;

        private bool passengerOrderIdFieldSpecified;

        private string segmentsOrderIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RemarkType
        {
            get
            {
                return this.remarkTypeField;
            }
            set
            {
                this.remarkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RemarkCategory
        {
            get
            {
                return this.remarkCategoryField;
            }
            set
            {
                this.remarkCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int PassengerOrderId
        {
            get
            {
                return this.passengerOrderIdField;
            }
            set
            {
                this.passengerOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PassengerOrderIdSpecified
        {
            get
            {
                return this.passengerOrderIdFieldSpecified;
            }
            set
            {
                this.passengerOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SegmentsOrderId
        {
            get
            {
                return this.segmentsOrderIdField;
            }
            set
            {
                this.segmentsOrderIdField = value;
            }
        }
    }
}