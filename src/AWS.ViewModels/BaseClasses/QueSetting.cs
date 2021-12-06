namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class QueSetting
    {

        private System.Nullable<int> queNoField;

        private System.Nullable<int> queCategoryNoField;

        private string officeIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<int> QueNo
        {
            get
            {
                return this.queNoField;
            }
            set
            {
                this.queNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<int> QueCategoryNo
        {
            get
            {
                return this.queCategoryNoField;
            }
            set
            {
                this.queCategoryNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string OfficeID
        {
            get
            {
                return this.officeIDField;
            }
            set
            {
                this.officeIDField = value;
            }
        }
    }
}