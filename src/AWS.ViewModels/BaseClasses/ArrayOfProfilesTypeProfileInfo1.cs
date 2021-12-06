namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfProfilesTypeProfileInfo1
    {

        private ArrayOfProfilesTypeProfileInfo1ProfilesTypeProfileInfo[] profilesTypeProfileInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProfilesTypeProfileInfo", IsNullable = true, Order = 0)]
        public ArrayOfProfilesTypeProfileInfo1ProfilesTypeProfileInfo[] ProfilesTypeProfileInfo
        {
            get
            {
                return this.profilesTypeProfileInfoField;
            }
            set
            {
                this.profilesTypeProfileInfoField = value;
            }
        }
    }
}