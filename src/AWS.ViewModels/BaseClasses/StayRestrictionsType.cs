namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class StayRestrictionsType
    {

        private StayRestrictionsTypeMinimumStay minimumStayField;

        private StayRestrictionsTypeMaximumStay maximumStayField;

        private bool stayRestrictionsIndField;

        private bool stayRestrictionsIndFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public StayRestrictionsTypeMinimumStay MinimumStay
        {
            get
            {
                return this.minimumStayField;
            }
            set
            {
                this.minimumStayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public StayRestrictionsTypeMaximumStay MaximumStay
        {
            get
            {
                return this.maximumStayField;
            }
            set
            {
                this.maximumStayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool StayRestrictionsInd
        {
            get
            {
                return this.stayRestrictionsIndField;
            }
            set
            {
                this.stayRestrictionsIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StayRestrictionsIndSpecified
        {
            get
            {
                return this.stayRestrictionsIndFieldSpecified;
            }
            set
            {
                this.stayRestrictionsIndFieldSpecified = value;
            }
        }
    }
}