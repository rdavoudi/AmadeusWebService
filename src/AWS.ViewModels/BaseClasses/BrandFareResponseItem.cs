namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class BrandFareResponseItem
    {

        private int brandIndexField;

        private string brandCodeField;

        private string brandNameField;

        private string brandKeyField;

        private string carrierCodeField;

        private System.Nullable<bool> seatSelectionField;

        private System.Nullable<bool> bonusMileField;

        private System.Nullable<int> bonusMileAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int BrandIndex
        {
            get
            {
                return this.brandIndexField;
            }
            set
            {
                this.brandIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public string BrandCode
        {
            get
            {
                return this.brandCodeField;
            }
            set
            {
                this.brandCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public string BrandName
        {
            get
            {
                return this.brandNameField;
            }
            set
            {
                this.brandNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public string BrandKey
        {
            get
            {
                return this.brandKeyField;
            }
            set
            {
                this.brandKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 4)]
        public string CarrierCode
        {
            get
            {
                return this.carrierCodeField;
            }
            set
            {
                this.carrierCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<bool> SeatSelection
        {
            get
            {
                return this.seatSelectionField;
            }
            set
            {
                this.seatSelectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<bool> BonusMile
        {
            get
            {
                return this.bonusMileField;
            }
            set
            {
                this.bonusMileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<int> BonusMileAmount
        {
            get
            {
                return this.bonusMileAmountField;
            }
            set
            {
                this.bonusMileAmountField = value;
            }
        }
    }
}