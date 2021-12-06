namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfRoomRateTypeFeatureFeature
    {

        private ParagraphType[] descriptionField;

        private string roomAmenityField;

        private string quantityField;

        private string roomViewCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Order = 0)]
        public ParagraphType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomAmenity
        {
            get
            {
                return this.roomAmenityField;
            }
            set
            {
                this.roomAmenityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoomViewCode
        {
            get
            {
                return this.roomViewCodeField;
            }
            set
            {
                this.roomViewCodeField = value;
            }
        }
    }
}