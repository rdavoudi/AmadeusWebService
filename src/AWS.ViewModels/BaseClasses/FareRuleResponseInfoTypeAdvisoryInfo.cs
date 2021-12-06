﻿namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class FareRuleResponseInfoTypeAdvisoryInfo : FreeTextType
    {

        private string advisoryCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AdvisoryCode
        {
            get
            {
                return this.advisoryCodeField;
            }
            set
            {
                this.advisoryCodeField = value;
            }
        }
    }
}