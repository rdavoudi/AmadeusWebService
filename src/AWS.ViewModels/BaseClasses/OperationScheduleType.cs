namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class OperationScheduleType
    {

        private ArrayOfOperationScheduleTypeOperationTimeOperationTime[] operationTimesField;

        private string startField;

        private string durationField;

        private string endField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationTime", IsNullable = false)]
        public ArrayOfOperationScheduleTypeOperationTimeOperationTime[] OperationTimes
        {
            get
            {
                return this.operationTimesField;
            }
            set
            {
                this.operationTimesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
    }
}