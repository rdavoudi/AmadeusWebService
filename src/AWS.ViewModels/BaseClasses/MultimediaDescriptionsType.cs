namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class MultimediaDescriptionsType
    {

        private MultimediaDescriptionType[] multimediaDescriptionField;

        private System.DateTime lastUpdatedField;

        private bool lastUpdatedFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MultimediaDescription", Order = 0)]
        public MultimediaDescriptionType[] MultimediaDescription
        {
            get
            {
                return this.multimediaDescriptionField;
            }
            set
            {
                this.multimediaDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastUpdated
        {
            get
            {
                return this.lastUpdatedField;
            }
            set
            {
                this.lastUpdatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastUpdatedSpecified
        {
            get
            {
                return this.lastUpdatedFieldSpecified;
            }
            set
            {
                this.lastUpdatedFieldSpecified = value;
            }
        }
    }
}