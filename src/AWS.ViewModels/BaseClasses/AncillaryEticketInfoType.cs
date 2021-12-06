namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AncillaryEticketInfoType
    {

        private string documentNumberField;

        private string issuanceTypeCodeField;

        private string issuanceTypeField;

        private System.Nullable<System.DateTime> dateOfIssuanceField;

        private string placeOfIssueField;

        private string internationalIndicatorCodeField;

        private string internationalIndicatorField;

        private string iATANumberField;

        private string endorsableCodeField;

        private string endorsableField;

        private AncillaryTicketRemarkType[] ancillaryTicketRemarkField;

        private AncillaryTicketCouponType[] ancillaryTicketCouponField;

        private AncillaryTicketFareInfoType[] ancillaryTicketFareInfoField;

        private AncillaryTicketFOPType ancillaryTicketFOPField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string DocumentNumber
        {
            get
            {
                return this.documentNumberField;
            }
            set
            {
                this.documentNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string IssuanceTypeCode
        {
            get
            {
                return this.issuanceTypeCodeField;
            }
            set
            {
                this.issuanceTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string IssuanceType
        {
            get
            {
                return this.issuanceTypeField;
            }
            set
            {
                this.issuanceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> DateOfIssuance
        {
            get
            {
                return this.dateOfIssuanceField;
            }
            set
            {
                this.dateOfIssuanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string PlaceOfIssue
        {
            get
            {
                return this.placeOfIssueField;
            }
            set
            {
                this.placeOfIssueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string InternationalIndicatorCode
        {
            get
            {
                return this.internationalIndicatorCodeField;
            }
            set
            {
                this.internationalIndicatorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string InternationalIndicator
        {
            get
            {
                return this.internationalIndicatorField;
            }
            set
            {
                this.internationalIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string IATANumber
        {
            get
            {
                return this.iATANumberField;
            }
            set
            {
                this.iATANumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string EndorsableCode
        {
            get
            {
                return this.endorsableCodeField;
            }
            set
            {
                this.endorsableCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string Endorsable
        {
            get
            {
                return this.endorsableField;
            }
            set
            {
                this.endorsableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AncillaryTicketRemark", Order = 10)]
        public AncillaryTicketRemarkType[] AncillaryTicketRemark
        {
            get
            {
                return this.ancillaryTicketRemarkField;
            }
            set
            {
                this.ancillaryTicketRemarkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AncillaryTicketCoupon", Order = 11)]
        public AncillaryTicketCouponType[] AncillaryTicketCoupon
        {
            get
            {
                return this.ancillaryTicketCouponField;
            }
            set
            {
                this.ancillaryTicketCouponField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AncillaryTicketFareInfo", Order = 12)]
        public AncillaryTicketFareInfoType[] AncillaryTicketFareInfo
        {
            get
            {
                return this.ancillaryTicketFareInfoField;
            }
            set
            {
                this.ancillaryTicketFareInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public AncillaryTicketFOPType AncillaryTicketFOP
        {
            get
            {
                return this.ancillaryTicketFOPField;
            }
            set
            {
                this.ancillaryTicketFOPField = value;
            }
        }
    }
}