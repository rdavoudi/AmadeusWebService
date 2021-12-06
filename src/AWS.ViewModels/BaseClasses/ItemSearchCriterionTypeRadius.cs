namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ItemSearchCriterionTypeRadius
    {

        private string distanceField;

        private string distanceMeasureField;

        private string directionField;

        private string distanceMaxField;

        private string unitOfMeasureCodeField;

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
        public string DistanceMeasure
        {
            get
            {
                return this.distanceMeasureField;
            }
            set
            {
                this.distanceMeasureField = value;
            }
        }

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
        public string DistanceMax
        {
            get
            {
                return this.distanceMaxField;
            }
            set
            {
                this.distanceMaxField = value;
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
    }
}