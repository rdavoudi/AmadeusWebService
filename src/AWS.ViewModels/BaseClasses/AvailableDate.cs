namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AvailableDate
    {

        private System.Nullable<System.DateTime>[] availableDatesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute()]
        public System.Nullable<System.DateTime>[] AvailableDates
        {
            get
            {
                return this.availableDatesField;
            }
            set
            {
                this.availableDatesField = value;
            }
        }
    }
}