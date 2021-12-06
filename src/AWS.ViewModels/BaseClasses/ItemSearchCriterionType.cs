namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HotelSearchCriterionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ItemSearchCriterionType
    {

        private ItemSearchCriterionTypePosition positionField;

        private ItemSearchCriterionTypeAddress addressField;

        private ItemSearchCriterionTypeTelephone telephoneField;

        private ItemSearchCriterionTypeRefPoint[] refPointField;

        private ItemSearchCriterionTypeCodeRef codeRefField;

        private ItemSearchCriterionTypeHotelRef[] hotelRefField;

        private ItemSearchCriterionTypeRadius radiusField;

        private bool exactMatchField;

        private bool exactMatchFieldSpecified;

        private ItemSearchCriterionTypeImportanceType importanceTypeField;

        private bool importanceTypeFieldSpecified;

        private string rankingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ItemSearchCriterionTypePosition Position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ItemSearchCriterionTypeAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ItemSearchCriterionTypeTelephone Telephone
        {
            get
            {
                return this.telephoneField;
            }
            set
            {
                this.telephoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RefPoint", Order = 3)]
        public ItemSearchCriterionTypeRefPoint[] RefPoint
        {
            get
            {
                return this.refPointField;
            }
            set
            {
                this.refPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public ItemSearchCriterionTypeCodeRef CodeRef
        {
            get
            {
                return this.codeRefField;
            }
            set
            {
                this.codeRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HotelRef", Order = 5)]
        public ItemSearchCriterionTypeHotelRef[] HotelRef
        {
            get
            {
                return this.hotelRefField;
            }
            set
            {
                this.hotelRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public ItemSearchCriterionTypeRadius Radius
        {
            get
            {
                return this.radiusField;
            }
            set
            {
                this.radiusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExactMatch
        {
            get
            {
                return this.exactMatchField;
            }
            set
            {
                this.exactMatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExactMatchSpecified
        {
            get
            {
                return this.exactMatchFieldSpecified;
            }
            set
            {
                this.exactMatchFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemSearchCriterionTypeImportanceType ImportanceType
        {
            get
            {
                return this.importanceTypeField;
            }
            set
            {
                this.importanceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImportanceTypeSpecified
        {
            get
            {
                return this.importanceTypeFieldSpecified;
            }
            set
            {
                this.importanceTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Ranking
        {
            get
            {
                return this.rankingField;
            }
            set
            {
                this.rankingField = value;
            }
        }
    }
}