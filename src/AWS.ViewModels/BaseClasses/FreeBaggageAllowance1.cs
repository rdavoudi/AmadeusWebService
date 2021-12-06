namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FreeBaggageAllowance", Namespace = "java:com.thy.websdom.ws.response")]
    public partial class FreeBaggageAllowance1
    {

        private System.Nullable<int> kilosField;

        private System.Nullable<int> piecesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public System.Nullable<int> Kilos
        {
            get
            {
                return this.kilosField;
            }
            set
            {
                this.kilosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public System.Nullable<int> Pieces
        {
            get
            {
                return this.piecesField;
            }
            set
            {
                this.piecesField = value;
            }
        }
    }
}