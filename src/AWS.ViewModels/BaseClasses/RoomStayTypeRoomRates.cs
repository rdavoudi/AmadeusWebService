namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RoomStayTypeRoomRates
    {

        private RoomStayTypeRoomRatesRoomRate[] roomRateField;

        private decimal totalAmountField;

        private bool totalAmountFieldSpecified;

        private bool totalAmountSpecified1Field;

        private string notes1Field;

        private string notes2Field;

        private string notes3Field;

        private bool isGuaranteeField;

        private bool isDepositField;

        private bool moreRatesExistIndField;

        private bool moreRatesExistIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoomRate", Order = 0)]
        public RoomStayTypeRoomRatesRoomRate[] RoomRate
        {
            get
            {
                return this.roomRateField;
            }
            set
            {
                this.roomRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public decimal TotalAmount
        {
            get
            {
                return this.totalAmountField;
            }
            set
            {
                this.totalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalAmountSpecified
        {
            get
            {
                return this.totalAmountFieldSpecified;
            }
            set
            {
                this.totalAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TotalAmountSpecified", Order = 2)]
        public bool TotalAmountSpecified1
        {
            get
            {
                return this.totalAmountSpecified1Field;
            }
            set
            {
                this.totalAmountSpecified1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Notes1
        {
            get
            {
                return this.notes1Field;
            }
            set
            {
                this.notes1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Notes2
        {
            get
            {
                return this.notes2Field;
            }
            set
            {
                this.notes2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string Notes3
        {
            get
            {
                return this.notes3Field;
            }
            set
            {
                this.notes3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public bool IsGuarantee
        {
            get
            {
                return this.isGuaranteeField;
            }
            set
            {
                this.isGuaranteeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public bool IsDeposit
        {
            get
            {
                return this.isDepositField;
            }
            set
            {
                this.isDepositField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MoreRatesExistInd
        {
            get
            {
                return this.moreRatesExistIndField;
            }
            set
            {
                this.moreRatesExistIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MoreRatesExistIndSpecified
        {
            get
            {
                return this.moreRatesExistIndFieldSpecified;
            }
            set
            {
                this.moreRatesExistIndFieldSpecified = value;
            }
        }
    }
}