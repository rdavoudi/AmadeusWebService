namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class EmployeeInfoType
    {

        private string employeeIdField;

        private string employeeLevelField;

        private string employeeTitleField;

        private string employeeStatusField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EmployeeId
        {
            get
            {
                return this.employeeIdField;
            }
            set
            {
                this.employeeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EmployeeLevel
        {
            get
            {
                return this.employeeLevelField;
            }
            set
            {
                this.employeeLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EmployeeTitle
        {
            get
            {
                return this.employeeTitleField;
            }
            set
            {
                this.employeeTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EmployeeStatus
        {
            get
            {
                return this.employeeStatusField;
            }
            set
            {
                this.employeeStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}