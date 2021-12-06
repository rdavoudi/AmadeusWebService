namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetHotelPNROTA_ReadRQReadRequestsAirReadRequestQueueInfo
    {

        private GetHotelPNROTA_ReadRQReadRequestsAirReadRequestQueueInfoQueue[] queueField;

        private bool firstItemOnlyIndField;

        private bool firstItemOnlyIndFieldSpecified;

        private bool removeFromQueueIndField;

        private bool removeFromQueueIndFieldSpecified;

        private bool fullDataIndField;

        private bool fullDataIndFieldSpecified;

        private string startDateField;

        private string endDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Queue", Order = 0)]
        public GetHotelPNROTA_ReadRQReadRequestsAirReadRequestQueueInfoQueue[] Queue
        {
            get
            {
                return this.queueField;
            }
            set
            {
                this.queueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FirstItemOnlyInd
        {
            get
            {
                return this.firstItemOnlyIndField;
            }
            set
            {
                this.firstItemOnlyIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FirstItemOnlyIndSpecified
        {
            get
            {
                return this.firstItemOnlyIndFieldSpecified;
            }
            set
            {
                this.firstItemOnlyIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RemoveFromQueueInd
        {
            get
            {
                return this.removeFromQueueIndField;
            }
            set
            {
                this.removeFromQueueIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RemoveFromQueueIndSpecified
        {
            get
            {
                return this.removeFromQueueIndFieldSpecified;
            }
            set
            {
                this.removeFromQueueIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FullDataInd
        {
            get
            {
                return this.fullDataIndField;
            }
            set
            {
                this.fullDataIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FullDataIndSpecified
        {
            get
            {
                return this.fullDataIndFieldSpecified;
            }
            set
            {
                this.fullDataIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }
    }
}