namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class TravelerInfoTypeAirTraveler : AirTravelerType
    {

        private string[] oSIMessageField;

        private TravelerInfoTypeAirTravelerComment[] commentField;

        private ETicketInfo eTicketDocumentField;

        private ETicketInfo[] eTicketDocumentsField;

        private TravelerInfoTypeAirTravelerETicketURLs[] eTicketURLsField;

        private AncillaryProductType[] ancillaryProductsField;

        private FreeBaggageAllowancesTypes freeBaggageAllowanceField;

        private AncillaryProductTypeBase[] standardAncillaryProductsField;

        private string eTicketNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OSIMessage", Order = 0)]
        public string[] OSIMessage
        {
            get
            {
                return this.oSIMessageField;
            }
            set
            {
                this.oSIMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comment", Order = 1)]
        public TravelerInfoTypeAirTravelerComment[] Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ETicketInfo eTicketDocument
        {
            get
            {
                return this.eTicketDocumentField;
            }
            set
            {
                this.eTicketDocumentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        public ETicketInfo[] eTicketDocuments
        {
            get
            {
                return this.eTicketDocumentsField;
            }
            set
            {
                this.eTicketDocumentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ETicketURLs", Order = 4)]
        public TravelerInfoTypeAirTravelerETicketURLs[] ETicketURLs
        {
            get
            {
                return this.eTicketURLsField;
            }
            set
            {
                this.eTicketURLsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AncillaryProduct", IsNullable = false)]
        public AncillaryProductType[] AncillaryProducts
        {
            get
            {
                return this.ancillaryProductsField;
            }
            set
            {
                this.ancillaryProductsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public FreeBaggageAllowancesTypes FreeBaggageAllowance
        {
            get
            {
                return this.freeBaggageAllowanceField;
            }
            set
            {
                this.freeBaggageAllowanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("StandardAncillaryProduct", IsNullable = false)]
        public AncillaryProductTypeBase[] StandardAncillaryProducts
        {
            get
            {
                return this.standardAncillaryProductsField;
            }
            set
            {
                this.standardAncillaryProductsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string eTicketNumber
        {
            get
            {
                return this.eTicketNumberField;
            }
            set
            {
                this.eTicketNumberField = value;
            }
        }
    }
}