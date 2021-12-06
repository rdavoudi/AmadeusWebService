namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class GetCarPNROTA_ReadRQReadRequestsGolfReadRequest
    {

        private GetCarPNROTA_ReadRQReadRequestsGolfReadRequestMembership[] membershipField;

        private PersonNameType nameField;

        private string idField;

        private string roundIDField;

        private string playDateTimeField;

        private string packageIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Membership", Order = 0)]
        public GetCarPNROTA_ReadRQReadRequestsGolfReadRequestMembership[] Membership
        {
            get
            {
                return this.membershipField;
            }
            set
            {
                this.membershipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public PersonNameType Name
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
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string RoundID
        {
            get
            {
                return this.roundIDField;
            }
            set
            {
                this.roundIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PlayDateTime
        {
            get
            {
                return this.playDateTimeField;
            }
            set
            {
                this.playDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PackageID
        {
            get
            {
                return this.packageIDField;
            }
            set
            {
                this.packageIDField = value;
            }
        }
    }
}