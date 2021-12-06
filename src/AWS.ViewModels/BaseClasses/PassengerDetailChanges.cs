namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class PassengerDetailChanges
    {

        private ChangeDetail[] changeDetailsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public ChangeDetail[] ChangeDetails
        {
            get
            {
                return this.changeDetailsField;
            }
            set
            {
                this.changeDetailsField = value;
            }
        }
    }
}