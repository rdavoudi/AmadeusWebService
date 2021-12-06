namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class RelativePositionType : TransportationsType
    {

        private string directionField;

        private string distanceField;

        private DistanceUnitNameType distanceUnitNameField;

        private bool distanceUnitNameFieldSpecified;

        private string unitOfMeasureCodeField;

        private bool nearestField;

        private bool nearestFieldSpecified;

        private string indexPointCodeField;

        private string nameField;

        private bool primaryIndicatorField;

        private bool primaryIndicatorFieldSpecified;

        private RelativePositionTypeToFrom toFromField;

        private bool toFromFieldSpecified;

        private bool approximateDistanceIndField;

        private bool approximateDistanceIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Distance
        {
            get
            {
                return this.distanceField;
            }
            set
            {
                this.distanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DistanceUnitNameType DistanceUnitName
        {
            get
            {
                return this.distanceUnitNameField;
            }
            set
            {
                this.distanceUnitNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DistanceUnitNameSpecified
        {
            get
            {
                return this.distanceUnitNameFieldSpecified;
            }
            set
            {
                this.distanceUnitNameFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitOfMeasureCode
        {
            get
            {
                return this.unitOfMeasureCodeField;
            }
            set
            {
                this.unitOfMeasureCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Nearest
        {
            get
            {
                return this.nearestField;
            }
            set
            {
                this.nearestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NearestSpecified
        {
            get
            {
                return this.nearestFieldSpecified;
            }
            set
            {
                this.nearestFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IndexPointCode
        {
            get
            {
                return this.indexPointCodeField;
            }
            set
            {
                this.indexPointCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool PrimaryIndicator
        {
            get
            {
                return this.primaryIndicatorField;
            }
            set
            {
                this.primaryIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrimaryIndicatorSpecified
        {
            get
            {
                return this.primaryIndicatorFieldSpecified;
            }
            set
            {
                this.primaryIndicatorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RelativePositionTypeToFrom ToFrom
        {
            get
            {
                return this.toFromField;
            }
            set
            {
                this.toFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ToFromSpecified
        {
            get
            {
                return this.toFromFieldSpecified;
            }
            set
            {
                this.toFromFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ApproximateDistanceInd
        {
            get
            {
                return this.approximateDistanceIndField;
            }
            set
            {
                this.approximateDistanceIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApproximateDistanceIndSpecified
        {
            get
            {
                return this.approximateDistanceIndFieldSpecified;
            }
            set
            {
                this.approximateDistanceIndFieldSpecified = value;
            }
        }
    }
}