namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfViewershipsTypeViewershipViewershipBookingChannelCodes
    {

        private ArrayOfViewershipsTypeViewershipViewershipBookingChannelCodesBookingChannelCode[] bookingChannelCodeField;

        private bool channelCodesInclusiveField;

        private bool channelCodesInclusiveFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BookingChannelCode", Order = 0)]
        public ArrayOfViewershipsTypeViewershipViewershipBookingChannelCodesBookingChannelCode[] BookingChannelCode
        {
            get
            {
                return this.bookingChannelCodeField;
            }
            set
            {
                this.bookingChannelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ChannelCodesInclusive
        {
            get
            {
                return this.channelCodesInclusiveField;
            }
            set
            {
                this.channelCodesInclusiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChannelCodesInclusiveSpecified
        {
            get
            {
                return this.channelCodesInclusiveFieldSpecified;
            }
            set
            {
                this.channelCodesInclusiveFieldSpecified = value;
            }
        }
    }
}