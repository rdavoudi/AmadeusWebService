namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AddressHint : DBBaseEntity
    {

        private System.Nullable<System.Guid> entityIDField;

        private string causeCodeField;

        private System.Nullable<System.Guid> preferedAddressIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<System.Guid> EntityID
        {
            get
            {
                return this.entityIDField;
            }
            set
            {
                this.entityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string CauseCode
        {
            get
            {
                return this.causeCodeField;
            }
            set
            {
                this.causeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.Guid> PreferedAddressID
        {
            get
            {
                return this.preferedAddressIDField;
            }
            set
            {
                this.preferedAddressIDField = value;
            }
        }
    }
}