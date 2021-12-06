namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class HotelReservationTypeQueue
    {

        private string pseudoCityCodeField;

        private string queueNumberField;

        private string queueCategoryField;

        private string systemCodeField;

        private string queueIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PseudoCityCode
        {
            get
            {
                return this.pseudoCityCodeField;
            }
            set
            {
                this.pseudoCityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string QueueNumber
        {
            get
            {
                return this.queueNumberField;
            }
            set
            {
                this.queueNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string QueueCategory
        {
            get
            {
                return this.queueCategoryField;
            }
            set
            {
                this.queueCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SystemCode
        {
            get
            {
                return this.systemCodeField;
            }
            set
            {
                this.systemCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string QueueID
        {
            get
            {
                return this.queueIDField;
            }
            set
            {
                this.queueIDField = value;
            }
        }
    }
}